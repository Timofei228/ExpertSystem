namespace ExpertSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Quest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Rz = new System.Windows.Forms.ListBox();
            this.lb_Story = new System.Windows.Forms.ListBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Quest
            // 
            this.lbl_Quest.AutoSize = true;
            this.lbl_Quest.Location = new System.Drawing.Point(12, 21);
            this.lbl_Quest.Name = "lbl_Quest";
            this.lbl_Quest.Size = new System.Drawing.Size(56, 17);
            this.lbl_Quest.TabIndex = 0;
            this.lbl_Quest.Text = "Вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Варианты";
            // 
            // lb_Rz
            // 
            this.lb_Rz.FormattingEnabled = true;
            this.lb_Rz.ItemHeight = 16;
            this.lb_Rz.Location = new System.Drawing.Point(15, 93);
            this.lb_Rz.Name = "lb_Rz";
            this.lb_Rz.Size = new System.Drawing.Size(366, 164);
            this.lb_Rz.TabIndex = 2;
            this.lb_Rz.SelectedIndexChanged += new System.EventHandler(this.lb_Rz_SelectedIndexChanged);
            // 
            // lb_Story
            // 
            this.lb_Story.FormattingEnabled = true;
            this.lb_Story.ItemHeight = 16;
            this.lb_Story.Location = new System.Drawing.Point(438, 93);
            this.lb_Story.Name = "lb_Story";
            this.lb_Story.Size = new System.Drawing.Size(491, 164);
            this.lb_Story.TabIndex = 3;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(15, 276);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(188, 48);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Консультация";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "История ответов";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(810, 369);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 49);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(246, 276);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(135, 48);
            this.btn_select.TabIndex = 7;
            this.btn_select.Text = "Выбор";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ответ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 22);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lb_Story);
            this.Controls.Add(this.lb_Rz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Quest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Quest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_Rz;
        private System.Windows.Forms.ListBox lb_Story;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

