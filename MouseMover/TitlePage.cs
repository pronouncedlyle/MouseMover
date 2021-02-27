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

        //method to actually move the mouse
        private void MoveCursorThere()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        //TODO method to move the mouse back


        //Initialize Timer
        private void InitializeTimer()
        {
            Timer1.Interval = (5 * 1000);
            Timer1.Tick += new EventHandler(Timer1_Tick);
        }

        //action to occur when timer hits designated interval
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            MoveCursorThere();
        }

        //method to turn it on
        private void begin_Click(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        //method to turn it off
        private void stop_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
        }
    }
}
