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
    public partial class AlertForm : Form
    {        /// <summary>背景画像辞書</summary>
        private static readonly IDictionary<int, string> fileDic = new Dictionary<int, string>();

        /// <summary>
        /// 静的コンストラクタ
        /// </summary>
        static AlertForm()
        {

        }

        public AlertForm()
        {
            InitializeComponent();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {

        }
    }
}
