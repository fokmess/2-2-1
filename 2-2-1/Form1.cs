using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String line,line2;
            
            fileText.Text = "";
            try
            {
            StreamReader sr = new StreamReader("C:\\Users\\fokin\\source\\repos\\2-2-1\\2-2-1\\Files\\" + fileName.Text);

                line = sr.ReadLine();

                while (line != null)
                {


                    fileText.Text += line + Environment.NewLine;
                    ///
                    line = line.ToLower();
                    line2 = "";
                    char[] s = line.ToCharArray();
                    for (int i = 0; i < line.Length; i++)
                    {
                        switch (s[i])
                        {
                            case 'a':
                                line2 += "1";
                                break;
                            case 'e':
                                line2 += "5";
                                break;
                            case 'i':
                                line2 += "9";
                                break;
                            case 'o':
                                line2 += "15";
                                break;
                            case 'u':
                                line2 += "21";
                                break;
                            case 'y':
                                line2 += "25";
                                break;
                            default:
                                line2 += s[i];
                                break;
                        }

                    }
                    fileText2.Text += line2 + Environment.NewLine;
                    ///
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка чтения из файла");
            }
        }
    }
}
