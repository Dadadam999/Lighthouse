using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Маяки
{
    public class LightHouse
    {
        private Dictionary<bool, Color> _statusColor = new Dictionary<bool, Color>
        {
            { true, Color.Red  },
            { false, Color.Blue },
        };

        public bool IsEnabled { get; private set; } = false;
        public int EnabledCount { get; private set; } = 0;
        public int DisabledСount { get; private set; } = 0;

        public Label CounterLabel { get; }
        public PictureBox Picture { get; }
        public BeaconTimer BeaconTimer { get; }

        public LightHouse( Label counter, PictureBox picture, BeaconTimer beaconTimer )
        {
            Picture = picture;
            BeaconTimer = beaconTimer;
            CounterLabel = counter;
        }

        public void SetDefault()
        {
            IsEnabled = false;
            Picture.BackColor = _statusColor[IsEnabled];
            DisabledСount = 0;
            EnabledCount = 0;
            SetCounterLabel();
        }

        public void ChangeState()
        {
            if( IsEnabled )
            {
                TurnOff();
                return;
            }

            TurnOn();
        }

        private void SetCounterLabel() => CounterLabel.Text = $"On {EnabledCount}, Off {DisabledСount}";

        private void TurnOn()
        {
            IsEnabled = true;
            EnabledCount++;
            Picture.BackColor= _statusColor[IsEnabled];
            SetCounterLabel();
        }

        private void TurnOff()
        {
            IsEnabled = false;
            DisabledСount++;
            Picture.BackColor= _statusColor[IsEnabled];
            SetCounterLabel();
        }
    }
}
