namespace TrainLcd
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.txbProjectFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProjectRead = new System.Windows.Forms.Button();
            this.btnStartTrainLcd = new System.Windows.Forms.Button();
            this.btnOpenFD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbProjectFilePath
            // 
            this.txbProjectFilePath.Location = new System.Drawing.Point(12, 67);
            this.txbProjectFilePath.Name = "txbProjectFilePath";
            this.txbProjectFilePath.Size = new System.Drawing.Size(564, 24);
            this.txbProjectFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "プロジェクトのパス";
            // 
            // btnProjectRead
            // 
            this.btnProjectRead.Location = new System.Drawing.Point(469, 427);
            this.btnProjectRead.Name = "btnProjectRead";
            this.btnProjectRead.Size = new System.Drawing.Size(76, 34);
            this.btnProjectRead.TabIndex = 2;
            this.btnProjectRead.Text = "読み込み";
            this.btnProjectRead.UseVisualStyleBackColor = true;
            // 
            // btnStartTrainLcd
            // 
            this.btnStartTrainLcd.Location = new System.Drawing.Point(551, 427);
            this.btnStartTrainLcd.Name = "btnStartTrainLcd";
            this.btnStartTrainLcd.Size = new System.Drawing.Size(75, 34);
            this.btnStartTrainLcd.TabIndex = 3;
            this.btnStartTrainLcd.Text = "スタート";
            this.btnStartTrainLcd.UseVisualStyleBackColor = true;
            this.btnStartTrainLcd.Click += new System.EventHandler(this.btnStartTrainLcd_Click);
            // 
            // btnOpenFD
            // 
            this.btnOpenFD.Location = new System.Drawing.Point(582, 67);
            this.btnOpenFD.Name = "btnOpenFD";
            this.btnOpenFD.Size = new System.Drawing.Size(44, 24);
            this.btnOpenFD.TabIndex = 2;
            this.btnOpenFD.Text = "...";
            this.btnOpenFD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 473);
            this.Controls.Add(this.btnStartTrainLcd);
            this.Controls.Add(this.btnOpenFD);
            this.Controls.Add(this.btnProjectRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbProjectFilePath);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProjectFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProjectRead;
        private System.Windows.Forms.Button btnOpenFD;
        public System.Windows.Forms.Button btnStartTrainLcd;
    }
}

