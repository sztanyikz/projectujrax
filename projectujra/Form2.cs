using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectujra
{
    public partial class Form2 : Form
    {
        //AboutBox1 boxx = new AboutBox1();
        public Form2()
        {

            
            InitializeComponent();
            texts();
            

            button1.Click += (s, e) =>
            {
                //boxx.Show();
            };
            button2.Click += (s, e) =>
            {
                this.Close();
            };
            numericUpDown1.ValueChanged += (s, e) =>
            {
                if (radioButton1.Checked)
                {
                    int price = 620 * Convert.ToInt32(numericUpDown1.Value);
                    textBox3.Text = price.ToString();
                }
                else if (radioButton2.Checked)
                {
                   
                    int price = 750 * Convert.ToInt32(numericUpDown1.Value);
                    textBox3.Text = price.ToString();
                }
                else if (radioButton3.Checked)
                {
                    
                    int price = 990 * Convert.ToInt32(numericUpDown1.Value);
                    textBox3.Text = price.ToString();
                }
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            numericUpDown2.ValueChanged += (s, e) =>
            {
                if (radioButton4.Checked)
                {
                    int price = 650 * Convert.ToInt32(numericUpDown2.Value);
                    textBox5.Text = price.ToString();
                }
                else if (radioButton5.Checked)
                {

                    int price = 760 * Convert.ToInt32(numericUpDown2.Value);
                    textBox5.Text = price.ToString();
                }
                else if (radioButton6.Checked)
                {

                    int price = 1200 * Convert.ToInt32(numericUpDown2.Value);
                    textBox5.Text = price.ToString();
                }
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            numericUpDown3.ValueChanged += (s, e) =>
            {
                if (radioButton7.Checked)
                {
                    int price = 710 * Convert.ToInt32(numericUpDown3.Value);
                    textBox7.Text = price.ToString();
                }
                else if (radioButton5.Checked)
                {

                    int price = 880 * Convert.ToInt32(numericUpDown3.Value);
                    textBox7.Text = price.ToString();
                }
                else if (radioButton6.Checked)
                {

                    int price = 1250 * Convert.ToInt32(numericUpDown3.Value);
                    textBox7.Text = price.ToString();
                }
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton1.CheckedChanged += (s, e) =>
            {
                textBox3.Text = "";
                numericUpDown1.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton2.CheckedChanged += (s, e) =>
            {
                textBox3.Text = "";
                numericUpDown1.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton3.CheckedChanged += (s, e) =>
            {
                textBox3.Text = "";
                numericUpDown1.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton4.CheckedChanged += (s, e) =>
            {
                textBox5.Text = "";
                numericUpDown2.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton5.CheckedChanged += (s, e) =>
            {
                textBox5.Text = "";
                numericUpDown2.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton6.CheckedChanged += (s, e) =>
            {
                textBox5.Text = "";
                numericUpDown2.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton7.CheckedChanged += (s, e) =>
            {
                textBox7.Text = "";
                numericUpDown3.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();

            };
            radioButton8.CheckedChanged += (s, e) =>
            {
                textBox7.Text = "";
                numericUpDown3.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };
            radioButton9.CheckedChanged += (s, e) =>
            {
                textBox7.Text = "";
                numericUpDown3.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7)).ToString();
            };




        }
        public void texts()
        {
            groupBox1.Text = "";
            groupBox2.Text = "";
            groupBox3.Text = "";
            groupBox4.Text = "";
            groupBox5.Text = "";
            groupBox6.Text = "";
            groupBox7.Text = "";
            groupBox8.Text = "";
            groupBox9.Text = "";
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            DateTime currentDateTime = DateTime.Now;
            textBox11.Text = Convert.ToString(currentDateTime);
            textBox2.BackColor = Color.FromArgb(255, 192, 128);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
            textBox4.BackColor = Color.FromArgb(255, 192, 128);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font(textBox4.Font, FontStyle.Bold);
            textBox6.BackColor = Color.FromArgb(255, 192, 128);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font(textBox4.Font, FontStyle.Bold);
            button5.BackColor = Color.FromArgb(255, 192, 128);
            groupBox4.BackColor = Color.FromArgb(255, 192, 128);
            groupBox5.BackColor = Color.FromArgb(255, 224, 192);
            groupBox6.BackColor = Color.FromArgb(255, 224, 192);
            groupBox7.BackColor = Color.FromArgb(255, 224, 192);
            this.BackColor = Color.FromArgb(192, 64, 0);
            tabPage1.BackColor = Color.FromArgb(255, 192, 128);
            tabPage2.BackColor = Color.FromArgb(255, 192, 128);
           // groupBox8.BackgroundImage = System.Drawing.Image.FromFile("pizza.jpeg");
            groupBox8.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Text = "Pizzák";
            tabPage2.Text = "Rendelések";
            button1.Text = "Névjegy";
            button2.Text = "Kilépés";
            label2.Text = "Vezuvo";
            textBox2.Text = "Paprika,paradicsom, sajt, sonka";
            textBox2.Enabled = false;
            radioButton1.Text = "28cm";
            radioButton2.Text = "32cm";
            radioButton3.Text = "45cm";
            label5.Text = "620 Ft";
            label6.Text = "750 Ft";
            label7.Text = "990 Ft";
            /*numericupdown1
             * textbox3*/
            textBox3.Enabled = false;
            label3.Text = "Magyaros";
            textBox4.Text = "Paprika, sajt, szalámi, chili";
            textBox4.Enabled = false;
            radioButton4.Text = "28 cm";
            radioButton5.Text = "32cm";
            radioButton6.Text = "45cm";
            label8.Text = "650 Ft";
            label9.Text = "760 Ft";
            label10.Text = "1200 Ft";
            /*numericupdown2
             * textbox5*/
            textBox5.Enabled = false;
            label4.Text = "Hawaii";
            textBox6.Text = "Ananász,sonka,sajt";
            textBox6.Enabled = false;
            radioButton7.Text = "28 cm";
            radioButton8.Text = "32cm";
            radioButton9.Text = "45cm";
            label11.Text = "710 Ft";
            label12.Text = "880 Ft";
            label13.Text = "1250 Ft";
            /*numericupdown3
             * textbox7*/
            textBox7.Enabled = false;

            button3.Text = "Rendel";
            button4.Text = "Mégsem";
            label1.Text = "Összesen";
            /*textbox1 */


            button5.Text = "Bevétel:";
            label14.Text = "Azonosító";
            label15.Text = "Összeg";
            label16.Text = "Dátum";
            button6.Text = "Rendelést elment";
            /*textbox8
             * textbox9
             textbox10
            textbox11*/




            textBox1.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;

        }
    }
}
