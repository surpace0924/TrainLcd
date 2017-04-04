using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainLcd
{
    public partial class LcdDisplay : Form
    {
        // staticで宣言してインスタンスを固定。
        public static WaitDeparture waitDeparture;
        public static SmallTransitJa_0 smallTransitJa_0;
        public static SmallTransitEn_0 smallTransitEn_0;


        string nowStationKanji;
        string nowStationEn;

        string destinationJa;
        string destinationEn;

        int trainType;

        int nowState;


        public LcdDisplay()
        {
            InitializeComponent();
        }


        private void LcdDisplay_Load(object sender, EventArgs e)
        {        
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //多角形の角を決める
            Point[] points = {  new Point(0, 0),
                                new Point(255, 0),
                                new Point(280, 95),
                                new Point(255, 190) ,
                                new Point(0, 190)
            };


            //FillMode.Windingで塗りつぶす
            g.FillPolygon(Brushes.Green, points, FillMode.Winding);

            //リソースを解放する
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;

            nowStationKanji = "一ノ関";
            nowStationEn = "Ichinoseki";

            destinationJa = "盛岡";
            destinationEn = "Morioka";
            trainType = 2;
            nowState = 0;

            // 3秒単位でイベントを発生させる
            timer1.Interval = 3000;

            // タイマーを有効に
            timer1.Enabled = true;

            // 5秒単位でイベントを発生させる
            timer2.Interval = 5000;

            // タイマーを有効に
            timer2.Enabled = true;

            pictureBox2.BackColor = Color.Green;
            label2.BackColor = Color.Green;
            label3.BackColor = Color.Green;
            labDestinationJa.BackColor = Color.Green;
            labDestinationEn.BackColor = Color.Green;

            changeOnBarToKanji();

            waitDeparture = new WaitDeparture();
            smallTransitJa_0 = new SmallTransitJa_0();
            smallTransitEn_0 = new SmallTransitEn_0();

            pnlMainDisplay.Controls.Add(waitDeparture);
            pnlMainDisplay.Controls.Add(smallTransitJa_0);
            pnlMainDisplay.Controls.Add(smallTransitEn_0);

        }


        
        private int changeTopFlag = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string nowTime = System.DateTime.Now.ToShortTimeString();
            labTime.Text = nowTime;


            if (nowState == 0)
            {
                if (changeTopFlag == 0)
                {
                    changeOnBarToKanji();
                    changeTopFlag = 1;
                }
                else if (changeTopFlag == 1)
                {
                    changeOnBarToEnglish();
                    changeTopFlag = 0;
                }
            } 
            else
            {
                if (changeTopFlag == 0)
                {
                    changeOnBarToKanji();
                    changeTopFlag = 1;
                }
                else if (changeTopFlag == 1)
                {
                    changeOnBarToHiragana();
                    changeTopFlag = 2;
                }
                else if (changeTopFlag == 2)
                {
                    changeOnBarToEnglish();
                    changeTopFlag = 0;
                }
            }
        }


        private int changeBottomFlag = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (changeBottomFlag == 0)
            {
                waitDeparture.Visible = true;
                smallTransitJa_0.Visible = false;
                smallTransitEn_0.Visible = false;
                changeBottomFlag = 1;
            }
            else if (changeBottomFlag == 1)
            {
                waitDeparture.Visible = false;
                smallTransitJa_0.Visible = true;
                smallTransitEn_0.Visible = false;
                changeBottomFlag = 2;
            }
            else if (changeBottomFlag == 2)
            {
                waitDeparture.Visible = false;
                smallTransitJa_0.Visible = false;
                smallTransitEn_0.Visible = true;
                changeBottomFlag = 0;
            }
        }


        private void changeOnBarToKanji()
        {
            label1.Text = "現在時刻";
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            labDestinationJa.Visible = true;
            labDestinationEn.Visible = false;


            if (nowStationKanji.Length == 2)
            {
                labStation.Text = nowStationKanji.Substring(0, 1) + "　" + nowStationKanji.Substring(1, 1);
            }
            else if (nowStationKanji.Length == 3)
            {
                labStation.Text = nowStationKanji.Substring(0, 1) + " " + nowStationKanji.Substring(1, 1) + " " + nowStationKanji.Substring(2, 1);
            }
            else
            {
                labStation.Text = nowStationKanji;
            }


            if (destinationJa.Length == 2)
            {
                labDestinationJa.Text = destinationJa.Substring(0, 1) + "　　" + destinationJa.Substring(1, 1);
            }
            else
            {
                labDestinationJa.Text = destinationJa;
            } 


                if (trainType == 0)
            {
                labTrainType.Text = "各駅停車";
            }
            else if (trainType == 1)
            {
                labTrainType.Text = "普通";
            }
            else if (trainType == 2)
            {
                labTrainType.Text = "快速";
            }

            if (nowState == 0)
            {
                labState.Text = "ただいま";
            }
        }

        private void changeOnBarToHiragana()
        {

        }



        private void changeOnBarToEnglish()
        {
            label1.Text = "Time";
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            labDestinationJa.Visible = false;
            labDestinationEn.Visible = true;

            labStation.Text = nowStationEn;
            labDestinationEn.Text = destinationEn;
            

            if (trainType == 0)
            {
                labTrainType.Text = "Local";
            }
            else if (trainType == 1)
            {
                labTrainType.Text = "Local";
            }
            else if (trainType == 2)
            {
                labTrainType.Text = "Rapid";
            }


            if (nowState == 0)
            {
                labState.Text = "Now stopping at";
            }
        }


        //マウスのクリック位置を記憶
        private Point mousePoint;

        //Form1のMouseDownイベントハンドラ
        //マウスのボタンが押されたとき
        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        //Form1のMouseMoveイベントハンドラ
        //マウスが動いたとき
        private void Form1_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
                //または、つぎのようにする
                //this.Location = new Point(
                //    this.Location.X + e.X - mousePoint.X,
                //    this.Location.Y + e.Y - mousePoint.Y);
            }
        }

    }
}
