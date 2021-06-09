using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //use try-catch to avoid input errors
            try
            {
                //read values for force and angle from textboxes
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                //calculate of area and volume
                double area = 2.0 * ((length = width) + (length = height) + (width * height));
                double volume = length * width * height;
                // put volumes in labels
                label1.Text = "Surface area = " + area;
                label2.Text = "Volume = " + volume;
            }
            catch
            {
                // show error message on screen if fail
                MessageBox.Show("Error! Error!! Error!!!");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads what text is in the force and angle textboxes
                double Height = double.Parse(textBox2.Text);
                //
                double Volume = Height * Height * Height;
                double SurfaceArea = 2 * (Height * Height + Height * Height + Height * Height);
                //
                label4.Text = "Volume = " + Volume;
                label5.Text = "Surface Area =" + SurfaceArea;
            }
            catch
            {
                MessageBox.Show("your numbers are very wrong, check again");

            }


        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {




            try
            {
                double CylinderRadius = double.Parse(textBox8.Text);
                double CylinderHeight = double.Parse(textBox9.Text);
                double CylinderSurfaceArea = 2 * Math.PI * CylinderRadius * CylinderHeight + 2 * Math.PI * (CylinderRadius * CylinderRadius);
                double CylinderVolume = Math.PI * (CylinderRadius * CylinderRadius) * CylinderHeight;
                label5.Text = "Surface Area =" + CylinderSurfaceArea;
                label6.Text = "Volume =" + CylinderVolume;



            }
            catch
            {

            }
    }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                double CylinderRadius = double.Parse(textBox8.Text);
                double CylinderHeight = double.Parse(textBox9.Text);
                double CylinderSurfaceArea = 2 * Math.PI * CylinderRadius * CylinderHeight + 2 * Math.PI * (CylinderRadius * CylinderRadius);
                double CylinderVolume = Math.PI * (CylinderRadius * CylinderRadius) * CylinderHeight;
                label5.Text = "Surface Area =" + CylinderSurfaceArea;
                label6.Text = "Volume =" + CylinderVolume;



            }
            catch
            {

            }
        }
    }
}