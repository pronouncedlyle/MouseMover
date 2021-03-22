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

        //TODO: add icon to window, general aesthetics. Try to deploy it outside of IDE.

        //bool to use in loop within timer function. Can't think of a better way to do this, but I'm betting there is one.
        bool there = false;

        //method to actually move the mouse
        private void MoveCursorThere()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        //method to move the mouse back
        private void MoveCursorBack()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        //Initialize Timer
        private void InitializeTimer()
        {
            Timer1.Interval = 3000;
            Timer1.Tick += new EventHandler(Timer1_Tick);
        }

        //action to occur when timer hits designated interval
        private void Timer1_Tick(object Sender, EventArgs e)
        {
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

        //method to turn it on
        private void begin_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an interval.", "No interval selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Timer1.Start();
            }
        }

        //method to turn it off
        private void stop_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
        }

        //method to change interval variable based on combobox input
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
            int intervalIndex = this.comboBox1.SelectedIndex;

            if (intervalIndex == 0){Timer1.Interval = 3000;}
            if (intervalIndex == 1) {Timer1.Interval = 10000;}
            if (intervalIndex == 2) {Timer1.Interval = 30000;}
            if (intervalIndex == 3) {Timer1.Interval = 60000;}
            if (intervalIndex == 4) {Timer1.Interval = 300000;}
            if (intervalIndex == 5) {Timer1.Interval = 600000;}
        }
    }
}
