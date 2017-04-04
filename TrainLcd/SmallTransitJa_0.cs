using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TrainLcd
{
    public partial class SmallTransitJa_0 : UserControl
    {
        public SmallTransitJa_0()
        {
            InitializeComponent();
        }

        private void SmallTransitJa_0_Load(object sender, EventArgs e)
        {
            drowTransit();

        }


        private void drowTransit()
        {            
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //多角形の角を決める
            Point[] points = {  new Point(0, 0),
                                new Point(875, 0),
                                new Point(890, 30),
                                new Point(875, 60) ,
                                new Point(0, 60)
            };

            //FillMode.Windingで塗りつぶす
            g.FillPolygon(Brushes.Green, points, FillMode.Winding);


            //先に描いた四角に内接する楕円を黒で描く
            g.FillEllipse(Brushes.White, 40, 15, 30, 30);
            g.FillEllipse(Brushes.White, 20, 5, 50, 50);
            //g.FillEllipse(Brushes.White, 130, 5, 50, 50);
            g.FillEllipse(Brushes.White, 240, 5, 50, 50);
            g.FillEllipse(Brushes.White, 350, 5, 50, 50);
            //g.FillEllipse(Brushes.White, 460, 5, 50, 50);
            g.FillEllipse(Brushes.White, 570, 5, 50, 50);
            //g.FillEllipse(Brushes.White, 680, 5, 50, 50);
            //g.FillEllipse(Brushes.White, 790, 5, 50, 50);

            g.FillRectangle(Brushes.White, 22, 27, 46, 6);
            g.FillRectangle(Brushes.White, 132, 27, 46, 6);
            g.FillRectangle(Brushes.White, 242, 27, 46, 6);
            g.FillRectangle(Brushes.White, 352, 27, 46, 6);
            g.FillRectangle(Brushes.White, 462, 27, 46, 6);
            g.FillRectangle(Brushes.White, 572, 27, 46, 6);
            g.FillRectangle(Brushes.White, 682, 27, 46, 6);
            g.FillRectangle(Brushes.White, 792, 27, 46, 6);


            //リソースを解放する
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;
        }
    }
}
