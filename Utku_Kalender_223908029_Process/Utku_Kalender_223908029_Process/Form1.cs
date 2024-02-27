using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utku_Kalender_223908029_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class kuyruk_1
        {
            public string deger;
            public kuyruk_1 baglanti;
        }
        kuyruk_1 k1_ilk;
        kuyruk_1 k1_son;
        public class kuyruk_2
        {
            public string deger;
            public kuyruk_2 baglanti;
        }
        kuyruk_2 k2_ilk;
        kuyruk_2 k2_son;

        public class kuyruk_3
        {
            public string deger;
            public kuyruk_3 baglanti;
        }
        kuyruk_3 k3_ilk;
        kuyruk_3 k3_son;

        public class s_Dugum
        {
            public string deger;
            public s_Dugum baglanti;
        }
        s_Dugum s_ilk;
        s_Dugum s_son;

        public class a_Kuyruk
        {
            public string deger;
            public a_Kuyruk baglanti;
        }
        a_Kuyruk a_ilk;
        a_Kuyruk a_son;
        public class yigin
        {
            public string deger;
            public yigin baglanti;
        }
        yigin y_ilk;


        private void islemci_Tick(object sender, EventArgs e)
        {
            yigina_Ekle();
        }
        public void yigina_Ekle()
        {
            string deger = kuyruktan_Cikar();
            yigin yeni = new yigin();
            if (deger != null)
            {
                yeni.deger = deger;
                if (y_ilk == null)
                {
                    y_ilk = yeni;
                }
                else
                {
                    yeni.baglanti = y_ilk;
                    y_ilk = yeni;
                }
            }
        }
        public string kuyruktan_Cikar()
        {
            string deger = null;
            if (s_ilk != null)
            {
                deger = s_ilk.deger;
                s_ilk = s_ilk.baglanti;
            }
            else
            {
                textBox1.Text = null;
            }
            a_Kuyruk_Ekle();
            return deger;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string deger3 = "P3-" + rnd.Next(0, 6).ToString();
            textBox4.Text += deger3 + Environment.NewLine;
            kuyruk3Ekle(deger3);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string deger2 = "P2-" + rnd.Next(0, 6).ToString();
            textBox3.Text += deger2 + Environment.NewLine;
            kuyruk2Ekle(deger2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string deger1 = "P1-" + rnd.Next(0, 6).ToString();
            textBox2.Text += deger1 + Environment.NewLine;
            kuyruk1Ekle(deger1);

        }
        public void kuyruk1Ekle(string deger)
        {
            kuyruk_1 yeni = new kuyruk_1();
            yeni.deger = deger;
            if (k1_ilk == null)
            {
                k1_ilk = yeni;
                k1_son = yeni;
            }
            else
            {
                k1_son.baglanti = yeni;
                k1_son = yeni;
            }

            deger = kuyruk1Cikar();

            siraliEkle(deger);
        }
        public string kuyruk1Cikar()
        {
            string deger = null;
            if (k1_ilk != null)
            {
                deger = k1_ilk.deger;
                k1_ilk = k1_ilk.baglanti;
            }
            return deger;
        }
        public void kuyruk2Ekle(string deger)
        {
            kuyruk_2 yeni = new kuyruk_2();
            yeni.deger = deger;
            if (k2_ilk == null)
            {
                k2_ilk = yeni;
                k2_son = yeni;
            }
            else
            {
                k2_son.baglanti = yeni;
                k2_son = yeni;
            }

            deger = kuyruk2Cikar();

            siraliEkle(deger);

        }
        public string kuyruk2Cikar()
        {
            string deger = null;
            if (k2_ilk != null)
            {
                deger = k2_ilk.deger;
                k2_ilk = k2_ilk.baglanti;
            }
            return deger;
        }
        public void kuyruk3Ekle(string deger)
        {
            kuyruk_3 yeni = new kuyruk_3();
            yeni.deger = deger;
            if (k3_ilk == null)
            {
                k3_ilk = yeni;
                k3_son = yeni;
            }
            else
            {
                k3_son.baglanti = yeni;
                k3_son = yeni;
            }

            deger = kuyruk3Cikar();

            siraliEkle(deger);

        }
        public string kuyruk3Cikar()
        {
            string deger = null;
            if (k3_ilk != null)
            {
                deger = k3_ilk.deger;
                k3_ilk = k3_ilk.baglanti;
            }
            return deger;
        }
        public void siraliEkle(string deger)
        {
            s_Dugum yeni = new s_Dugum();
            yeni.deger = deger;
            if (s_ilk == null)
            {
                s_ilk = yeni;
                s_son = yeni;
            }
            else
            {
                char[] eklenecek = deger.ToCharArray();
                s_Dugum isaretci = s_ilk;
                s_Dugum onceki = null;
                Boolean durum = true;
                while (isaretci != null)
                {
                    char[] kontrol = isaretci.deger.ToCharArray();
                    if (eklenecek[3] > kontrol[3])
                    {
                        if (isaretci == s_ilk)
                        {
                            yeni.baglanti = s_ilk;
                            s_ilk = yeni;
                        }
                        else
                        {
                            onceki.baglanti = yeni;
                            yeni.baglanti = isaretci;
                        }
                        durum = false;
                        break;
                    }
                    if (eklenecek[3] == kontrol[3] && isaretci != s_son)
                    {
                        yeni.baglanti = isaretci.baglanti;
                        isaretci.baglanti = yeni;
                        durum = false;
                        break;
                    }
                    onceki = isaretci;
                    isaretci = isaretci.baglanti;
                }
                if (durum)
                {
                    s_son.baglanti = yeni;
                    s_son = yeni;
                }
            }
            a_Kuyruk_Ekle();
        }
        public void a_Kuyruk_Ekle()
        {
            a_ilk = null;
            a_son = null;
            s_Dugum isaretci = s_ilk;
            while (isaretci != null)
            {
                a_Kuyruk yeni = new a_Kuyruk();
                yeni.deger = isaretci.deger;
                if (a_ilk == null)
                {
                    a_ilk = yeni;
                    a_son = yeni;
                }
                else
                {
                    a_son.baglanti = yeni;
                    a_son = yeni;
                }
                isaretci = isaretci.baglanti;
            }

            a_Kuyruk_Goster();
        }
        public void a_Kuyruk_Goster()
        {
            textBox1.Text = null;
            a_Kuyruk isaretci = a_ilk;
            while (isaretci != null)
            {
                textBox1.Text += isaretci.deger + "-->";
                isaretci = isaretci.baglanti;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            islemci.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            islemci.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yiginGoster();

        }
        public void yiginGoster()
        {
            textBox5.Text = null;
            yigin isaretci = y_ilk;
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                while (isaretci != null)
                {
                    textBox5.Text += isaretci.deger + Environment.NewLine;
                    isaretci = isaretci.baglanti;
                }
            }
            else if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                isaretci = y_ilk;
                while (isaretci != null)
                {
                    char[] kontrol = isaretci.deger.ToCharArray();
                    if (checkBox1.Checked)
                    {
                        if (kontrol[1] == '1')
                        {
                            textBox5.Text += isaretci.deger + Environment.NewLine;
                        }
                    }
                    if (checkBox2.Checked)
                    {
                        if (kontrol[1] == '2')
                        {
                            textBox5.Text += isaretci.deger + Environment.NewLine;
                        }
                    }
                    if (checkBox3.Checked)
                    {
                        if (kontrol[1] == '3')
                        {
                            textBox5.Text += isaretci.deger + Environment.NewLine;
                        }
                    }
                    isaretci = isaretci.baglanti;
                }
            }
            else
            {
                textBox5.Text = "İstediğiniz prosesleri seçiniz!!";
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int hiz = islemciBar.Value;
            islemci.Interval = 2000 - (hiz * 300);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int hiz = proses1Bar.Value;
            timer1.Interval = 3000 - (hiz * 300);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int hiz = proses2Bar.Value;
            timer2.Interval = 3010 - (hiz * 300);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            int hiz = proses3Bar.Value;
            timer3.Interval = 3020 - (hiz * 300);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
