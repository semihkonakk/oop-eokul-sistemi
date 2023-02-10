namespace oop_eokul_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 eokul= new Class1();
  
            eokul.mat =mat.Text;
            eokul.türkçe = türk.Text;
            eokul.fen = fen.Text;
            
            if(Convert.ToInt32(mat.Text)<50)
            {
                mat1.Text = "FF";
            }
            else if(Convert.ToInt32(mat.Text) >= 50 && Convert.ToInt32(mat.Text) < 60)
            {
                mat1.Text = "DD";
            }
            else if (Convert.ToInt32(mat.Text) >= 60 && Convert.ToInt32(mat.Text) < 70)
            {
                mat1.Text = "CC";
            }
            else if (Convert.ToInt32(mat.Text) >= 70 && Convert.ToInt32(mat.Text) < 85)
            {
                mat1.Text = "BB";
            }
            else if (Convert.ToInt32(mat.Text) >= 85 && Convert.ToInt32(mat.Text) <= 100)
            {
                mat1.Text = "AA";
            }
            if (Convert.ToInt32(türk.Text) < 50)
            {
                t1.Text = "FF";
            }
            else if (Convert.ToInt32(türk.Text) >= 50 && Convert.ToInt32(türk.Text) < 60)
            {
                t1.Text = "DD";
            }
            else if (Convert.ToInt32(türk.Text) >= 60 && Convert.ToInt32(türk.Text) < 70)
            {
                t1.Text = "CC";
            }
            else if (Convert.ToInt32(türk.Text) >= 70 && Convert.ToInt32(türk.Text) < 85)
            {
                t1.Text = "BB";
            }
            else if (Convert.ToInt32(türk.Text) >= 85 && Convert.ToInt32(türk.Text) <= 100)
            {
                t1.Text = "AA";
            }
            if (Convert.ToInt32(fen.Text) < 50)
            {
                f1.Text = "FF";
            }
            else if (Convert.ToInt32(fen.Text) >= 50 && Convert.ToInt32(fen.Text) <= 60)
            {
                f1.Text = "DD";
            }
            else if (Convert.ToInt32(fen.Text) > 60 && Convert.ToInt32(fen.Text) <= 70)
            {
                f1.Text = "CC";
            }
            else if (Convert.ToInt32(fen.Text) > 70 && Convert.ToInt32(fen.Text) < 85)
            {
                f1.Text = "BB";
            }
            else if (Convert.ToInt32(fen.Text) >= 85 && Convert.ToInt32(fen.Text) <= 100)
            {
                f1.Text = "AA";
            }

            int m,t,f,sonuc;
            m = Convert.ToInt32(mat.Text);
            t = Convert.ToInt32(türk.Text);
            f = Convert.ToInt32(fen.Text);
            sonuc = (m + t + f) / 3;
            ort.Text=sonuc.ToString();

            eokul.not =ort.Text;

            if(Convert.ToInt32(ort.Text)<50)
                {
                    d1.Text = "KALDI!";
                }
            else 
                {
                    d1.Text = "GEÇTÝ!";
                }
        
            eokul.durum = d1.Text;

            


        }

        private void button2_Click(object sender, EventArgs e)
        { 
         
            Class1 eokul = new Class1();
            eokul.ad = "SEMÝH";
            eokul.soyad = "KONAK";
            eokul.sýnýf = "11-C";
            eokul.no = "147";
            eokul.not = ort.Text;
            eokul.durum=d1.Text;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("AD", 150);
            listView1.Columns.Add("SOYAD", 150);
            listView1.Columns.Add("SINIF", 100);
            listView1.Columns.Add("NUMARA", 93);
            listView1.Columns.Add("ORTALAMA", 100);
            listView1.Columns.Add("DURUM", 100);

            string[] row = { eokul.ad, eokul.soyad, eokul.sýnýf, eokul.no, eokul.not, eokul.durum };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 eokul = new Class1();
            eokul.ad = "SEMÝH";
            eokul.soyad = "KONAK";
            eokul.sýnýf = "11-C";
            eokul.no = "147";
           
            ad.Text= eokul.ad;
            soyad.Text= eokul.soyad;
            sýnýf.Text = eokul.sýnýf;
            no.Text= eokul.no;
        }
    }
}