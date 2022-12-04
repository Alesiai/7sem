namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.getDataBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updName = new System.Windows.Forms.TextBox();
            this.updPhone = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createName = new System.Windows.Forms.TextBox();
            this.createPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // getDataBtn
            // 
            this.getDataBtn.Location = new System.Drawing.Point(815, 49);
            this.getDataBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getDataBtn.Name = "getDataBtn";
            this.getDataBtn.Size = new System.Drawing.Size(217, 116);
            this.getDataBtn.TabIndex = 0;
            this.getDataBtn.Text = "Get data";
            this.getDataBtn.UseVisualStyleBackColor = true;
            this.getDataBtn.Click += new System.EventHandler(this.getDataBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(865, 490);
            this.createBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(167, 78);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create new user";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(345, 490);
            this.updBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(149, 75);
            this.updBtn.TabIndex = 2;
            this.updBtn.Text = "Update";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(815, 322);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(217, 52);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete Selected rows";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updName
            // 
            this.updName.Location = new System.Drawing.Point(92, 487);
            this.updName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updName.Name = "updName";
            this.updName.Size = new System.Drawing.Size(196, 22);
            this.updName.TabIndex = 5;
            // 
            // updPhone
            // 
            this.updPhone.Location = new System.Drawing.Point(92, 540);
            this.updPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updPhone.Name = "updPhone";
            this.updPhone.Size = new System.Drawing.Size(196, 22);
            this.updPhone.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(92, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 325);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 464);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 521);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter phone number";
            // 
            // createName
            // 
            this.createName.Location = new System.Drawing.Point(588, 487);
            this.createName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createName.Name = "createName";
            this.createName.Size = new System.Drawing.Size(212, 22);
            this.createName.TabIndex = 12;
            // 
            // createPhone
            // 
            this.createPhone.Location = new System.Drawing.Point(588, 540);
            this.createPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createPhone.Name = "createPhone";
            this.createPhone.Size = new System.Drawing.Size(212, 22);
            this.createPhone.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 464);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter phone number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 613);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createPhone);
            this.Controls.Add(this.createName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updPhone);
            this.Controls.Add(this.updName);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.getDataBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDataBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox updName;
        private System.Windows.Forms.TextBox updPhone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createName;
        private System.Windows.Forms.TextBox createPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

