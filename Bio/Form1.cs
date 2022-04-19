using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dosya okuma kodu 

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Please Select Text File";
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(file.FileName);
                textBox8.Text = reader.ReadToEnd();
                reader.Close();
            }
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(file.FileName);
                textBox9.Text = reader.ReadToEnd();
                reader.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Süreyi hesaplamak için
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //Dosya yolunu veriyoruz
            string[] seq1reader = File.ReadAllLines("C:/biyo/seq1.txt");
            string[] seq2reader = File.ReadAllLines("C:/biyo/seq2.txt");
            string Seq1 = seq1reader[1];
            string Seq2 = seq2reader[1];

            //Textboxlar ile sayıları alacağız
            int matchPuani = Convert.ToInt32(this.textBox1.Text);
            int missmatchCezasi = Convert.ToInt32(this.textBox2.Text);
            int gapCezasi = Convert.ToInt32(this.textBox3.Text);

            //dosyadan aldığımız diziimlerin uzunluğu
			int seq1Length = Seq1.Length;
			int seq2Length = Seq2.Length;

			char[] seri1 = new char[seq1Length + 2];
			char[] seri2 = new char[seq2Length + 2];

			seri1 = Seq1.ToCharArray();
			seri2 = Seq2.ToCharArray();

			string[,] matriks = new string[seq2Length + 2, seq1Length + 2];

			for (int i = 0; i < seq2Length; i++)
			{
				if (gapCezasi <= 0)
				{
					matriks[1, 1] = 0.ToString();
					matriks[i + 2, 1] = 0.ToString();
				}
				else
				{
					matriks[1, 1] = gapCezasi.ToString();
					matriks[i + 2, 1] = gapCezasi.ToString();
				}
				matriks[i + 2, 0] = seri2[i].ToString();

				for (int j = 0; j < seq1Length; j++)
				{
					matriks[0, j + 2] = seri1[j].ToString();
					if (gapCezasi <= 0)
						matriks[1, j + 2] = 0.ToString(); //buradaki 0 lar sözlük tipi için
					else
						matriks[1, j + 2] = gapCezasi.ToString();

				}
			}
			//sayıları sıralacağımız döngü
			for (int j = 0; j < seq2Length; j++)
			{
				for (int i = 0; i < seq1Length; i++)
				{
					if (matriks[j + 2, 0] == matriks[0, i + 2])
					{
						//degerlerimizi sayılara döndürüyoruz
						int deger1 = Convert.ToInt32(matriks[j + 1, i + 2]);
						int deger2 = Convert.ToInt32(matriks[j + 2, i + 1]);
						int deger3 = Convert.ToInt32(matriks[j + 1, i + 1]);

						int hesapla1 = Math.Max(deger1 + gapCezasi, deger2 + gapCezasi);
						int hesapla2 = Math.Max(hesapla1, deger3 + matchPuani);
						// bu koşullara bakarak  en büyük değer hangisi ise matrisin i,j konumuna o değer yazılır
						if (hesapla2 < 0)
							matriks[j + 2, i + 2] = 0.ToString();
						else
							matriks[j + 2, i + 2] = hesapla2.ToString();
					}
					else
					{
						int deger1 = Convert.ToInt32(matriks[j + 1, i + 2]);
						int deger2 = Convert.ToInt32(matriks[j + 2, i + 1]);
						int deger3 = Convert.ToInt32(matriks[j + 1, i + 1]);

						int hesapla1 = Math.Max(deger1 + gapCezasi, deger2 + gapCezasi);
						int hesapla2 = Math.Max(hesapla1, deger3 + missmatchCezasi);
						if (hesapla2 < 0)
							matriks[j + 2, i + 2] = 0.ToString();
						else
							matriks[j + 2, i + 2] = hesapla2.ToString();
					}

				}
			}

			//Panelimizin kodları
			for (int i = 0; i <= seq2Length + 1; i++)
			{
				for (int j = 0; j <= seq1Length + 1; j++)
				{
					Label label = new Label();
					label.BorderStyle = BorderStyle.Fixed3D;
					label.BackColor = Color.White;
					label.Text = Convert.ToString(matriks[i, j]);
					label.Size = new Size(25, 25);
					label.Location = new Point(25 * j, 25 * i);
					panel1.Controls.Add(label);

				}
			}

			int satirlar;

			int max3 = Convert.ToInt32(matriks[2, 2]);

			for (satirlar = 3; satirlar <= seq2Length + 1; satirlar++)
			{

				for (int sutunlar = 3; sutunlar < seq1Length + 1; sutunlar++)
				{
					if (Convert.ToInt32(matriks[satirlar, sutunlar]) > max3)
					{
						max3 = Convert.ToInt32(matriks[satirlar, sutunlar]);
						calistir(sutunlar);
					}
					else
						continue;
				}

			}

			void calistir(int sutunlar)
			{
				textBox4.Clear();
				textBox5.Clear();
				int satir = satirlar;
				int sutun = sutunlar;
				int max2 = 1;
				int counter1 = 0;
				int counter2 = 0;
				int counter3 = 0;
				int counter4 = 0;
				int counter5 = 0;
				int counter6 = 0;
				int counter7 = 0;


				if (matriks[satir, 0] == matriks[0, sutun])
				{
					counter7++;
					textBox4.SelectedText = matriks[satir, 0];
					textBox5.SelectedText = matriks[0, sutun];
				}

				while (max2 != 0)
				{

					if ((Convert.ToInt32(matriks[satir, sutun - 1]) > Convert.ToInt32(matriks[satir - 1, sutun])) && (Convert.ToInt32(matriks[satir, sutun - 1]) > Convert.ToInt32(matriks[satir - 1, sutun - 1])))
					{
						max2 = 0;
						max2 = Convert.ToInt32(matriks[satir, sutun - 1]);
						if (matriks[satir, 0] == matriks[0, sutun - 1])
						{
							counter4++;
							textBox4.SelectedText = matriks[satir, 0];
							textBox5.SelectedText = matriks[0, sutun - 1];
						}
						else continue;
						satir = satir;
						sutun = sutun - 1;
						counter1 += max2;


					}
					if ((Convert.ToInt32(matriks[satir - 1, sutun]) > Convert.ToInt32(matriks[satir, sutun - 1])) && (Convert.ToInt32(matriks[satir - 1, sutun]) > Convert.ToInt32(matriks[satir - 1, sutun - 1])))
					{
						max2 = 0;
						max2 = Convert.ToInt32(matriks[satir - 1, sutun]);
						if (matriks[satir - 1, 0] == matriks[0, sutun])
						{
							counter5++;
							textBox4.SelectedText = matriks[satir - 1, 0];
							textBox5.SelectedText = matriks[0, sutun];
						}
						else continue;
						satir = satir - 1;
						sutun = sutun;
						counter2 += max2;

					}
					if ((Convert.ToInt32(matriks[satir - 1, sutun - 1]) >= Convert.ToInt32(matriks[satir, sutun - 1])) && (Convert.ToInt32(matriks[satir - 1, sutun - 1]) >= Convert.ToInt32(matriks[satir - 1, sutun])))
					{
						max2 = 0;
						max2 = Convert.ToInt32(matriks[satir - 1, sutun - 1]);

						if (matriks[satir - 1, 0] == matriks[0, sutun - 1] && matriks[0, sutun - 1] != matriks[0, sutun - 2])
						{
							counter6++;
							textBox4.SelectedText = matriks[satir - 1, 0];
							textBox5.SelectedText = matriks[0, sutun - 1];
						}
						else if (max2 == 0) continue;
						else if (matriks[0, sutun - 1] == matriks[0, sutun - 2])
						{
							textBox4.SelectedText = matriks[satir - 1, 0];
							textBox5.SelectedText = "-";
						}
						
						satir = satir - 1;
						sutun = sutun - 1;
						counter3 += max2;

					}
				}

				string siralanan = textBox4.Text;
				string siralananters = "";
				foreach (char harfler in siralanan)
				{
					siralananters = harfler.ToString() + siralananters;
				}
				textBox4.Text = siralananters;

				string siralanan2 = textBox5.Text;
				string siralananters2 = "";
				foreach (char harfler in siralanan2)
				{
					siralananters2 = harfler.ToString() + siralananters2;
				}
				textBox5.Text = siralananters2;

				label5.Text = (counter6 + counter7 + counter4 + counter5).ToString();
			}

			//çalışma süresi hesaplanıyor
			watch.Stop();
			label4.Text = "The run time is  " + watch.Elapsed.Milliseconds + " in milliseconds ";

		}


	}
}

