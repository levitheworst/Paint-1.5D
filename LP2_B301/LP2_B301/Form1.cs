using static System.Drawing.Color;
//CTII-217
//Iasmim, Isabeli, Levi e Mateus
namespace LP2_B301
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Color CurrentColor = Black;
        public static Point DrawStart = new(0, 0), DrawEnd = new(0, 0);
        public static bool isOperating = false;
        /*
        int pintado = 0;
        LinhaVermelha minhaLinhaVermelha = new LinhaVermelha();
        LinhaVerde minhaLinhaVerde = new LinhaVerde();
        LinhaAzul minhaLinhaAzul = new LinhaAzul();
        private void Painel1_Click(object sender, EventArgs e)
        {
            if (pintado < 3)
            {
                Graphics g = this.CreateGraphics();
                switch (pintado)
                {
                    case 0:
                        mostrarLinha(minhaLinhaVermelha);
                        break;
                    case 1:
                        mostrarLinha(minhaLinhaVerde);
                        break;
                    case 2:
                        mostrarLinha(minhaLinhaAzul);
                        break;
                }
                pintado++;
            }
            else
            {
                this.Invalidate();
                pintado = 0;
            }
        }
        private void mostrarLinha(Linha linha)
        {
            linha.pintarLinha(this);
        }
        */
        private void PrintRect(Color cor, float tamanho, Point começo, Point fim)
        {
            DrawingRect.Print(this, cor, tamanho, começo, fim);
        }
        //n sei pq fiz esse extra mas ok
        private void PrintRect(Color cor, float tamanho, int x1, int y1, int x2, int y2)
        {
            Point começo = new(x1, y1);
            Point fim = new(x2, y2);
            DrawingRect.Print(this, cor, tamanho, começo, fim);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isOperating) return;
            DrawStart = Control.MousePosition;
            isOperating = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isOperating) return;
            Color[] cores = { Black, White, Brown, Red, Orange, Yellow, Green, Blue, Purple };
            var index = listBox1.SelectedIndex;
            if (index < 0 || index >= cores.Length) index = 0;
            var cor = cores[index];
            float tamanho = (float)numericUpDown1.Value;
            if (tamanho < 1 || tamanho > 100) tamanho = 10;
            DrawEnd = Control.MousePosition;
            PrintRect(cor, tamanho, DrawStart, DrawEnd);
            isOperating = false;
        }
    }
}