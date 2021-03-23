using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMover
{
    public partial class TitlePage : Form
    {
        public TitlePage()
        {
            InitializeComponent();
        }

        //Initializes Timer
        private void InitializeTimer()
        {
            Timer1.Interval = 3000;
            Timer1.Tick += new EventHandler(Timer1_Tick);
        }

        //Method to move the mouse.
        private void MoveCursorThere()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        //Method to move the mouse back.
        private void MoveCursorBack()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        //Boolean to use in loop within timer function.
        bool there = false;

        //Method that implements action to occur when timer hits designated interval. Moves the mouse.
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            //Loop based on "there" variable. Just switches back and forth to move cursor back to original position.
            if (there == false)
            {
                MoveCursorBack();
                there = true;
            }
            else
            {
                MoveCursorThere();
                there = false;
            }
        }

        //Method that starts the timer.
        private void start_Click(object sender, EventArgs e)
        {
            //Loop will show error message if no interval is selected and will not start the timer.
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an interval.", "No interval selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Timer1.Start();
            }
        }

        //Method that stops the timer.
        private void stop_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
        }

        //Changes the interval variable based on the user's combobox input.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
            int intervalIndex = this.comboBox1.SelectedIndex;

            if (intervalIndex == 0) {Timer1.Interval = 3000;}
            if (intervalIndex == 1) {Timer1.Interval = 10000;}
            if (intervalIndex == 2) {Timer1.Interval = 30000;}
            if (intervalIndex == 3) {Timer1.Interval = 60000;}
            if (intervalIndex == 4) {Timer1.Interval = 300000;}
            if (intervalIndex == 5) {Timer1.Interval = 600000;}
        }
    }
}
