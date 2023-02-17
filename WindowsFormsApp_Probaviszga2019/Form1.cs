using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp_Probaviszga2019
{
    public partial class Form1 : Form
    {
        PetrikLajosSzg petriklajosszg = new PetrikLajosSzg("petrikgepek.txt");     
        List<Image> kepPontok = new List<Image> { 
            Image.FromFile(@"Kepek\Pont0.jpg"),
            Image.FromFile(@"Kepek\Pont1.jpg"),
            Image.FromFile(@"Kepek\Pont2.jpg"),
            Image.FromFile(@"Kepek\Pont3.jpg") 
        };
        int teremSzint = 0;
        int kepMeret = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel_Update();
        }
        void Panel_Update()
        {
            this.Text = $"{petriklajosszg.Geptermek[teremSzint].Nev}";
            picturebox_gepterem.Image = Image.FromFile(@"Kepek\" + petriklajosszg.Geptermek[teremSzint].Nev.Split()[0] + ".jpg");
            picturebox_gepterem.SizeMode = PictureBoxSizeMode.Zoom;

            panel_pont.Controls.Clear();
            for (int i = 0; i < petriklajosszg.Geptermek[teremSzint].SorDb; i++)
            {
                for (int j = 0; j < petriklajosszg.Geptermek[teremSzint].HelyDb; j++)
                {
                    PictureBox kep = new PictureBox();
                    kep.Image = kepPontok[petriklajosszg.Geptermek[teremSzint].Ertekeles[i, j]];
                    kep.SetBounds(j * kepMeret, i * kepMeret, kepMeret, kepMeret);
                    kep.SizeMode = PictureBoxSizeMode.StretchImage;
                    kep.Padding = new Padding(2);

                    int x = i; 
                    int y = j;
                    kep.Click += (o, e) =>
                    {
                        switch (petriklajosszg.Geptermek[teremSzint].Ertekeles[x, y])
                        {
                            case 1:
                                petriklajosszg.Geptermek[teremSzint].Ertekeles[x, y] = 2;
                                kep.Image = kepPontok[petriklajosszg.Geptermek[teremSzint].Ertekeles[x, y]];
                                break;
                            case 2:
                                petriklajosszg.Geptermek[teremSzint].Ertekeles[x, y] = 3;
                                kep.Image = kepPontok[petriklajosszg.Geptermek[teremSzint].Ertekeles[x, y]];
                                break;
                            case 3:
                                petriklajosszg.Geptermek[teremSzint].Ertekeles[x, y] = 1;
                                kep.Image = kepPontok[petriklajosszg.Geptermek[teremSzint].Ertekeles[x, y]];
                                break;
                            default:
                                MessageBox.Show("Ezen a helyen nem ült senki!");
                                break;
                        }
                        this.Text = $"{petriklajosszg.Geptermek[teremSzint].Nev}";
                    };
                    panel_pont.Controls.Add(kep);
                }
            }

        }

        private void button_left_Click(object sender, EventArgs e)
        {
            teremSzint--;
            if (teremSzint <= 0) {
                teremSzint = petriklajosszg.Geptermek.Count - 1;
            }
            Panel_Update();
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            teremSzint++;
            if (teremSzint >= petriklajosszg.Geptermek.Count) {
                teremSzint = 0;
            }
            Panel_Update();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy("petrikgepek.txt", "petrikgepek.bak", true);
                using (StreamWriter sw = new StreamWriter("petrikgepek.txt"))
                {
                    foreach (Gepterem item in petriklajosszg.Geptermek)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.SorDb, item.HelyDb));
                        for (int i = 0; i < item.SorDb; i++)
                        {
                            string[] row = new string[item.HelyDb];
                            for (int j = 0; j < item.HelyDb - 1; j++)
                            {
                                row[j] = item.Ertekeles[i, j].ToString();
                            }
                            sw.WriteLine(string.Join(";", row));
                        }
                        sw.WriteLine();
                    }
                    MessageBox.Show("Sikeres a mentés!");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\nA mentés sikertelen!");
                return;
            }
        }
    }
}
