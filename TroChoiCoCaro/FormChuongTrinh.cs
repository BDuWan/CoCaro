using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TroChoiCoCaro
{
    public partial class FormChuongTrinh : Form
    {
        private CaroChess _CaroChess;
        private Graphics grp;
        public FormChuongTrinh()
        {
            InitializeComponent();
            _CaroChess = new CaroChess();
            grp = panelBanCo.CreateGraphics();
            _CaroChess.TaoMangOCo();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            _CaroChess.VeBanCo(grp);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelBanCo_Paint(object sender, PaintEventArgs e)
        {
            _CaroChess.VeBanCo(grp);
        }

        private void credit_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panelBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            _CaroChess.DanhCo(e.X, e.Y, grp);
        }

        private void panelBanCo_MouseHover(object sender, EventArgs e)
        {
            _CaroChess.DanhCo(e.X, e.Y, grp);
        }
    }
}
