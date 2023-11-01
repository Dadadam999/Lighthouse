using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Маяки
{
    public class LightHouse
    {
        private Dictionary<bool, Color> _statusColor = new Dictionary<bool, Color>
        {
            { true, Color.Blue  },
            { false, Color.Red },
        };

        private bool _isEnabled = false;
        private int _enabledCount = 0;
        private int _disabledСount = 0;
        private int _secondCount = 0;

        public int Duration { get; set; }

        public Label CounterLabel { get; }

        public PictureBox Picture { get; }

        public bool WasEverEnabled { get; private set; } = false;


        public LightHouse( Label counter, PictureBox picture, int duration )
        {
            Picture = picture;
            CounterLabel = counter;
            Duration=duration;
        }

        public bool IsEnabled() => _isEnabled;

        public int GetEnabledCount() => _enabledCount;

        public int GetDisabledCount() => _disabledСount;

        public int TotalDuration => Duration * 2;

        private void SetCounterLabel() => CounterLabel.Text = $"On {_enabledCount}, Off {_disabledСount}";

        public void SetDefault()
        {
            _isEnabled = false;
            Picture.BackColor = _statusColor[_isEnabled];
            _disabledСount = 0;
            _enabledCount = 0;
            SetCounterLabel();
        }

        public void ChangeState()
        {
            if( _isEnabled )
            {
                TurnOff();
                return;
            }

            TurnOn();
        }

        private void TurnOn()
        {
            _isEnabled = true;
            WasEverEnabled = true;
            _enabledCount++;
            Picture.BackColor= _statusColor[_isEnabled];
            SetCounterLabel();
        }

        private void TurnOff()
        {
            _isEnabled = false;
            _disabledСount++;
            Picture.BackColor= _statusColor[_isEnabled];
            SetCounterLabel();
        }

        public bool CheckTimerForChanged()
        {
            if( _secondCount >= Duration )
            {
                _secondCount = 0;
                return true;
            }

            _secondCount++;
            return false;
        }
    }
}
