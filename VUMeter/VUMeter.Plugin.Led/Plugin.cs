using VUMeter.Plugin.Led.Controller;

namespace VUMeter.Plugin.Led
{
    public class Plugin : IPlugin
    {
        private LedVU _ledVU;
        private LedController _ledController;

        public Plugin()
        {
            _ledController = new LedController(new ParallelPortController(0x378,false));
            _ledVU = new LedVU(_ledController);
        }

        public void Start()
        {

        }

        public void Stop()
        {
            
        }

        public string Name
        {
            get { return "LedVUMeter"; }
        }

        public string Description
        {
            get { return "Physical LED VU Meter using parallel port."; }
        }

        public IVU VU
        {
            get { return _ledVU; }
        }
    }
}
