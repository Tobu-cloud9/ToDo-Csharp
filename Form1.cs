using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        bool input_check;
        DateTime input_date;
        string input_todo;
        int input_timelimit;
  
        public Form1()
        {
            InitializeComponent();

        }

        public DateTime SyntheticDate(DateTime d, DateTime h)
        {
            DateTime ans = new DateTime(d.Year, d.Month, d.Day, h.Hour, h.Minute, h.Second, h.Millisecond);
            return ans;
        }

        //期限までの時間を導き出す関数
         public int Limit(DateTime d)
        {
            TimeSpan time_limit = new TimeSpan();
            DateTime time_date = d;
            DateTime time_now = DateTime.Now;
            if (time_date > time_now)
            {
                time_limit = time_date - time_now;
                return Convert.ToInt32(time_limit.TotalHours);
            }
            else
            {
                return -1;
            }

        }

        //セルが編集されたときイベントを発生させる
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridView1.Rows[e.RowIndex].Visible = false;
            }
        }

        //登録ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            input_check = false; //完了
            input_date = SyntheticDate(InputDate.Value, InputTime.Value);
            input_todo = InputText.Text; //やること
            input_timelimit = this.Limit(input_date); //期限までの時間           

            //行を追加 (データを登録)
            dataGridView1.Rows.Add();
            int i = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[i].Cells[0].Value = input_check; //完了セルに値を登録
            dataGridView1.Rows[i].Cells[1].Value = (input_date); //期限セルに値を登録
            dataGridView1.Rows[i].Cells[2].Value = input_todo; //やることセルに値を登録
            if(input_timelimit >= 0)
            {
                dataGridView1.Rows[i].Cells[3].Value = (input_timelimit + "時間"); //期日までセルに値を登録
            }
            else //期限日時を過ぎた場合
            {
                dataGridView1.Rows[i].Cells[3].Value = "期日を過ぎています";
            }
           
        }

        //削除ボタン
        private void SelectedRowsButton_Remove(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.SelectedRows)
            {　
                dataGridView1.Rows.Remove(r);
            }
        }

        //保存ボタン
        private void Restore_Click(object sender, EventArgs e)
        {

            Console.WriteLine("保存しました");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {

        }

        //非表示
        private void button1_Click_2(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
