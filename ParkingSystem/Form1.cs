using System;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// clsUtilクラスインスタンス
        /// </summary>
        private clsUtil cu = new clsUtil();

        /// <summary>
        /// コンストラクター
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面ロードイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 初期起動時
            button2.Enabled = false;
        }

        /// <summary>
        /// ボタン押下イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // ボタン押下イベント処理
            button2.Enabled = true;
        }

        /// <summary>
        /// 駐車料金計算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // 金額計算
            textBox2.Text = cu.ParkingPrice(textBox1.Text);
        }
    }
}
