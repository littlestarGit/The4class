namespace The4class
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblA = new System.Windows.Forms.Label();
            this.lblop = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnJudge = new System.Windows.Forms.Button();
            this.listDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(48, 66);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(22, 24);
            this.lblA.TabIndex = 0;
            this.lblA.Text = " ";
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Location = new System.Drawing.Point(170, 65);
            this.lblop.Name = "lblop";
            this.lblop.Size = new System.Drawing.Size(22, 24);
            this.lblop.TabIndex = 1;
            this.lblop.Text = " ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(284, 65);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(34, 24);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(497, 62);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(182, 35);
            this.txtAnswer.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(140, 171);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 45);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "出题";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(452, 172);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(114, 44);
            this.btnJudge.TabIndex = 6;
            this.btnJudge.Text = "判分";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // listDisp
            // 
            this.listDisp.FormattingEnabled = true;
            this.listDisp.ItemHeight = 24;
            this.listDisp.Location = new System.Drawing.Point(73, 264);
            this.listDisp.Name = "listDisp";
            this.listDisp.Size = new System.Drawing.Size(668, 244);
            this.listDisp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 543);
            this.Controls.Add(this.listDisp);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblop);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblop;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.ListBox listDisp;
    }
}

