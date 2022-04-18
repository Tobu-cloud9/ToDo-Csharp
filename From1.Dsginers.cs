namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resister = new System.Windows.Forms.Button();
            this.Restore = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.InputDate = new System.Windows.Forms.DateTimePicker();
            this.InputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InputTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.done,
            this.date,
            this.task,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(31, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(667, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // done
            // 
            this.done.DataPropertyName = "checkbox";
            this.done.HeaderText = "完了";
            this.done.MinimumWidth = 8;
            this.done.Name = "done";
            this.done.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "期限";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // task
            // 
            this.task.HeaderText = "やること";
            this.task.MinimumWidth = 8;
            this.task.Name = "task";
            this.task.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "limit";
            this.Column1.HeaderText = "期日まで";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Resister
            // 
            this.Resister.Location = new System.Drawing.Point(727, 211);
            this.Resister.Name = "Resister";
            this.Resister.Size = new System.Drawing.Size(131, 75);
            this.Resister.TabIndex = 1;
            this.Resister.Text = "登録";
            this.Resister.UseVisualStyleBackColor = true;
            this.Resister.Click += new System.EventHandler(this.button1_Click);
            // 
            // Restore
            // 
            this.Restore.Location = new System.Drawing.Point(761, 308);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(228, 71);
            this.Restore.TabIndex = 2;
            this.Restore.Text = "保存";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(903, 211);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(129, 75);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "削除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.SelectedRowsButton_Remove);
            // 
            // InputDate
            // 
            this.InputDate.Location = new System.Drawing.Point(746, 48);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(200, 25);
            this.InputDate.TabIndex = 4;
            this.InputDate.ValueChanged += new System.EventHandler(this.InputDate_ValueChanged);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(746, 155);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(217, 25);
            this.InputText.TabIndex = 5;
            this.InputText.Text = "fafa";
            this.InputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "期限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "やること";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "非表示解除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // InputTime
            // 
            this.InputTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.InputTime.Location = new System.Drawing.Point(746, 79);
            this.InputTime.Name = "InputTime";
            this.InputTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputTime.ShowUpDown = true;
            this.InputTime.Size = new System.Drawing.Size(200, 25);
            this.InputTime.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 518);
            this.Controls.Add(this.InputTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.InputDate);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.Resister);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Resister;
        private System.Windows.Forms.Button Restore;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.DateTimePicker InputDate;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn done;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker InputTime;
    }
}
