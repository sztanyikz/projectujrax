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
        string userr;
        Model model;
        public Form2(string user, Model mod)
        {
            model = mod;
            userr = user;

            InitializeComponent();
            texts();


            button1.Click += (s, e) =>
            {
                //boxx.Show();
            };
            button2.Click += (s, e) =>
            {
                model.clear();
                Application.Exit();
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
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
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
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
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
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton1.CheckedChanged += (s, e) =>
            {
                textBox3.Text = "0";
                numericUpDown1.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton2.CheckedChanged += (s, e) =>
            {
                textBox3.Text = "0";
                numericUpDown1.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton3.CheckedChanged += (s, e) =>
            {
                textBox3.Text = "0";
                numericUpDown1.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton4.CheckedChanged += (s, e) =>
            {
                textBox5.Text = "0";
                numericUpDown2.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton5.CheckedChanged += (s, e) =>
            {
                textBox5.Text = "0";
                numericUpDown2.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton6.CheckedChanged += (s, e) =>
            {
                textBox5.Text = "0";
                numericUpDown2.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton7.CheckedChanged += (s, e) =>
            {
                textBox7.Text = "0";
                numericUpDown3.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();

            };
            radioButton8.CheckedChanged += (s, e) =>
            {
                textBox7.Text = "0";
                numericUpDown3.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };
            radioButton9.CheckedChanged += (s, e) =>
            {
                textBox7.Text = "0";
                numericUpDown3.Value = 0;
                textBox1.Text = (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text)).ToString();
            };


            button3.Click += (s, e) =>
             {
                 int a = 0;
                 int b = 0;
                 int c = 0;
                 if (radioButton1.Checked)
                 {
                     a = 28;

                 }
                 else if (radioButton2.Checked)
                 {
                     b = 32;
                 }
                 else if (radioButton3.Checked)
                 {
                     c = 45;
                 }
                 if (radioButton4.Checked)
                 {
                     a = 28;
                 }
                 else if (radioButton5.Checked)
                 {
                     b = 32;
                 }
                 else if (radioButton6.Checked)
                 {
                     c = 45;
                 }
                 if (radioButton7.Checked)
                 {
                     a = 28;
                 }
                 else if (radioButton8.Checked)
                 {
                     b = 32;
                 }
                 else if (radioButton9.Checked)
                 {
                     c = 45;
                 }
                 //adatbázisba elmentés
                 model.save(user, Convert.ToString(label2), Convert.ToString(label3), Convert.ToString(label4), a, b, c, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(textBox1.Text));
                 //model függvény, hogy az utolsó hozzá adott elemnek mi az id-ja meg a többi adata

                 listBox1.Items.Add(model.lastorderid().Id + " " + "rendelés" + " " + model.lastorderid().Summa + " " + "FT");
                 textBox8.Text = model.sumsum().ToString();
             };
            listBox1.SelectedIndexChanged += (s, e) =>
            {
                if (listBox1.SelectedItem == null)
                {
                  
                }
                else 
                {

                    Order aa = model.vmi(Convert.ToInt32(listBox1.SelectedItem.ToString().Split(" ")[0]));
                    textBox9.Text = aa.Id.ToString();
                    Order aaa = model.vmi2(Convert.ToInt32(listBox1.SelectedItem.ToString().Split(" ")[2]));
                    textBox10.Text = aa.Summa.ToString();
                }
            };


            button4.Click += (s, e) =>
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                textBox3.Text = "0";
                numericUpDown1.Value = 0;
                textBox5.Text = "0";
                numericUpDown2.Value = 0;
                textBox7.Text = "0";
                numericUpDown3.Value = 0;
            };
            button6.Click += (s, e) =>
            {
                if (listBox1.SelectedItem.ToString() != "")
                {
                    model.delete(Convert.ToInt32(listBox1.SelectedItem.ToString().Split(" ")[0]));
                    int index = listBox1.SelectedIndex;
                    listBox1.SelectedIndex = -1;
                    listBox1.Items.RemoveAt(index);
                }
            };



        }
        public void texts()
        {
            textBox3.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";

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
            button6.Text = "Töröl";
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
