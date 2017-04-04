using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainLcd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartTrainLcd_Click(object sender, EventArgs e)
        {
            //Form2クラスのインスタンスを作成する
            LcdDisplay f = new LcdDisplay();
            //Form2を表示する
            //ここではモードレスフォームとして表示する
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
