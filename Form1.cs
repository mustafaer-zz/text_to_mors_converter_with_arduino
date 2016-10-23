using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_to_mors_converter_with_arduino
{
    public partial class Form1 : Form
    {
        string[] alfabe = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "W", "X", "Q", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ",", ".", "?", " " };
        string[] mors = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "..", "---", ".--.", ".-.", "...", "-", "..-", "...-", "-.--", "--..", ".--", "-..-", "--.-", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "--..--", ".-.-.-", "..--..", " " };

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            try
            {

                string gelenmetin = rtxt_input.Text.ToUpper();

                if (gelenmetin == "")
                {
                    //doldur gel
                }
                else
                {
                    ///metin var
                    for (int i = 0; i < gelenmetin.Length; i++)
                    {
                        string gelenharf = gelenmetin[i].ToString();
                        int sira = Array.IndexOf(alfabe, gelenharf.ToString());
                        if (sira != -1)
                        {
                            rtxt_output.Text = rtxt_output.Text + mors[sira];
                        }
                        else
                        {
                            MessageBox.Show("hatalı karakter");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu ! " + ex.ToString());
            }
        }
    }
}
