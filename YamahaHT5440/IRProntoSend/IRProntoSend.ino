#include <IRremote.h>
#include <IRremoteInt.h>

//-- Turn this off to stop serial verbosity
#define DEBUG

IRsend irsend;


char code[381] = "";

//-- Keeping it at global scope to avoid too deep a stack using arguments.

char* ptr = 0;

//---------------------------------------------------------------------------
// Pulls a byte from the buffer, skips spaces and such, increments the buffer
// pointer.
// Returns 0 if in trouble so the show goes on (no abort code).

byte ReadByte() {
	while (ptr && *ptr) {
		char c = *ptr++;
#ifdef DEBUG
		Serial.print(c);
#endif
		//-- Skip HT, LF, CR, and Space
		if (c == 9 || c == 10 || c == 13 || c == 32)
			continue;
		return c;
	}
	return 0;
}

//---------------------------------------------------------------------------
// Pulls an ASCII HEX number from the buffer and returns it as an int.
// Returns 0 if in trouble so the show goes on (no abort code).

int ReadHexDigit() {
	byte c = ReadByte();
	if (c >= '0' && c <= '9') {
		return c - '0';
	} else if (c >= 'a' && c <= 'f') {
		return c - 'a' + 10;
	} else if (c >= 'A' && c <= 'F') {
		return c - 'A' + 10;
	} else {
		return 0;   
	}
}

//---------------------------------------------------------------------------
// Pulls an ASCII HEX byte (two ASCII numbers) from the buffer and returns it
// as an int.

int ReadHexByte() {
	return (ReadHexDigit() << 4) | ReadHexDigit();
}

//---------------------------------------------------------------------------
// Pulls an ASCII HEX word (four ASCII numbers) from the buffer and returns it
// as an int.

int ReadHexWord() {
	int w = (ReadHexByte() << 8) | ReadHexByte();
#ifdef DEBUG
	Serial.print(": ");
	Serial.println(w);
#endif
	return w;
}

//---------------------------------------------------------------------------
// Creates a temporary memory buffer for holding the binary time data, pulls
// a stream of ASCII HEX words (burst pairs) from the Pronto buffer, convert
// these to time units (milliseconds), and sends it all over to irsend.

void ProntoSendSequence(float freq, int count) {
	int i,w;
	if (count) {
		//-- Data comes in pairs. Double up.
		count = count << 1;
		unsigned int* buffer = (unsigned int*)malloc(count * sizeof(unsigned int));
		if (!buffer)
			return;
		for (i = 0; i < count; i++) {
			w = ReadHexWord();
			//-- Avoid problems with garbage data
			if (w < 1) w = 1;
			buffer[i] = (unsigned int)(1000.0/freq*(float)w); 
		}
		irsend.sendRaw(buffer,count,freq);
		free(buffer);
	}
#ifdef DEBUG
	Serial.print("Sent ");
	Serial.print(count >> 1);
	Serial.println(" burst pairs.");
#endif
}

//---------------------------------------------------------------------------
// Parses the Pronto code preamble and sends the burst pairs out.

void SendProntHex() {
	//-- Initialize pointer
 ptr = code;
 
	//-- Code Type is always 0 (Learned)
	if (ReadHexWord() != 0)
		return;
	//-- Read Carrier Frequency
	int freq = ReadHexWord();
	if (freq == 0)
		return;
	//-- Frequency (in kHz) is 1,000 / (x * 0.241246), round up if needed.
	freq = (int)((1000.0/((float)freq*0.241246))+0.5);
	//-- Check for bogus frequency value
	if (freq < 10 || freq > 100)
		return;
#ifdef DEBUG
	Serial.print("Frequency: ");
	Serial.print(freq);
	Serial.println("kHz");
#endif
	//-- Read Burst Pair count
	int burstSeq1 = ReadHexWord();
	if (burstSeq1 < 0)
		return;
	int burstSeq2 = ReadHexWord();
	if (burstSeq2 < 0)
		return;
#ifdef DEBUG
	Serial.print("Sequence 1: ");
	Serial.print(burstSeq1);
	Serial.println(" burst pairs.");
	Serial.print("Sequence 2: ");
	Serial.print(burstSeq2);
	Serial.println(" burst pairs.");
#endif
	//-- Send Sequences
	ProntoSendSequence((float)freq,burstSeq1);
	ProntoSendSequence((float)freq,burstSeq2);
}

//---------------------------------------------------------------------------
// Arduino's version of a constructor

void setup() {
	Serial.begin(9600);
}

//---------------------------------------------------------------------------
// Main system loop. Just sits around waiting for something to show up on the
// serial line.

void loop() {
    
    String tmp = "";
    tmp = Serial.readString();
    if (tmp != "")
    {
      tmp.toCharArray(code, 381);

      SendProntHex();
    }
	}


