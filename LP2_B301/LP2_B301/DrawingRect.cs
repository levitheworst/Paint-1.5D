using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2_B301
{
    internal class DrawingRect
    {
        public static void Print(Form f, Color cor, float tamanho, Point começo, Point fim)
        {
            f.CreateGraphics().DrawLine(new Pen(cor, tamanho), começo, fim);
        }
    }
}
