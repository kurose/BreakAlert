using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BreakAlert
{
    public partial class AlertForm : Form
    {
        /// <summary>アラート表示時間(10分)</summary>
        private static readonly int _alertShowingTime = 10 * 60 * 1000;
        /// <summary>背景画像フォルダ</summary>
        private static readonly string _folder = "./image";
        /// <summary>背景画像辞書</summary>
        private static readonly IDictionary<int, string> _fileDic = new Dictionary<int, string>();

        private static readonly Random _rand;

        /// <summary>
        /// 静的コンストラクタ
        /// </summary>
        static AlertForm()
        {
            //背景画像辞書の作成
            string[] files = Directory.GetFiles(_folder);
            foreach (string file in files)
            {
                _fileDic.Add(_fileDic.Count, file);
            }
            //キャストによるオーバフローは無視して乱数の種を与える
            _rand = new Random(unchecked((int)DateTime.Now.Ticks));
        }

        private Timer m_timer = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AlertForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlertForm_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("休憩し～や～、今HH時やで！(10分たったら勝手に消えるで～)");
            //画面終了用タイマーセット
            m_timer = new Timer();
            m_timer.Interval = _alertShowingTime;
            m_timer.Tick += this.timerTickHandler;
            m_timer.Start();
            //ランダムで背景
            try
            {
                this.BackgroundImage = Image.FromFile(_fileDic[_rand.Next(_fileDic.Count)]);
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch
            {
                //imageフォルダに画像ファイル以外が置かれていた場合に背景に設定できず
                //例外が発生する可能性がある
                //この場合、例外処理はせず背景なしにする
            }
        }

        /// <summary>
        /// タイマーのハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTickHandler(object sender, EventArgs e)
        {
            m_timer.Stop();
            this.Close();
        }

        /// <summary>
        /// フォーム終了前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlertForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_timer != null)
            {
                m_timer.Stop();
                m_timer.Tick -= this.timerTickHandler;
                m_timer.Dispose();
                m_timer = null; 
            }
        }
    }
}
