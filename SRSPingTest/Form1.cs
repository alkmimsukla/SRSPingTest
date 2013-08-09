using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace SRSPingTest
{
    public partial class Form1 : Form
    {
        private Timer tmr = new Timer();
        private pingTester pingTest;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Chama o evento Ticks
            tmr.Enabled = true;
            tmr.Interval = 15000;
            tmr.Tick += new EventHandler(Ticks);

            pingTest = new pingTester();
        }

        private void Ticks(object sender, EventArgs e)
        {
            ////TESTE ARCADRIANO
            //if (pingTest.testaARCADRIANO())
            //    picLNBR_pc.Image = imageList1.Images[0];
            //else
            //    picLNBR_pc.Image = imageList1.Images[1];

            ////TESTE ARCLABORATORIO
            //if (pingTest.testaARCLAB())
            //    picLNBR_mx.Image = imageList1.Images[0];
            //else
            //    picLNBR_mx.Image = imageList1.Images[1];

            //CYLINDER HEAD PC
            if (pingTest.testaPCCYH())
                picCYH_pc.Image = imageList1.Images[0];
            else
                picCYH_pc.Image = imageList1.Images[1];

            //CYLINDER HEAD MOXA
            if (pingTest.testaMXCYH())
                picCYH_mx.Image = imageList1.Images[0];
            else
                picCYH_mx.Image = imageList1.Images[1];

            //SHORT BLOCK SETUP PC
            if (pingTest.testaPCSHBS())
                picSHBS_pc.Image = imageList1.Images[0];
            else
                picSHBS_pc.Image = imageList1.Images[1];

            //SHORT BLOCK SETUP MOXA
            if (pingTest.testaMXSHBS())
                picSHBS_mx.Image = imageList1.Images[0];
            else
                picSHBS_mx.Image = imageList1.Images[1];

            //SHORT BLOCK RELEASE PC
            if (pingTest.testaPCSHBR())
                picSHBR_pc.Image = imageList1.Images[0];
            else
                picSHBR_pc.Image = imageList1.Images[1];

            //SHORT BLOCK RELEASE MOXA
            if (pingTest.testaMXSHBR())
                picSHBR_mx.Image = imageList1.Images[0];
            else
                picSHBR_mx.Image = imageList1.Images[1];

            //LONG BLOCK SETUP PC
            if (pingTest.testaPCLNBS())
                picLNBS_pc.Image = imageList1.Images[0];
            else
                picLNBS_pc.Image = imageList1.Images[1];

            //LONG BLOCK SETUP MOXA
            if (pingTest.testaMXLNBS())
                picLNBS_mx.Image = imageList1.Images[0];
            else
                picLNBS_mx.Image = imageList1.Images[1];

            //LONG BLOCK LEAK TEST PC
            if (pingTest.testaPCLNBL())
                picLNBL_pc.Image = imageList1.Images[0];
            else
                picLNBL_pc.Image = imageList1.Images[1];

            //LONG BLOCK LEAK TEST MOXA
            if (pingTest.testaMXLNBL())
                picLNBL_mx.Image = imageList1.Images[0];
            else
                picLNBL_mx.Image = imageList1.Images[1];

            //LONG BLOCK COLD TEST PC
            if (pingTest.testaPCLNBC())
                picLNBC_pc.Image = imageList1.Images[0];
            else
                picLNBC_pc.Image = imageList1.Images[1];

            //LONG BLOCK COLD TEST MOXA
            if (pingTest.testaMXLNBC())
                picLNBC_mx.Image = imageList1.Images[0];
            else
                picLNBC_mx.Image = imageList1.Images[1];

            //LONG BLOCK RELEASE PC
            if (pingTest.testaPCLNBR())
                picLNBR_pc.Image = imageList1.Images[0];
            else
                picLNBR_pc.Image = imageList1.Images[1];

            //LONG BLOCK RELEASE MOXA
            if (pingTest.testaMXLNBR())
                picLNBR_mx.Image = imageList1.Images[0];
            else
                picLNBR_mx.Image = imageList1.Images[1];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void lblLNBR_Click(object sender, EventArgs e)
        {
        }

        private void picCYH_pc_Click(object sender, EventArgs e)
        {
        }

        //private Image GetImageIndex(int num)
        //{
        //    return imageList1.Images[num];
        //}
    }
}
