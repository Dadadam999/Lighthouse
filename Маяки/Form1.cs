using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Маяки
{
    public partial class Form1 : Form
    {
        private List<LightHouse> _lightHouses;
        private int _secondCount = 0;

        public Form1()
        {
            InitializeComponent();

            _lightHouses = new List<LightHouse>
            {
                new LightHouse(LightHouseLabel1, LightHouseImage1, new BeaconTimer(3)),
                new LightHouse(LightHouseLabel2, LightHouseImage2, new BeaconTimer(4)),
                new LightHouse(LightHouseLabel3, LightHouseImage3, new BeaconTimer(5)),
            };
        }

        private void StartClick( object sender, EventArgs e )
        {
            _lightHouses.ForEach( lightHouse =>
            {
                lightHouse.SetDefault();
                lightHouse.ChangeState();
            } );

            _secondCount = 0;
            timer2.Start();
        }

        private void TimerTick( object sender, EventArgs e )
        {
            TimerLabel.Text = "Секунда: " + ++_secondCount;

            _lightHouses.ForEach( lightHouses =>
            {
                if( lightHouses.BeaconTimer.CheckAndCountForChanged() )
                {
                    lightHouses.ChangeState();
                }
            } );

            if( _lightHouses.All( lightHouse => lightHouse.BeaconTimer.IsChanged && lightHouse.IsEnabled ) )
            {
                timer2.Stop();
            }

            File.AppendAllText( "log.txt", $"second {_secondCount}  {string.Join( "   ", _lightHouses.Select( lightHouse => lightHouse.IsEnabled ).ToArray() )}" + Environment.NewLine );
        }
    }
}
