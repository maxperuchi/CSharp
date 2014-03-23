using VUMeter.Plugin.Led.Controller;

namespace VUMeter
{
    public class LedVU : IVU
    {
        private LedController _ledController;
        public LedVU(LedController ledController)
        {
            this._ledController = ledController;
        }
        public void setLevel(int value)
        {
            if (value == 0)
            {
                _ledController.TurnOff();
                return;
            }

            _ledController.TurnOn(1, value);
        }

        public void setMaxLevel(int value)
        {
            throw new System.NotImplementedException();
        }

        public int getMaxLevel()
        {
            return 7;
        }
    }
}
