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
            //  Application.Exit();
            Console.Write("writing X= "+centerX+" Y="+centerY+" size= "+SizeOfLock+"\n");
           // this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Clip = new Rectangle(centerX - (int)SizeOfLock/2, centerY - (int)SizeOfLock/2, SizeOfLock , SizeOfLock );
          //  this.TopMost = true;
            isLocked = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(sender is NumericUpDown)
            {
                NumericUpDown nu =(NumericUpDown) sender;
                centerX = (int)nu.Value;
            }
        
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if(sender is NumericUpDown)
            {
                NumericUpDown nU = (NumericUpDown)sender;
                centerY = (int)nU.Value;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if(sender is NumericUpDown)
            {
                NumericUpDown nu = (NumericUpDown)sender;
                SizeOfLock = (int)nu.Value;
         
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

            }
            else
            {
                if(isLocked==true)
                Cursor.Clip = new Rectangle(centerX - (int)SizeOfLock / 2, centerY - (int)SizeOfLock / 2, SizeOfLock, SizeOfLock);
            }
        }
    }
}
