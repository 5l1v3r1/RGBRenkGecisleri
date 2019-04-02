using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBGTumRenkGecisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.FromArgb(R,G,B);
            label1.Text = "R:" + R + " G:" + G + " B:" + B;
        }

        int R = 255, G = 0, B = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (R==255 && G==0 && B<=255)
            {
                if (B<255)
                {
                    B++;
                }
            }
            if (R>=0 && G==0 && B==255)
            {
                if (R>0)
                {
                    R--;
                }
            }
            if (R==0 && G<=255 && B==255)
            {
                if (G<255)
                {
                    G++;
                }
            }
            if (R==0 && G==255 && B>=0)
            {
                if (B>0)
                {
                    B--;
                }
            }

            if (R<=255 && G == 255 && B==0)
            {
                if (R<255)
                {
                    R++;
                }
            }
            if (R==255 && G>=0 && B>=0)
            {
                if (G>0)
                {
                    G--;
                }
            }
            this.BackColor=Color.FromArgb(R,G,B);
           label1.Text = "R:" + R + " G:" + G + " B:" + B;
        
        }
    }
}
