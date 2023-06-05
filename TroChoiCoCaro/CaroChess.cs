using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TroChoiCoCaro
{
    class CaroChess
    {
        public static Pen pen;
        public static SolidBrush sbBlue;
        public static SolidBrush sbRed;
        
        
        private BanCo _BanCo;
        private OCo[,] _MangOCo;

        public CaroChess()
        {
            pen = new Pen(Color.Black);
            sbBlue = new SolidBrush(Color.Blue);
            sbRed = new SolidBrush(Color.Red);
            _BanCo = new BanCo(20, 20);
            _MangOCo = new OCo[_BanCo.SoDong, _BanCo.SoCot];
        }

        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }
        public void TaoMangOCo()
        {
            for (int i = 0; i < _BanCo.SoDong; i++)
            {
                for (int j = 0; j < _BanCo.SoCot; j++)
                {
                    _MangOCo[i, j] = new OCo(i, j, new Point(j * OCo._ChieuRong, i * OCo._ChieuCao), 0);
                }
            }
        }

        public bool DanhCo(int MouseX, int MouseY, Graphics g)
        {
            int Cot = MouseX / OCo._ChieuRong;
            int Dong = MouseY / OCo._ChieuCao;
            _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbBlue);
            return true;
        }
    }
}
