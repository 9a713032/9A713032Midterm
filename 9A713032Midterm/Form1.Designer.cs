
namespace _9A713032Midterm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.TextBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btndraw = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("新細明體", 40F);
            this.title.Location = new System.Drawing.Point(29, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(689, 64);
            this.title.TabIndex = 0;
            this.title.Text = "想不到吃甚麼嗎案一下就知道";
            // 
            // picResult
            // 
            this.picResult.Image = global::_9A713032Midterm.Properties.Resources.eat;
            this.picResult.Location = new System.Drawing.Point(29, 211);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(401, 285);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // btndraw
            // 
            this.btndraw.Font = new System.Drawing.Font("新細明體", 40F);
            this.btndraw.Location = new System.Drawing.Point(264, 119);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(266, 75);
            this.btndraw.TabIndex = 2;
            this.btndraw.Text = "按我!!";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // rtb
            // 
            this.rtb.Font = new System.Drawing.Font("新細明體", 12F);
            this.rtb.Location = new System.Drawing.Point(493, 211);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(225, 285);
            this.rtb.TabIndex = 3;
            this.rtb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 508);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

