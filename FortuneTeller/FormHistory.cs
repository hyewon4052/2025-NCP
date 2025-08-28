using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class FormHistory : Form
    {   
        List<string> history;
        Form1 form1;

        public FormHistory(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();
            UpdateHistory();
        }

        public void UpdateHistory()
        {
            LoadHistory();
            lbHistory.Items.Clear();
            lbHistory.Items.AddRange(history.ToArray());
        }
        
        private void LoadHistory()
        {
            try
            {
                string filename = "history.csv";
                history = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일을 불러올 수 없습니다. \n {ex.Message}", "파일 없음");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근 권한이 없습니다. \n {ex.Message}", "권한 문제");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다. \n {ex.Message}", "알 수 없는 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateHistory();
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = history[lbHistory.SelectedIndex];
            form1.LoadHistory(message);
        }
    }
}
