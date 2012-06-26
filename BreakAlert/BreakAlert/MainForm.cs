using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BreakAlert
{
    public partial class MainForm : Form
    {
        /// <summary>30分区切りを知らせるタイマー</summary>
        private Timer m_timer = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームのロード時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            m_timer = new Timer();
            m_timer.Tick += this.timerTickHandler;
            m_timer.Interval = this.calcInterval();
            m_timer.Start();
        }

        /// <summary>
        /// タスクトレイアイコンで終了を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemEnd_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// フォームが閉じる前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
            if (m_timer != null)
            {
                m_timer.Stop();
                m_timer.Tick -= this.timerTickHandler;
                m_timer.Dispose();
                m_timer = null;
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
            //通知
            new AlertForm().Show();
            m_timer.Interval = this.calcInterval();
            m_timer.Start();
        }

        /// <summary>
        /// 次の30分区切りまでのミリ秒を計算(日付またぎで正しく動作しないと思われる)
        /// </summary>
        /// <returns></returns>
        private int calcInterval()
        {
            DateTime now = DateTime.Now;
            TimeSpan nowTime = new TimeSpan(now.Hour, now.Minute, now.Second);
            TimeSpan nextTime = nowTime;
            if (now.Minute < 30)
            {
                nextTime = new TimeSpan(now.Hour, 30, 0);
            }
            else
            {
                nextTime = new TimeSpan(now.Hour + 1, 0, 0);
            }
            return (int)(nextTime.TotalMilliseconds - nowTime.TotalMilliseconds);
        }
    }
}
