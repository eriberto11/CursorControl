using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace cursorLocker
{
    public partial class Form1 : Form
    {

        int centerX;
        int centerY;
        int SizeOfLock;
        bool isLocked;
        public Form1()
        {
            InitializeComponent();
            setupInts(); 
        }
        private void setupInts()
        {
            centerX = cursorLocker.Properties.Settings.Default.centerX;
            centerY = cursorLocker.Properties.Settings.Default.centerY;

            SizeOfLock = cursorLocker.Properties.Settings.Default.sizeOfLimit;

            Console.Write("Loading vars : y=" + cursorLocker.Properties.Settings.Default.centerY);
            numericUpDown1.Value = centerX;
            numericUpDown2.Value = centerY;
            numericUpDown3.Value = SizeOfLock;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!isLocked)
            {
                //  Application.Exit();
                Console.Write("Setting X= " + centerX + " Y=" + centerY + " size= " + SizeOfLock + "\n");
                // this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Clip = new Rectangle(centerX - (int)SizeOfLock / 2, centerY - (int)SizeOfLock / 2, SizeOfLock, SizeOfLock);
                //  this.TopMost = true;
                isLocked = true;
              //  button2.Text = "Release Lock";
                //button2.Update();
            }
            else
            {
                //button2.Text = "Set Cursor Lock";
                //button2.Update();
                isLocked = false;
                Cursor.Clip = new Rectangle();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(sender is NumericUpDown)
            {
                NumericUpDown nu =(NumericUpDown) sender;
                centerX = (int)nu.Value;
                cursorLocker.Properties.Settings.Default.centerX=centerX;
                cursorLocker.Properties.Settings.Default.Save();
            }
        
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if(sender is NumericUpDown)
            {
                NumericUpDown nU = (NumericUpDown)sender;
                centerY = (int)nU.Value;
                cursorLocker.Properties.Settings.Default.centerY = centerY;
                cursorLocker.Properties.Settings.Default.Save();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if(sender is NumericUpDown)
            {
                NumericUpDown nu = (NumericUpDown)sender;
                SizeOfLock = (int)nu.Value;
                cursorLocker.Properties.Settings.Default.sizeOfLimit = SizeOfLock;
                cursorLocker.Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void setCursorLock()
        {

            if(centerX==0 ||centerY==0 || SizeOfLock == 0)
            {
                Console.Write("In setcursorLock, center etc =0\n");
            }
            else
            {
                if (isLocked == true)
                {
             //       Console.Write("In setcursorLock, TRUE\n");
                    Cursor.Clip = new Rectangle(centerX - (int)SizeOfLock / 2, centerY - (int)SizeOfLock / 2, SizeOfLock, SizeOfLock);

                }else
                {

           //         Console.Write("In setcursorLock, FALSE\n");
                }
            }
        }
    }
}
