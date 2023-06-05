using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TroChoiCoCaro
{
    class BanCo
    {
        public int SoDong;
        public int SoCot;
       
        public BanCo()
        {
            SoDong = 0;
            SoCot = 0;
        }

        public BanCo(int _sodong, int _socot)
        {
            SoDong = _sodong;
            SoCot = _socot;
        }

        public void VeBanCo(Graphics g)
        {
            for (int i = 0; i <= SoCot; i++)
            {
                g.DrawLine(CaroChess.pen, i * OCo._ChieuRong, 0, i * OCo._ChieuRong, SoDong * OCo._ChieuCao);
            }
            for (int j = 0; j <= SoCot; j++)
            {
                g.DrawLine(CaroChess.pen, 0, j * OCo._ChieuCao, SoCot * OCo._ChieuRong, j * OCo._ChieuCao);
            }           
        }

        public void VeQuanCo(Graphics g,Point point,SolidBrush sb)
        {
            g.FillEllipse(sb, point.X, point.Y, OCo._ChieuRong, OCo._ChieuCao);
        }
    }
}
