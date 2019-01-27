namespace WxControl.Controls
{
    partial class PhoneControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_Phone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Phone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Phone
            // 
            this.pictureBox_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Phone.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Phone.Name = "pictureBox_Phone";
            this.pictureBox_Phone.Size = new System.Drawing.Size(132, 266);
            this.pictureBox_Phone.TabIndex = 0;
            this.pictureBox_Phone.TabStop = false;
            // 
            // PhoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_Phone);
            this.Name = "PhoneControl";
            this.Size = new System.Drawing.Size(132, 266);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Phone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Phone;
    }
}
