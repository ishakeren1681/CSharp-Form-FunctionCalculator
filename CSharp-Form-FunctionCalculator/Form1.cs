using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Form_FunctionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Operatorler = "+-/*.^";
        double Ans;
        bool esittireBasildi;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Expression expression = new Expression("Pow(5, 3)+3");
            //double deger = Convert.ToDouble(expression.Evaluate());
            //MessageBox.Show(deger.ToString());
        }

        


        public void UsluIfadeVarmi(string ifade)
        {

            // Burada ne işlemi yaptık.. Expressionda üslü ifadeleri strin olaran "Pow(x,y)" şeklinde yazmalıyız.
            // İlk aşama olarak üslü operatör "^" var mı diye baktık. Eğer varsa bunun sağında ve solundad bir rakam olması lazım.
            // Bunu bilebilmemiz için operatörün indisini bilmemiz lazım.
            // indisini bulduktan sonra 1 solunda yani (indis-1) birde sağında yani (indis+1)'de bulunan ifadeleri alıp pow içerisinde uygun formatta yazdırdık.
            // While döndürmemizin sebebi ise birden fazla üslü ifade bulunabilir.


            char arananKarakter = '^';

            int sayac = ifade.Count(x => x == arananKarakter);

            while (sayac != 0)
            {
                int index = ifade.IndexOf('^');
                if (index != -1)
                {
                    char oncekiKarakter = ifade[index - 1];
                    char sonrakiKarakter = ifade[index + 1];
                    string eskiDeger = oncekiKarakter + "^" + sonrakiKarakter;
                    string yeniDeger = "Pow(" + oncekiKarakter + "," + sonrakiKarakter + ")";
                    ifade = ifade.Replace(eskiDeger, yeniDeger);
                }
                sayac--;
            }


            txtSonuc.Text = ifade;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {




            txtSonuc.Text = txtSonuc.Text
                .Replace("Ans", Ans.ToString())
                .Replace("e", "2.71")
                .Replace("π", "3.14")
                .Replace("%", "/100")
                .Replace(",", ".");

            UsluIfadeVarmi(txtSonuc.Text);



            //üs alma
            //Expression expression = new Expression("(2 + 3) * 4+(5*2)");
            Expression expression = new Expression(txtSonuc.Text);

            double deger = Convert.ToDouble(expression.Evaluate());

            if (deger is double)
            {
                txtSonuc.Text = deger.ToString();

                esittireBasildi = true;
                Ans = deger;
                txtAns.Text = "Ans = " + deger.ToString();

                // Eşittire basıldığında silme butonu AC'ye dönüşsün.
                btnAllClear.Text = "AC";
            }

        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // Clear tuşuna basıldığında silme butonu içindeki yazı 'AC' ise içerisi sonuç 0'lansın.

            //Aksi halde buton zaten 'CE' Clear Entry harfini barındırdığı için geriye son harfi siler.

            if (btnAllClear.Text == "AC")
            {
                txtSonuc.Text = "0";
            }
            else
            {
                txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1, 1);

                if (txtSonuc.Text.Count() == 0)
                {
                    txtSonuc.Text = "0";
                }
            }
        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {
            // Burada yapılan işlem: txtSonuca bir harf değer yazıldığında silme butonunu 'CE' harfine çevirir.
            if (txtSonuc.Text.Length != 0)
            {
                btnAllClear.Text = "CE";
            }
            else
            {
                btnAllClear.Text = "AC";
            }


            // Burada yapılan işlem: txtSonuca e harfi eklendiğinde iki adet e harfinin yanyana gelmesi durumunda bunları çarpım durumunda yazdırır.
        }

        private void btnCosinusAl_Click(object sender, EventArgs e)
        {
            btnEqual.PerformClick();
            double deger = double.Parse(txtSonuc.Text);


            txtSonuc.Text = Math.Cos(deger).ToString();
            txtAns.Text = txtSonuc.Text;
        }

        private void btnSinusAl_Click(object sender, EventArgs e)
        {
            btnEqual.PerformClick();

            double deger = double.Parse(txtSonuc.Text);


            txtSonuc.Text = Math.Sin(deger).ToString();
            txtAns.Text = txtSonuc.Text;
        }

        private void btnTanAl_Click(object sender, EventArgs e)
        {
            btnEqual.PerformClick();

            double deger = double.Parse(txtSonuc.Text);


            txtSonuc.Text = Math.Tan(deger).ToString();
            txtAns.Text = txtSonuc.Text;
        }

        private void btnFaktoriyelAl_Click(object sender, EventArgs e)
        {
            btnEqual.PerformClick();

            double deger = double.Parse(txtSonuc.Text);

            double carpim = 1;
            for (int i = 1; i <= deger; i++)
            {
                carpim *= i;
            }

            txtSonuc.Text = (carpim).ToString();
            txtAns.Text = txtSonuc.Text;
        }

        private void btnKarekok_Click(object sender, EventArgs e)
        {
            // Bu fonksiyon = tuşuna basmışız gibi davranır ve = eklendiği buton için o butona ait fonksiyonun click methodunu tamamlar..
            btnEqual.PerformClick();

            double deger = double.Parse(txtSonuc.Text);

            txtSonuc.Text = Math.Sqrt(deger).ToString();
            txtAns.Text = txtSonuc.Text;
        }

        private void btnKareAl_Click(object sender, EventArgs e)
        {
            // Bu fonksiyon = tuşuna basmışız gibi davranır ve = eklendiği buton için o butona ait fonksiyonun click methodunu tamamlar..
            btnEqual.PerformClick();

            double deger = double.Parse(txtSonuc.Text);

            txtSonuc.Text = (deger * deger).ToString();
            txtAns.Text = txtSonuc.Text;
        }

        private void Rakamlar(object sender, EventArgs e)
        {
            string basilanTus = ((Button)sender).Text;

            if (basilanTus == "xʸ")
            {
                basilanTus = "^";
            }

            if (basilanTus == "cos")
            {
                basilanTus = "^";
            }



            if (esittireBasildi == true && !Operatorler.Contains(basilanTus))
            {
                txtSonuc.Text = basilanTus;
            }
            else if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = basilanTus;
            }
            else if (txtSonuc.Text.Length > 0)
            {
                string sonHarf = txtSonuc.Text[txtSonuc.Text.Length - 1].ToString();


                if (basilanTus == "e" && sonHarf != "e")
                {
                    txtSonuc.Text += "*" + basilanTus;
                }
                else if (basilanTus == "e" && sonHarf == "e")
                {
                    txtSonuc.Text += "*" + basilanTus;
                }
                else if (basilanTus == "π" && !Operatorler.Contains(sonHarf))
                {
                    txtSonuc.Text += "*π";
                }
                else if (basilanTus == "π" && sonHarf == "π")
                {
                    txtSonuc.Text += "*π";
                }

                else if (Operatorler.Contains(sonHarf) && Operatorler.Contains(basilanTus))
                {

                    txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1, 1) + basilanTus;
                }
                else
                {

                    if (Operatorler.Contains(basilanTus))
                    {

                        txtSonuc.Text += basilanTus;
                    }
                    else
                    {

                        txtSonuc.Text += basilanTus;
                    }
                }
            }




            // Herhangi bir tuşa basıldığında silme butonu ce'ye dönüşsün.
            btnAllClear.Text = "CE";
            esittireBasildi = false;
        }

       
    }
}
