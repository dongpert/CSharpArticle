namespace DiffStringAndStringBuilder
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnString = new System.Windows.Forms.Button();
            this.btnStringBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(12, 12);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(188, 50);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnStringBuilder
            // 
            this.btnStringBuilder.Location = new System.Drawing.Point(206, 12);
            this.btnStringBuilder.Name = "btnStringBuilder";
            this.btnStringBuilder.Size = new System.Drawing.Size(198, 50);
            this.btnStringBuilder.TabIndex = 1;
            this.btnStringBuilder.Text = "StringBuilder";
            this.btnStringBuilder.UseVisualStyleBackColor = true;
            this.btnStringBuilder.Click += new System.EventHandler(this.btnStringBuilder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 80);
            this.Controls.Add(this.btnStringBuilder);
            this.Controls.Add(this.btnString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnStringBuilder;
    }
}

