namespace VUMeter.Plugin.Led.Controller
{
    public class LedController
    {
        private ParallelPortController _parallelPortController;
        private bool[] _leds;
        public LedController(ParallelPortController parallelPortController)
        {
            this._parallelPortController = parallelPortController;
            this._leds = new bool[7];
        }

        public void TurnOff()
        {
            _parallelPortController.Write(0);
        }

        public void TurnOn(int ledNumber)
        {
            short byteCounter = 1;
            for (int i = 1; i <= ledNumber - 1; i++)
            {
                byteCounter += byteCounter;

            }

            _parallelPortController.Write(byteCounter);
        }

        public void TurnOn(int firstLed, int lastLed)
        {
            if (firstLed == lastLed)
            {
                TurnOn(firstLed);
                return;
            }

            short byteCounter = 1;
            int contador = lastLed;
            int incremento = 1;

            if (firstLed > 1)
            {
                contador = lastLed - firstLed;
                byteCounter = 6;
                incremento = 2;
                for (int i = 2; i < firstLed; i++)
                {
                    byteCounter += byteCounter;
                    incremento += incremento;
                }
            }

            for (int i = 2; i<= contador; i++)
            {
                byteCounter += byteCounter;
                byteCounter += (short)incremento;
            }

            _parallelPortController.Write(byteCounter);
        }

    }
}
