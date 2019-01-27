namespace WxControl
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "wwwc ",
            "wwww",
            "www",
            "wwwwwwww"}, -1);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.skinPanel_Title = new CCWin.SkinControl.SkinPanel();
            this.skinLabel_Title = new CCWin.SkinControl.SkinLabel();
            this.skinTab_Main = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage_PhoneMap = new CCWin.SkinControl.SkinTabPage();
            this.skinPanel_PhoneMain = new CCWin.SkinControl.SkinPanel();
            this.skinCaptionPanel_Phone = new CCWin.SkinControl.SkinCaptionPanel();
            this.skinListView_Phone = new CCWin.SkinControl.SkinListView();
            this.columnHeader_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinTabPage_Main = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_Location = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_Plan = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage_Setting = new CCWin.SkinControl.SkinTabPage();
            this.skinPanel_Title.SuspendLayout();
            this.skinTab_Main.SuspendLayout();
            this.skinTabPage_PhoneMap.SuspendLayout();
            this.skinCaptionPanel_Phone.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "onebit_01.png");
            this.imageList1.Images.SetKeyName(1, "onebit_09.png");
            this.imageList1.Images.SetKeyName(2, "onebit_12.png");
            this.imageList1.Images.SetKeyName(3, "onebit_16.png");
            this.imageList1.Images.SetKeyName(4, "onebit_17.png");
            this.imageList1.Images.SetKeyName(5, "onebit_19.png");
            this.imageList1.Images.SetKeyName(6, "onebit_37.png");
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(4, 600);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(1053, 22);
            this.statusStrip_Main.TabIndex = 4;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // skinPanel_Title
            // 
            this.skinPanel_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel_Title.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_Title.BackgroundImage = global::WxControl.Properties.Resources.welcome1;
            this.skinPanel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinPanel_Title.Controls.Add(this.skinLabel_Title);
            this.skinPanel_Title.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Title.DownBack = null;
            this.skinPanel_Title.Location = new System.Drawing.Point(818, 34);
            this.skinPanel_Title.MouseBack = null;
            this.skinPanel_Title.Name = "skinPanel_Title";
            this.skinPanel_Title.NormlBack = null;
            this.skinPanel_Title.Size = new System.Drawing.Size(237, 60);
            this.skinPanel_Title.TabIndex = 3;
            // 
            // skinLabel_Title
            // 
            this.skinLabel_Title.AutoSize = true;
            this.skinLabel_Title.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_Title.BorderColor = System.Drawing.Color.White;
            this.skinLabel_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_Title.ForeColor = System.Drawing.Color.Maroon;
            this.skinLabel_Title.Location = new System.Drawing.Point(82, 21);
            this.skinLabel_Title.Name = "skinLabel_Title";
            this.skinLabel_Title.Size = new System.Drawing.Size(106, 22);
            this.skinLabel_Title.TabIndex = 0;
            this.skinLabel_Title.Text = "聚火群控系统";
            // 
            // skinTab_Main
            // 
            this.skinTab_Main.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTab_Main.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTab_Main.Controls.Add(this.skinTabPage_PhoneMap);
            this.skinTab_Main.Controls.Add(this.skinTabPage_Main);
            this.skinTab_Main.Controls.Add(this.skinTabPage_Location);
            this.skinTab_Main.Controls.Add(this.skinTabPage_Plan);
            this.skinTab_Main.Controls.Add(this.skinTabPage_Setting);
            this.skinTab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTab_Main.HeadBack = null;
            this.skinTab_Main.ImageList = this.imageList1;
            this.skinTab_Main.ImgSize = new System.Drawing.Size(48, 48);
            this.skinTab_Main.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTab_Main.ItemSize = new System.Drawing.Size(75, 75);
            this.skinTab_Main.Location = new System.Drawing.Point(4, 28);
            this.skinTab_Main.Name = "skinTab_Main";
            this.skinTab_Main.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTab_Main.PageArrowDown")));
            this.skinTab_Main.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTab_Main.PageArrowHover")));
            this.skinTab_Main.PageBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinTab_Main.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTab_Main.PageCloseHover")));
            this.skinTab_Main.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTab_Main.PageCloseNormal")));
            this.skinTab_Main.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTab_Main.PageDown")));
            this.skinTab_Main.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTab_Main.PageHover")));
            this.skinTab_Main.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTab_Main.PageNorml = null;
            this.skinTab_Main.PageTextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinTab_Main.SelectedIndex = 0;
            this.skinTab_Main.Size = new System.Drawing.Size(1053, 572);
            this.skinTab_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTab_Main.TabIndex = 0;
            this.skinTab_Main.SelectedIndexChanged += new System.EventHandler(this.skinTab_Main_SelectedIndexChanged);
            // 
            // skinTabPage_PhoneMap
            // 
            this.skinTabPage_PhoneMap.BackColor = System.Drawing.Color.White;
            this.skinTabPage_PhoneMap.Controls.Add(this.skinPanel_PhoneMain);
            this.skinTabPage_PhoneMap.Controls.Add(this.skinCaptionPanel_Phone);
            this.skinTabPage_PhoneMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_PhoneMap.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_PhoneMap.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_PhoneMap.ImageIndex = 2;
            this.skinTabPage_PhoneMap.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_PhoneMap.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_PhoneMap.Name = "skinTabPage_PhoneMap";
            this.skinTabPage_PhoneMap.Size = new System.Drawing.Size(1053, 497);
            this.skinTabPage_PhoneMap.TabIndex = 0;
            this.skinTabPage_PhoneMap.TabItemImage = null;
            this.skinTabPage_PhoneMap.Text = "手机映射";
            // 
            // skinPanel_PhoneMain
            // 
            this.skinPanel_PhoneMain.AutoScroll = true;
            this.skinPanel_PhoneMain.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_PhoneMain.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_PhoneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel_PhoneMain.DownBack = null;
            this.skinPanel_PhoneMain.ForeColor = System.Drawing.Color.Black;
            this.skinPanel_PhoneMain.Location = new System.Drawing.Point(247, 0);
            this.skinPanel_PhoneMain.MouseBack = null;
            this.skinPanel_PhoneMain.Name = "skinPanel_PhoneMain";
            this.skinPanel_PhoneMain.NormlBack = null;
            this.skinPanel_PhoneMain.Size = new System.Drawing.Size(806, 497);
            this.skinPanel_PhoneMain.TabIndex = 1;
            // 
            // skinCaptionPanel_Phone
            // 
            this.skinCaptionPanel_Phone.BackColor = System.Drawing.Color.White;
            this.skinCaptionPanel_Phone.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.skinCaptionPanel_Phone.Controls.Add(this.skinListView_Phone);
            this.skinCaptionPanel_Phone.Dock = System.Windows.Forms.DockStyle.Left;
            this.skinCaptionPanel_Phone.ForeColor = System.Drawing.Color.White;
            this.skinCaptionPanel_Phone.Image = global::WxControl.Properties.Resources.smartphone_iphone;
            this.skinCaptionPanel_Phone.Location = new System.Drawing.Point(0, 0);
            this.skinCaptionPanel_Phone.Name = "skinCaptionPanel_Phone";
            this.skinCaptionPanel_Phone.ShowBorder = true;
            this.skinCaptionPanel_Phone.Size = new System.Drawing.Size(247, 497);
            this.skinCaptionPanel_Phone.TabIndex = 0;
            this.skinCaptionPanel_Phone.Text = "手机列表";
            // 
            // skinListView_Phone
            // 
            this.skinListView_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinListView_Phone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Id,
            this.columnHeader_Group,
            this.columnHeader_Mark});
            this.skinListView_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinListView_Phone.GridLines = true;
            this.skinListView_Phone.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.skinListView_Phone.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.skinListView_Phone.Location = new System.Drawing.Point(2, 24);
            this.skinListView_Phone.MultiSelect = false;
            this.skinListView_Phone.Name = "skinListView_Phone";
            this.skinListView_Phone.OwnerDraw = true;
            this.skinListView_Phone.Size = new System.Drawing.Size(243, 471);
            this.skinListView_Phone.TabIndex = 0;
            this.skinListView_Phone.UseCompatibleStateImageBehavior = false;
            this.skinListView_Phone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Id
            // 
            this.columnHeader_Id.Text = "ID";
            // 
            // columnHeader_Group
            // 
            this.columnHeader_Group.Text = "分组";
            this.columnHeader_Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Group.Width = 90;
            // 
            // columnHeader_Mark
            // 
            this.columnHeader_Mark.Text = "备注";
            this.columnHeader_Mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Mark.Width = 90;
            // 
            // skinTabPage_Main
            // 
            this.skinTabPage_Main.BackColor = System.Drawing.Color.White;
            this.skinTabPage_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Main.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Main.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Main.ImageIndex = 0;
            this.skinTabPage_Main.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Main.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Main.Name = "skinTabPage_Main";
            this.skinTabPage_Main.Size = new System.Drawing.Size(1053, 497);
            this.skinTabPage_Main.TabIndex = 1;
            this.skinTabPage_Main.TabItemImage = null;
            this.skinTabPage_Main.Text = "群控主页";
            // 
            // skinTabPage_Location
            // 
            this.skinTabPage_Location.BackColor = System.Drawing.Color.White;
            this.skinTabPage_Location.BorderColor = System.Drawing.Color.White;
            this.skinTabPage_Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Location.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Location.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Location.ImageIndex = 5;
            this.skinTabPage_Location.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Location.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Location.Name = "skinTabPage_Location";
            this.skinTabPage_Location.Size = new System.Drawing.Size(1053, 497);
            this.skinTabPage_Location.TabIndex = 2;
            this.skinTabPage_Location.TabItemImage = null;
            this.skinTabPage_Location.Text = "模拟定位";
            // 
            // skinTabPage_Plan
            // 
            this.skinTabPage_Plan.BackColor = System.Drawing.Color.White;
            this.skinTabPage_Plan.BorderColor = System.Drawing.Color.White;
            this.skinTabPage_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Plan.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Plan.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Plan.ImageIndex = 3;
            this.skinTabPage_Plan.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Plan.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Plan.Name = "skinTabPage_Plan";
            this.skinTabPage_Plan.Size = new System.Drawing.Size(1053, 497);
            this.skinTabPage_Plan.TabIndex = 3;
            this.skinTabPage_Plan.TabItemImage = null;
            this.skinTabPage_Plan.Text = "计划任务";
            // 
            // skinTabPage_Setting
            // 
            this.skinTabPage_Setting.BackColor = System.Drawing.Color.White;
            this.skinTabPage_Setting.BorderColor = System.Drawing.Color.White;
            this.skinTabPage_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Setting.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Setting.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Setting.ImageIndex = 1;
            this.skinTabPage_Setting.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Setting.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Setting.Name = "skinTabPage_Setting";
            this.skinTabPage_Setting.Size = new System.Drawing.Size(1053, 497);
            this.skinTabPage_Setting.TabIndex = 4;
            this.skinTabPage_Setting.TabItemImage = null;
            this.skinTabPage_Setting.Text = "设置";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1061, 626);
            this.ControlBoxActive = System.Drawing.Color.LightGray;
            this.ControlBoxDeactive = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.skinPanel_Title);
            this.Controls.Add(this.skinTab_Main);
            this.Controls.Add(this.statusStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "聚火群控系统";
            this.skinPanel_Title.ResumeLayout(false);
            this.skinPanel_Title.PerformLayout();
            this.skinTab_Main.ResumeLayout(false);
            this.skinTabPage_PhoneMap.ResumeLayout(false);
            this.skinCaptionPanel_Phone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private CCWin.SkinControl.SkinPanel skinPanel_Title;
        private CCWin.SkinControl.SkinLabel skinLabel_Title;
        private CCWin.SkinControl.SkinTabControl skinTab_Main;
        private CCWin.SkinControl.SkinTabPage skinTabPage_PhoneMap;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel_Phone;
        private CCWin.SkinControl.SkinTabPage skinTabPage_Main;
        private CCWin.SkinControl.SkinTabPage skinTabPage_Location;
        private CCWin.SkinControl.SkinTabPage skinTabPage_Plan;
        private CCWin.SkinControl.SkinTabPage skinTabPage_Setting;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private CCWin.SkinControl.SkinListView skinListView_Phone;
        private System.Windows.Forms.ColumnHeader columnHeader_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_Group;
        private System.Windows.Forms.ColumnHeader columnHeader_Mark;
        private CCWin.SkinControl.SkinPanel skinPanel_PhoneMain;
    }
}

