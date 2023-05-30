using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Калькулятор
{
    public partial class Form1 : Form
    {
        bool pol;
        public Form1()
        {
            InitializeComponent();
        }
        private void man_click(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.WhiteSmoke;
            pol = false;
            button1.Enabled = true;
        }

        private void woman_click(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.Gainsboro;
            pol = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weights = Convert.ToDouble(weight.Text);
            double Heights = Convert.ToDouble(height.Text);
            Heights = Heights / 100;
            double BMI = Math.Round(Weights / (Heights * Heights),1);
            if (BMI > 60) BMI = 60;
            if (BMI < 1) BMI = 1;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            trackBar1.Visible = true;
            if (BMI < 18.5)
            {
                if (pol) {
                    picture.Image = Properties.Resources.female_icon;
                }
                else
                {
                    picture.Image = Properties.Resources.bmi_underweight_icon;
                }
                BMItext.Text = "Недостаточный вес";
                trackBar1.Value = Convert.ToInt32(BMI);
            }
            else if (BMI < 24.9)
            {
                if (pol)
                {
                    picture.Image = Properties.Resources.female_icon;
                }
                else
                {
                    picture.Image = Properties.Resources.bmi_healthy_icon;
                }
                BMItext.Text = "Здоровый";
                trackBar1.Value = Convert.ToInt32(BMI);
            }
            else if (BMI < 29.9)
            {
                if (pol)
                {
                    picture.Image = Properties.Resources.female_icon;
                }
                else
                {
                    picture.Image = Properties.Resources.bmi_overweight_icon;
                }
                BMItext.Text = "Избыточный вес";
                trackBar1.Value = Convert.ToInt32(BMI);
            }
            else if (BMI > 30)
            {
                if (pol)
                {
                    picture.Image = Properties.Resources.female_icon;
                }
                else
                {
                    picture.Image = Properties.Resources.bmi_obese_icon;
                }
                BMItext.Text = "Ожирение";
                trackBar1.Value = Convert.ToInt32(BMI);
            }
            bmmi.Text = Convert.ToInt32(BMI).ToString();
            bmmi.Size = picture.Size;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.None;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.WhiteSmoke;
            button1.Enabled = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            trackBar1.Visible = false;
            bmmi.Text = null;
            BMItext.Text = null;
            picture.Image = null;
            weight.Text = null;
            height.Text = null;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
