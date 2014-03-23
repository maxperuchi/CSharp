using System.Diagnostics;
using CoreAudioApi;
using System;
using System.Threading;

namespace VUMeter.Controller
{
    public class VUController
    {
        private IVU _vu;
        private MMDevice _deviceRender;
        private MMDeviceEnumerator _devEnum;
        private Thread _thread;

        public VUController(IVU vu)
        {
            this._vu = vu;
            this._devEnum = new MMDeviceEnumerator();
            this._deviceRender = _devEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);

            var valor = _deviceRender.AudioMeterInformation.MasterPeakValue;
            _thread = new Thread(new ThreadStart(UpdateLevel));
        }

        private void UpdateLevel()
        {
            while (true)
            {
                var valor = _deviceRender.AudioMeterInformation.MasterPeakValue * 350;

                if (valor > 0 && valor <= 50)
                {
                    valor = 1;
                }
                else if (valor > 50 && valor <= 80)
                {
                    valor = 2;
                }
                else if (valor > 80 && valor <= 120)
                {
                    valor = 3;
                }
                else if (valor > 120 && valor <= 150)
                {
                    valor = 4;
                }
                else if (valor > 150 && valor <= 190)
                {
                    valor = 5;
                }
                else if (valor > 190 && valor <= 194)
                {
                    valor = 6;
                }
                else if (valor > 194)
                {
                    valor = 7;
                }
                else
                {
                    valor = 0;
                }

                _vu.setLevel((int)valor);
            }
        }

        public void Start()
        {
            _thread.Start();
        }

        public void Stop()
        {
            _thread.Abort();
        }

        public IVU VU
        {
            get
            {
                return this._vu;
            }
        }
    }
}
