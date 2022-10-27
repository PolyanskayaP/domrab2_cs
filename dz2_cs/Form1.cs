using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vvod_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ot_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_do_TextChanged(object sender, EventArgs e)
        {

        }

        private void vivod_TextChanged(object sender, EventArgs e)
        {

        }

        private void algor(String data)
        {
            String str_ot = tb_ot.Text;
            String str_do = tb_do.Text;
            if (str_ot == "")
            {
                vivod.Text = "";
                MessageBox.Show(
                    "Вы ничего не ввели в поле с 1ой границей."
                    );
            }
            else
            if (str_ot.All(Char.IsDigit) == false && str_ot[0] != '-')
            {
                vivod.Text = "";
                MessageBox.Show(
                    "В поле с 1ой границей должны быть цифры."
                    );
            }
            else 
            if (str_ot.All(Char.IsDigit) || ((str_ot.Substring(1)).All(Char.IsDigit)) && str_ot[0] == '-') 
            {
                if (str_do == "")
                {
                    vivod.Text = "";
                    MessageBox.Show(
                        "Вы ничего не ввели в поле со 2ой границей."
                        );
                }
                else
                if (str_do.All(Char.IsDigit) == false && str_do[0] != '-')
                {
                    vivod.Text = "";
                    MessageBox.Show(
                        "В поле со 2ой границей должны быть цифры."
                        );
                }
                else
                {
                    String prov_ot = str_ot.Substring(1);
                    String prov_do = str_do.Substring(1);

                    if (str_do.All(Char.IsDigit) || (prov_do.All(Char.IsDigit)) && str_do[0] == '-')  ///ev
                    {
                        int int_ot = int.Parse(str_ot);
                        int int_do = int.Parse(str_do);

                        List<string> subs = data.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                                                              .Select(s => s.Trim()).ToList();
                        int dlina = subs.Count;
                        if (int_ot > dlina)
                        {
                            vivod.Text = "";
                            MessageBox.Show(
                                "Первая граница больше, чем количество слов в строке"
                                );
                        }
                        else
                        if (int_ot <= 0) 
                        {
                            vivod.Text = "";
                            MessageBox.Show(
                                "Первая граница меньше 1"
                                );
                        }
                        else
                        if (int_do <= 0)
                        {
                            vivod.Text = "";
                            MessageBox.Show(
                                "Вторая граница меньше 1"
                                );
                        }
                        else
                        if (int_do > dlina)
                        {
                            vivod.Text = "";
                            MessageBox.Show(
                                "Вторая граница больше, чем количество слов в строке"
                                );
                        }
                        else
                        if (int_ot > int_do)
                        {
                            vivod.Text = "";
                            MessageBox.Show(
                                "Первая граница больше, чем вторая"
                                );
                        }
                        else  //evv
                        {
                            int_ot--;
                            int_do--;
                            List<string> chast = new List<string>();
                            for (int i = int_ot; i <= int_do; i++)
                            {
                                chast.Add(subs[i]);
                            }
                            subs.RemoveRange(int_ot, int_do - int_ot + 1);
                            //int dlin_ost = subs.Count;
                            String result = "";
                            foreach (string s in chast)
                            {
                                result = result + " " + s;
                            }
                            foreach (string s in subs)
                            {
                                result = result + " " + s;
                            }
                            vivod.Text = result;
                        }
                        //vivod.Text = subs[0] + subs[2] + subs[1]; 
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String data = vvod.Text;
            //алгоритм с data
            algor(data);
        }
    }
}
