using System;
using System.Collections.Generic;
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
                new LightHouse(LightHouseLabel1, LightHouseImage1, 3),
                new LightHouse(LightHouseLabel2, LightHouseImage2, 4),
                new LightHouse(LightHouseLabel3, LightHouseImage3, 5),
            };
        }

        private void button1_Click( object sender, EventArgs e )
        {
            _lightHouses.ForEach( lightHouse => lightHouse.SetDefault() );
            _secondCount = 0;
            timer1.Start();
        }
        private void timer1_Tick( object sender, EventArgs e )
        {
            _lightHouses.ForEach( lightHouses =>
            {
                if( lightHouses.CheckTimerForChanged() )
                {
                    lightHouses.ChangeState();
                }
            } );

            TimerLabel.Text = "Время: " + _secondCount++;

            if( _lightHouses.Exists( lightHouse => lightHouse.IsEnabled() || !lightHouse.WasEverEnabled ) )
            {
                timer1.Stop();
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            _lightHouses.ForEach( lightHouse => lightHouse.SetDefault() );
            _secondCount = 0;
            timer2.Start();
        }

        private void timer2_Tick( object sender, EventArgs e )
        {
            _lightHouses.ForEach( lightHouses =>
            {
                if( lightHouses.CheckTimerForChanged() )
                {
                    lightHouses.ChangeState();
                }
            } );

            TimerLabel.Text = "Время: " + _secondCount++;

            if( !_lightHouses.Exists( lightHouse => lightHouse.IsEnabled() || !lightHouse.WasEverEnabled ) )
            {
                timer1.Stop();
            }
        }
    }
}
