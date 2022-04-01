namespace Task1
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
            this.FixAllDateTimes = new System.Windows.Forms.Button();
            this.ID_POINT = new System.Windows.Forms.TextBox();
            this.ID_TYPE = new System.Windows.Forms.TextBox();
            this.LABEL_ID_POINT = new System.Windows.Forms.Label();
            this.LABEL_ID_TYPE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FixAllDateTimes
            // 
            this.FixAllDateTimes.Location = new System.Drawing.Point(63, 63);
            this.FixAllDateTimes.Name = "FixAllDateTimes";
            this.FixAllDateTimes.Size = new System.Drawing.Size(123, 23);
            this.FixAllDateTimes.TabIndex = 0;
            this.FixAllDateTimes.Text = "FixAllDateTimes";
            this.FixAllDateTimes.UseVisualStyleBackColor = true;
            this.FixAllDateTimes.Click += new System.EventHandler(this.FixAllDateTimes_Click);
            // 
            // ID_POINT
            // 
            this.ID_POINT.Location = new System.Drawing.Point(12, 25);
            this.ID_POINT.Name = "ID_POINT";
            this.ID_POINT.Size = new System.Drawing.Size(100, 20);
            this.ID_POINT.TabIndex = 1;
            this.ID_POINT.TextChanged += new System.EventHandler(this.ID_POINT_TextChanged);
            // 
            // ID_TYPE
            // 
            this.ID_TYPE.Location = new System.Drawing.Point(135, 25);
            this.ID_TYPE.Name = "ID_TYPE";
            this.ID_TYPE.Size = new System.Drawing.Size(100, 20);
            this.ID_TYPE.TabIndex = 2;
            this.ID_TYPE.TextChanged += new System.EventHandler(this.ID_TYPE_TextChanged);
            // 
            // LABEL_ID_POINT
            // 
            this.LABEL_ID_POINT.AutoSize = true;
            this.LABEL_ID_POINT.Location = new System.Drawing.Point(30, 6);
            this.LABEL_ID_POINT.Name = "LABEL_ID_POINT";
            this.LABEL_ID_POINT.Size = new System.Drawing.Size(57, 13);
            this.LABEL_ID_POINT.TabIndex = 3;
            this.LABEL_ID_POINT.Text = "ID_POINT";
            // 
            // LABEL_ID_TYPE
            // 
            this.LABEL_ID_TYPE.AutoSize = true;
            this.LABEL_ID_TYPE.Location = new System.Drawing.Point(155, 6);
            this.LABEL_ID_TYPE.Name = "LABEL_ID_TYPE";
            this.LABEL_ID_TYPE.Size = new System.Drawing.Size(52, 13);
            this.LABEL_ID_TYPE.TabIndex = 4;
            this.LABEL_ID_TYPE.Text = "ID_TYPE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 155);
            this.Controls.Add(this.LABEL_ID_TYPE);
            this.Controls.Add(this.LABEL_ID_POINT);
            this.Controls.Add(this.ID_TYPE);
            this.Controls.Add(this.ID_POINT);
            this.Controls.Add(this.FixAllDateTimes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FixAllDateTimes;
        private System.Windows.Forms.TextBox ID_POINT;
        private System.Windows.Forms.TextBox ID_TYPE;
        private System.Windows.Forms.Label LABEL_ID_POINT;
        private System.Windows.Forms.Label LABEL_ID_TYPE;
    }
}

