using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TroChoiCoCaro
{
    class OCo
    {      
        public const int _ChieuRong = 30;
        public const int _ChieuCao = 30;

        private int Dong { get; set; }
        private int Cot { get; set; }
        public Point ViTri { get; set; }
        public int SoHuu { get; set; }
        
        public OCo(int dong, int cot,Point vitri, int sohuu)
        {
            Dong = dong;
            Cot = cot;
            ViTri = vitri;
            SoHuu = sohuu;
        }
    }
}
