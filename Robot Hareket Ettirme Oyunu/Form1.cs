using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string komut_201104078; 
        string Yonler_201104078;
        int AlanBoyut_201104078, xEksen_201104078, yEksen_201104078;
        int M_harfi_sayisi_201104078 = 0;
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            komut_201104078 = textBox4.Text; // textboxtan alan boyutunu alup en genelde tanımladığım string ifadeye atadım 
            int KomutUzaklık_201104078 = komut_201104078.Length; //atamış olduğum string ifadenin uzunluğunu aldım 
            char[] karakterler = komut_201104078.ToCharArray(); // almış olduğum string ifadenin char olarak diziye atadım
            foreach (char karakter in karakterler) // foreach kullandım çünkü o string ifadeyi içinden kaç tane M harfi olduğunu çekmem gerekiyordu en kolay yolda diziden rahatça ulaşbilmekti
            {
                if (karakter == 'M')
                {
                    M_harfi_sayisi_201104078++;

                }
            }
            for (int j = 0; j < M_harfi_sayisi_201104078; j++) // oluşturduğum algoritmada for döngüsüne sokarak m harfine kadar dönmesini sağladım 
            {
                for (int i = 0; i < KomutUzaklık_201104078; i++)
                {
                    if (Yonler_201104078 == "Kuzey")// verilen komutun ilk önce girilmesi gereken if değeri için her bir yön için başlangıç if oluşturdum 
                    {
                        if (komut_201104078[i] == 'L') // kağıt üzerinde uzun uğraşlar sonra matematiksel olarak her yöne girdikten sonra o yönün işlevinin vereilen left right konutları için X ve Y için hareketlerini inceledim ve kod kısmına aktardım
                            Yonler_201104078 = "Batı";// örneğin kuzey komutunda verilen yön left ise yönü batı oluyor ardından move komutu bu işlem sonrası Y ekseni atışa geçiyor
                        else if (komut_201104078[i] == 'R')
                            Yonler_201104078 = "Doğu";
                        else if (komut_201104078[i] == 'M')
                        {
                            j++; // bu arttırım üstteki for döngüsü içerisinde hareket sırası kadar arttırım yapmakta
                            yEksen_201104078++; // y eksenini arttırıyor
                            string[] RW = { j.ToString(), xEksen_201104078.ToString(), yEksen_201104078.ToString() };// listview hareket adımları ve x , y konumunu yazdrıdım 
                            var satir1 = new ListViewItem(RW);
                            listView1.Items.Add(satir1);
                            label7.Text = xEksen_201104078.ToString() + "- " + yEksen_201104078.ToString() + "\n"; // son konumu x ve y nin
                        }
                    }
                    else if (Yonler_201104078 == "Güney") // diğer bir else if ifadeside verilen komutta eğer iç if güney olursa bura girip hx ve y nin hareket durumu için incelenmesini sağlıcak
                    {
                        if (komut_201104078[i] == 'L')
                            Yonler_201104078 = "Doğu";
                        else if (komut_201104078[i] == 'R')
                            Yonler_201104078 = "Batı";
                        else if (komut_201104078[i] == 'M')
                        {
                            j++;// bu arttırım üstteki for döngüsü içerisinde hareket sırası kadar arttırım yapmakta
                            yEksen_201104078--;// y eksenini azaltıyor
                            
                            string[] RW1 = { j.ToString(), xEksen_201104078.ToString(), yEksen_201104078.ToString() };// listview hareket adımları ve x , y konumunu yazdrıdım 
                            var satir2 = new ListViewItem(RW1);
                            listView1.Items.Add(satir2);
                            label7.Text = xEksen_201104078.ToString() + "- " + yEksen_201104078.ToString() + "\n";
                        }
                    }
                    else if (Yonler_201104078 == "Batı") // örneğin güney komutunu alır ve right komutu ardıdan gelirse yön else if batıya giricek ve move kontrolu ile x eksenini bir bir azaltcak 
                    {
                        if (komut_201104078[i] == 'L')
                            Yonler_201104078 = "Güney";
                        else if (komut_201104078[i] == 'R')
                            Yonler_201104078 = "Kuzey";
                        else if (komut_201104078[i] == 'M')
                        {
                            j++;// bu arttırım üstteki for döngüsü içerisinde hareket sırası kadar arttırım yapmakta
                            xEksen_201104078--; // x ekseni değerin azaltıyo
                           
                            string[] RW2 = { j.ToString(), xEksen_201104078.ToString(), yEksen_201104078.ToString() };// listview hareket adımları ve x , y konumunu yazdrıdım 
                            var satir3 = new ListViewItem(RW2);
                            listView1.Items.Add(satir3);
                            label7.Text += xEksen_201104078.ToString() + "- " + yEksen_201104078.ToString() + "\n";
                        }
                    }
                    else if (Yonler_201104078 == "Doğu")
                    {
                        if (komut_201104078[i] == 'L')
                            Yonler_201104078 = "Kuzey";
                        else if (komut_201104078[i] == 'R')
                            Yonler_201104078 = "Güney";
                        else if (komut_201104078[i] == 'M')
                        {
                            j++;// bu arttırım üstteki for döngüsü içerisinde hareket sırası kadar arttırım yapmakta
                            xEksen_201104078++; // x değerini arttırıyor
                            
                            string[] RW3 = { j.ToString(), xEksen_201104078.ToString(), yEksen_201104078.ToString() };// listview hareket adımları ve x , y konumunu yazdrıdım 
                            var satir4 = new ListViewItem(RW3);
                            listView1.Items.Add(satir4);
                            label7.Text = xEksen_201104078.ToString() + "- " + yEksen_201104078.ToString() + "\n"; // son konumu x ve y nin
                        }
                    }
                }
                

            }

        }

        private void button3_Click(object sender, EventArgs e) // bu kısım algoritma mantığını oluştırmama çok yardım etti ardından kağıt kısmına geçince az çok oluştu 
        {
            Graphics gr = panel2.CreateGraphics();
            Pen mypen = new Pen(Brushes.Black, 1);
            int LİNES = Convert.ToInt32(textBox5.Text);
            Font myfont = new Font("Arial", 10);
            float x = 0;
            float y = 0;
            float xspace = panel2.Width / LİNES;
            float yspace = panel2.Height / LİNES;
            // Dikey Çizgi
            for (int i = 0; i < LİNES + 1; i++)
            {
                gr.DrawLine(mypen, x, y, x, panel2.Height);
                x += xspace;
            }
            x = 0;
            // Yatay Çizgi
            for (int i = 0; i < LİNES + 1; i++)
            {
                gr.DrawLine(mypen, x, y, panel2.Width, y);
                y += yspace;
            }
            x = 0;
            y = 0;
            int counter = 1;
            for (int i = 0; i < LİNES; i++)
            {
                for (int j = 0; j < LİNES; j++)
                {
                    gr.DrawString(Convert.ToString(counter), myfont, Brushes.Black, x, y);
                    x += xspace;
                    counter++;
                }
                y += yspace;
                x = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] yönler = { "Kuzey", "Güney", "Doğu", "Batı" }; // combobox için bir dizi atadım 
            comboBox1.Items.AddRange(yönler); // diziyi combobox ekledim 

            listView1.Columns.Add("Hareket Sırası", 150);// Listviwe kod yazarak tanımladım boyutuda elle girdim 
            listView1.Columns.Add("X Konumu", 100);
            listView1.Columns.Add("Y konumu", 100);
            listView1.View = View.Details; // listview aktif ettim 
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int max;
            AlanBoyut_201104078 = Convert.ToInt32(textBox1.Text); // alan boyutunu aldım 
            max = AlanBoyut_201104078;
            xEksen_201104078 = Convert.ToInt32(textBox2.Text);//x eksenini aldım 
            yEksen_201104078 = Convert.ToInt32(textBox3.Text);// y eksenini aldım 
            if (xEksen_201104078 >= max ) // girilen boyuttan fazla x değeri girilmemesi için 
            {
                MessageBox.Show("X KONUMUNU  BOYUTUNDAN BÜYÜK GİREMESSİN","UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox2.Clear();
                
            }
            else if (yEksen_201104078 > max)// girilen boyuttan fazla y değeri girilmemesi için 
            {
                MessageBox.Show("Y KONUMUNU  BOYUTUNDAN BÜYÜK GİREMESSİN", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
            }
            Yonler_201104078 = comboBox1.Text;
            MessageBox.Show("Yön Bilgileri Alındı Lütfen Komut Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); // alındığına dair kullanıcıya bilgi verdim 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            textBox4.Focus();






        }
    }
}
