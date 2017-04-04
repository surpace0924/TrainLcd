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
    public partial class SmallTransitEn_0 : UserControl
    {
        public SmallTransitEn_0()
        {
            InitializeComponent();
        }

        private void SmallTransitEn_0_Load(object sender, EventArgs e)
        {
            drowTransit();
            writeDiagonalChar("Ichinoseki", pcbStationName1);
            writeDiagonalChar("Yamanome", pcbStationName2);
            writeDiagonalChar("Hiraizumi", pcbStationName3);
            writeDiagonalChar("Maesawa", pcbStationName4);
            writeDiagonalChar("Rikuchu-Orii", pcbStationName5);
            writeDiagonalChar("Mizusawa", pcbStationName6);
            writeDiagonalChar("Kanegasaki", pcbStationName7);
            writeDiagonalChar("Rokuhara", pcbStationName8);
        }

        private void writeDiagonalChar(string s, PictureBox picb)
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(picb.Width, picb.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //座標(0, 170)に描画するため、ワールド変換を平行移動
            g.TranslateTransform(0, 170);
            //ワールド変換行列を60度回転する
            g.RotateTransform(-60F);

            //使用するFontオブジェクトを作成
            Font fnt = new Font("Meiryo UI", 20);

            //文字列を(0, 0)に描画
            g.DrawString(s, fnt, Brushes.Black, 0, 0);

            //リソースを解放する
            fnt.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            picb.Image = canvas;
            
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
