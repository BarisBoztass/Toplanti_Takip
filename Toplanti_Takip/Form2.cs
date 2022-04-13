using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplanti_Takip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm) //İç içe form için metot
        {

            pnlFormGetir.Controls.Clear();
            IsMdiContainer = true;
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None; //pencereyere sığdırır.
            pnlFormGetir.Controls.Add(frm);


            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salonlar_Click(object sender, EventArgs e)
        {
            Salonlar salonlar = new Salonlar();
            FormGetir(salonlar);
        }

        private void btn_Toplantilari_Listele_Click(object sender, EventArgs e)
        {
            Toplanti_Listele toplanti_Listele= new Toplanti_Listele();
            FormGetir(toplanti_Listele);
        }

        private void btn_Toplanti_Olustur_Click(object sender, EventArgs e)
        {
            Toplanti_Olustur toplanti_Oluştur = new Toplanti_Olustur();
            FormGetir(toplanti_Oluştur);
        }
    }
}
