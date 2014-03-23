namespace VUMeter.Plugin.PBar
{
    public class Plugin : IPlugin
    {
        PBarVUWindow _window;
        PBarVU _vu;

        public Plugin()
        {
            this._vu = new PBarVU();
            this._vu.Name = "pBarVU";
            this._vu.Maximum = 7;
            this._vu.Size = new System.Drawing.Size(275,23);
        }

        public void Start()
        {
            _window = new PBarVUWindow();
            _window.Controls.Add(_vu);
            _window.Controls[_vu.Name].Location = new System.Drawing.Point(13, 13);
            _window.Show();
        }

        public void Stop()
        {
            if (_window != null)
                _window.Hide();
        }

        public string Name
        {
            get
            {
                return "PBarVUMeter";
            }
        }

        public string Description
        {
            get
            {
                return "A Simple Progress Bar VU Meter plugin.";
            }
        }

        public IVU VU
        {
            get
            {
                return _vu;
            }
        }
    }
}
