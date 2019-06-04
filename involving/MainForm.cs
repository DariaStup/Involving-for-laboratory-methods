/*
 * Created by SharpDevelop.
 * User: stupnikova
 * Date: 28.05.2019
 * Time: 8:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace involving
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double [] values = new double[16];
			values[0]=Double.Parse(textBox1.Text);//подумать потом как сделать циклом
			values[1]=Double.Parse(textBox2.Text);
			values[2]=Double.Parse(textBox3.Text);
			values[3]=Double.Parse(textBox4.Text);
			values[4]=Double.Parse(textBox5.Text);
			values[5]=Double.Parse(textBox6.Text);
			values[6]=Double.Parse(textBox7.Text);
			values[7]=Double.Parse(textBox8.Text);
			values[8]=Double.Parse(textBox9.Text);
			values[9]=Double.Parse(textBox10.Text);
			values[10]=Double.Parse(textBox11.Text);
			values[11]=Double.Parse(textBox12.Text);
			values[12]=Double.Parse(textBox13.Text);
			values[13]=Double.Parse(textBox14.Text);
			values[14]=Double.Parse(textBox15.Text);
			values[15]=Double.Parse(textBox16.Text);
			double average = 0; double summy = 0; double stdev = 0; double n = 0;
			int accuracy, reproducibility, count;
			double repeatability, newrepeatability, newreproducibility;
			
			count= Convert.ToInt32(textBox20.Text);
			accuracy = Convert.ToInt32(textBox19.Text);
			repeatability = Convert.ToInt32(textBox17.Text);
			reproducibility = Convert.ToInt32(textBox18.Text);
			foreach (double i in values)
			{
				average+=i;
			}
			average=Math.Round((average/values.Length),count);
			label17.Text=Convert.ToString(average);
			
			for (int i = 0; i< values.Length; i++)//расчет СКО для массива значений
			{
				values[i]=Math.Pow((values[i]-average),2);
			}
			foreach (double i in values)
			{
				summy+=i;
			}
			stdev = Math.Round(Math.Sqrt(summy/(values.Length-1)),count);
			label20.Text=Convert.ToString(stdev);//вывод на экран СКО
			
			repeatability = Math.Round((1.29 * 0.01* average * repeatability), count);
			label22.Text=Convert.ToString(repeatability);
			
			newrepeatability = Math.Round(((stdev/average)*100), count);
			label24.Text=Convert.ToString(newrepeatability);

            newreproducibility = Math.Sqrt(Math.Pow(reproducibility,2) - ((Math.Pow(Convert.ToDouble(textBox17.Text),2)) / 2) + Math.Pow(Convert.ToDouble(textBox17.Text), 2));

            n = Math.Round(Math.Pow((newrepeatability / (0.2 * newreproducibility)), 2), count);
            label30.Text = Convert.ToString(n);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }
        
        private void TextBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        double sum = 0; double avsum = 0;
        List<Double> disvalues = new List<Double>();
        //List<Double> sqdisvalues = new List<Double>();

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.textBox21.Text != "")
            {
                disvalues.Add(Convert.ToDouble(textBox21.Text));
                listBox1.Items.Add(this.textBox21.Text);
                this.textBox21.Focus();
                this.textBox21.Clear();
            }
            else
            {
                MessageBox.Show("Please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox21.Focus();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(textBox20.Text);
            double so, displacement, sd, sr, sdt, stdev;
            double summy = 0;
            foreach (double d in disvalues)
            {
                sum += d;
                avsum = Math.Round((sum / disvalues.Count),count);                
            }            
            so = Convert.ToDouble(textBox22.Text);
            displacement = Math.Round(Math.Abs(avsum - so),count);//расчет лабораторного смещения
            label36.Text = Convert.ToString(displacement);//если другой массив использовать для расчета, то значения не будут пересчитываться при нажатии
            label32.Text = Convert.ToString(avsum);
            for (int i = 0; i < disvalues.Count; i++)//расчет СКО для массива значений смещения
            {
                disvalues[i] = Math.Pow((disvalues[i] - avsum), 2);
            }
            foreach (double i in disvalues)
            {
                summy += i;
            }
            stdev = Math.Round(Math.Sqrt(summy / (disvalues.Count - 1)), count);
            label38.Text = Convert.ToString(stdev);//вывод на экран СКО

            sdt = Convert.ToInt32(textBox19.Text) / 1.96 * 0.01 * Convert.ToDouble(textBox22.Text);
            sr = Convert.ToInt32(textBox17.Text) * 0.01 * 0.1;
            label42.Text = Convert.ToString(sr);//sr

            sd = Math.Round(Math.Sqrt(Math.Pow(sdt, 2) - (Math.Pow(sr, 2) / 2) + (Math.Pow(stdev, 2) / disvalues.Count)),count);            
            label40.Text = Convert.ToString(sd);//sd

            if (displacement <= 2*sd)
                {
                label43.Text = Convert.ToString(displacement)+"<="+2*sd+"  Лабораторное смещение соответствует НД на методику";
                }
            else
            {
                label43.Text = Convert.ToString(displacement) + ">" + 2 * sd + "  Лабораторное смещение не соответствует НД на методику!";
                label43.ForeColor = Color.Red;
            }
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label32.Visible = true;
                label33.Visible = true;
                label34.Visible = true;
                label35.Visible = true;
                label36.Visible = true;
                label37.Visible = true;
                label38.Visible = true;
                label39.Visible = true;
                label40.Visible = true;
                label41.Visible = true;
                label42.Visible = true;
                label43.Visible = true;
                textBox22.Visible = true;
                button3.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label36.Visible = false;
                label37.Visible = false;
                label38.Visible = false;
                label39.Visible = false;
                label40.Visible = false;
                label41.Visible = false;
                label42.Visible = false;
                label43.Visible = false;
                textBox22.Visible = false;
                button3.Visible = false;
            }
        }

    }
}
