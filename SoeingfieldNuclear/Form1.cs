using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SoeingfieldNuclear
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void reactor1Label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            //Changes output label
            outputLabel.Text = "Meltdown Imminent!!!";



            for (int i = 1; i <= 5; i++)

            {

                //Changes Output Label Colour    
                outputLabel.BackColor = Color.Red;

                //Reactors Change to color red
                reactor1StateLabel.BackColor = Color.Red;
                reactor2StateLabel.BackColor = Color.Red;

                //Displays radioactive symbole

                radioactiveImage1.Visible = true;
                radioactiveImage2.Visible = true;

                Refresh();
                Thread.Sleep(1000);

                reactor1StateLabel.BackColor = Color.Black;
                reactor2StateLabel.BackColor = Color.Black;


                radioactiveImage1.Visible = false;
                radioactiveImage2.Visible = false;

                outputLabel.BackColor = Color.White;

                Refresh();
                Thread.Sleep(1000);


            }


        }



        private void radioactiveImage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void temperatureControlButton_Click(object sender, EventArgs e)
        {
            //Opens Temperature Control System
            temperatureControlLabel.Visible = true;
            temperatureControlExitButton.Parent = temperatureControlLabel;
            temperatureControlExitButton.Location = new Point(220, 0);
            temperatureControlExitButton.Visible = true;
            temperatureDisplay.Visible = true;
            raiseTemperature.Visible = true;
            lowerTemperature.Visible = true;
        }

        private void temperatureControlExitButton_Click(object sender, EventArgs e)
        {
            //Closes Temperature Control System
            temperatureControlLabel.Visible = false;
            temperatureControlExitButton.Visible = false;
            temperatureDisplay.Visible = false;
            raiseTemperature.Visible = false;
            lowerTemperature.Visible = false;
        }

        private int i = 900;
        protected void raiseTemperature_Click(object sender, EventArgs e)
        {
            temperatureDisplay.Text = " ";
            i += 100;
            if (i > 2400)
            {
                raiseTemperature.Visible = false;
                outputLabel.Text = "Meltdown Imminent!!!";
                for (int i = 1; i <= 5; i++)

                {

                    //Changes Output Label Colour    
                    outputLabel.BackColor = Color.Red;

                    //Reactors Change to color red
                    reactor1StateLabel.BackColor = Color.Red;
                    reactor2StateLabel.BackColor = Color.Red;

                    //Displays radioactive symbole

                    radioactiveImage1.Visible = true;
                    radioactiveImage2.Visible = true;

                    Refresh();
                    Thread.Sleep(1000);

                    reactor1StateLabel.BackColor = Color.Black;
                    reactor2StateLabel.BackColor = Color.Black;


                    radioactiveImage1.Visible = false;
                    radioactiveImage2.Visible = false;

                    outputLabel.BackColor = Color.White;

                    Refresh();
                    Thread.Sleep(1000);


                }
            }



            temperatureDisplay.Text = i.ToString();
        }

        private void temperatureDisplay_Click(object sender, EventArgs e)
        {
            int temperatureDisplay = 300;
            Console.WriteLine(temperatureDisplay);
        }

        protected void lowerTemperature_Click(object sender, EventArgs e)
        {
            temperatureDisplay.Text = " ";
            i -= 100;
            if (i < -2400)
            {
                raiseTemperature.Visible = false;
                outputLabel.Text = "Freezedown Imminent!!!";
                for (int i = 1; i <= 5; i++)

                {

                    //Changes Output Label Colour    
                    outputLabel.BackColor = Color.Red;

                    //Reactors Change to color red
                    reactor1StateLabel.BackColor = Color.Red;
                    reactor2StateLabel.BackColor = Color.Red;

                    //Displays radioactive symbole

                    radioactiveImage1.Visible = true;
                    radioactiveImage2.Visible = true;

                    Refresh();
                    Thread.Sleep(1000);

                    reactor1StateLabel.BackColor = Color.Black;
                    reactor2StateLabel.BackColor = Color.Black;


                    radioactiveImage1.Visible = false;
                    radioactiveImage2.Visible = false;

                    outputLabel.BackColor = Color.White;

                    Refresh();
                    Thread.Sleep(1000);
                    
                }
            
            }
            temperatureDisplay.Text = i.ToString();
        }
    }
}

