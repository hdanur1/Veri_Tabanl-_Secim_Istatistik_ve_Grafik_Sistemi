using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Veri_Tabanlı_PSGI
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-JJBSGN9K\SQLEXPRESS;Initial Catalog=DBSECİMPROJE;Integrated Security=True");

        private void btnOyGiris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);

            komut.Parameters.AddWithValue("@p1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", txtA.Text);
            komut.Parameters.AddWithValue("@p3", txtB.Text);
            komut.Parameters.AddWithValue("@p4", txtC.Text);
            komut.Parameters.AddWithValue("@p5", txtD.Text);
            komut.Parameters.AddWithValue("@p6", txtE.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("oy girişi gerçeklesti");


        }

        private void btnGrf_Click(object sender, EventArgs e)
        {
            FrmGrafikler grafik= new FrmGrafikler();
            grafik.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
