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
            this.columnHeader_HardId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinTabPage_Main = new CCWin.SkinControl.SkinTabPage();
            this.skinPanel_Main_Left = new CCWin.SkinControl.SkinPanel();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.listView_MainList = new System.Windows.Forms.ListView();
            this.columnHeader_Main_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Main_HardId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Main_CurCmd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Main_CurCmdStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Main_CmdDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Main_IsOnline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinPushPanel_Main_Right = new CCWin.SkinControl.SkinPushPanel();
            this.pushPanelItem_AddFriend = new CCWin.SkinControl.PushPanelItem();
            this.button_PassivityAddFriend = new System.Windows.Forms.Button();
            this.button_ImportContact = new System.Windows.Forms.Button();
            this.button__AddFriendByContact = new System.Windows.Forms.Button();
            this.button_AddFriendByCsv = new System.Windows.Forms.Button();
            this.button_AddFriendBySearch = new System.Windows.Forms.Button();
            this.pushPanelItem_GroupSend = new CCWin.SkinControl.PushPanelItem();
            this.button_GroupSendImgAndText = new System.Windows.Forms.Button();
            this.button_GroupSendImg = new System.Windows.Forms.Button();
            this.button_GroupSendText = new System.Windows.Forms.Button();
            this.pushPanelItem_NumberMgr = new CCWin.SkinControl.PushPanelItem();
            this.button_CSVFileMgr = new System.Windows.Forms.Button();
            this.button_TeleFileMgr = new System.Windows.Forms.Button();
            this.button_OutExport = new System.Windows.Forms.Button();
            this.pushPanelItem_ScriptMgr = new CCWin.SkinControl.PushPanelItem();
            this.button_CheckLuaGroup = new System.Windows.Forms.Button();
            this.button_UpdateLua = new System.Windows.Forms.Button();
            this.skinTabPage_Location = new CCWin.SkinControl.SkinTabPage();
            this.splitContainer_Simu = new System.Windows.Forms.SplitContainer();
            this.listView_SimuAddr = new System.Windows.Forms.ListView();
            this.columnHeader_Simu_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Simu_HardId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Simu_Longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Simu_Latidute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Simu_Addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinPushPanel_Simu = new CCWin.SkinControl.SkinPushPanel();
            this.pushPanelItem_SimuAddr = new CCWin.SkinControl.PushPanelItem();
            this.button_ClearSimuAddr = new System.Windows.Forms.Button();
            this.button_SimuAddr = new System.Windows.Forms.Button();
            this.pushPanelItem_NearByPerson = new CCWin.SkinControl.PushPanelItem();
            this.button_ClearNearbyPerson = new System.Windows.Forms.Button();
            this.button_AllowNearbyPerson = new System.Windows.Forms.Button();
            this.button_RefreshNearbyPerson = new System.Windows.Forms.Button();
            this.button_SayHiForNearbyPerson = new System.Windows.Forms.Button();
            this.skinTabPage_Friend = new CCWin.SkinControl.SkinTabPage();
            this.splitContainer_Friend = new System.Windows.Forms.SplitContainer();
            this.listView_Friend = new System.Windows.Forms.ListView();
            this.columnHeader_Friend_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Friend_HardId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Friend_Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinPanel_Friend = new CCWin.SkinControl.SkinPanel();
            this.groupBox_Friend_Text = new System.Windows.Forms.GroupBox();
            this.skinTextBox_Friend = new CCWin.SkinControl.SkinTextBox();
            this.skinPushPanel_Friend = new CCWin.SkinControl.SkinPushPanel();
            this.pushPanelItem_Friend = new CCWin.SkinControl.PushPanelItem();
            this.button_PublishFriend = new System.Windows.Forms.Button();
            this.skinTabPage_Plan = new CCWin.SkinControl.SkinTabPage();
            this.splitContainer_Task = new System.Windows.Forms.SplitContainer();
            this.listView_Plan_Phone = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinPushPanel_Plan = new CCWin.SkinControl.SkinPushPanel();
            this.pushPanelItem_Plan = new CCWin.SkinControl.PushPanelItem();
            this.button_DismisTask = new System.Windows.Forms.Button();
            this.pushPanelItem_ExportImportPlan = new CCWin.SkinControl.PushPanelItem();
            this.button_TimeTask = new System.Windows.Forms.Button();
            this.button_TimeTaskList = new System.Windows.Forms.Button();
            this.button_ExportTaskList = new System.Windows.Forms.Button();
            this.button_ImportTaskList = new System.Windows.Forms.Button();
            this.skinPanel_Plan = new CCWin.SkinControl.SkinPanel();
            this.listView_Plan_Task = new System.Windows.Forms.ListView();
            this.columnHeader_Task_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Task_HardId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Task_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Task_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Task_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Task_Detail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinPanel_Title.SuspendLayout();
            this.skinTab_Main.SuspendLayout();
            this.skinTabPage_PhoneMap.SuspendLayout();
            this.skinCaptionPanel_Phone.SuspendLayout();
            this.skinTabPage_Main.SuspendLayout();
            this.skinPanel_Main_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Main_Right)).BeginInit();
            this.skinPushPanel_Main_Right.SuspendLayout();
            this.pushPanelItem_AddFriend.SuspendLayout();
            this.pushPanelItem_GroupSend.SuspendLayout();
            this.pushPanelItem_NumberMgr.SuspendLayout();
            this.pushPanelItem_ScriptMgr.SuspendLayout();
            this.skinTabPage_Location.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Simu)).BeginInit();
            this.splitContainer_Simu.Panel1.SuspendLayout();
            this.splitContainer_Simu.Panel2.SuspendLayout();
            this.splitContainer_Simu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Simu)).BeginInit();
            this.skinPushPanel_Simu.SuspendLayout();
            this.pushPanelItem_SimuAddr.SuspendLayout();
            this.pushPanelItem_NearByPerson.SuspendLayout();
            this.skinTabPage_Friend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Friend)).BeginInit();
            this.splitContainer_Friend.Panel1.SuspendLayout();
            this.splitContainer_Friend.Panel2.SuspendLayout();
            this.splitContainer_Friend.SuspendLayout();
            this.skinPanel_Friend.SuspendLayout();
            this.groupBox_Friend_Text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Friend)).BeginInit();
            this.skinPushPanel_Friend.SuspendLayout();
            this.pushPanelItem_Friend.SuspendLayout();
            this.skinTabPage_Plan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Task)).BeginInit();
            this.splitContainer_Task.Panel1.SuspendLayout();
            this.splitContainer_Task.Panel2.SuspendLayout();
            this.splitContainer_Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Plan)).BeginInit();
            this.skinPushPanel_Plan.SuspendLayout();
            this.pushPanelItem_Plan.SuspendLayout();
            this.pushPanelItem_ExportImportPlan.SuspendLayout();
            this.skinPanel_Plan.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(7, "friend.png");
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(4, 760);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(1223, 22);
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
            this.skinPanel_Title.Location = new System.Drawing.Point(988, 34);
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
            this.skinTab_Main.Controls.Add(this.skinTabPage_Friend);
            this.skinTab_Main.Controls.Add(this.skinTabPage_Plan);
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
            this.skinTab_Main.SelectedIndex = 4;
            this.skinTab_Main.Size = new System.Drawing.Size(1223, 732);
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
            this.skinTabPage_PhoneMap.Size = new System.Drawing.Size(1074, 657);
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
            this.skinPanel_PhoneMain.Size = new System.Drawing.Size(827, 657);
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
            this.skinCaptionPanel_Phone.Size = new System.Drawing.Size(247, 657);
            this.skinCaptionPanel_Phone.TabIndex = 0;
            this.skinCaptionPanel_Phone.Text = "手机列表";
            // 
            // skinListView_Phone
            // 
            this.skinListView_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinListView_Phone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Id,
            this.columnHeader_HardId,
            this.columnHeader_Mark});
            this.skinListView_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinListView_Phone.GridLines = true;
            this.skinListView_Phone.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.skinListView_Phone.Location = new System.Drawing.Point(2, 24);
            this.skinListView_Phone.MultiSelect = false;
            this.skinListView_Phone.Name = "skinListView_Phone";
            this.skinListView_Phone.OwnerDraw = true;
            this.skinListView_Phone.Size = new System.Drawing.Size(243, 631);
            this.skinListView_Phone.TabIndex = 0;
            this.skinListView_Phone.UseCompatibleStateImageBehavior = false;
            this.skinListView_Phone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Id
            // 
            this.columnHeader_Id.Text = "ID";
            // 
            // columnHeader_HardId
            // 
            this.columnHeader_HardId.Text = "硬件ID";
            this.columnHeader_HardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_HardId.Width = 90;
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
            this.skinTabPage_Main.Controls.Add(this.skinPanel_Main_Left);
            this.skinTabPage_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Main.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Main.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Main.ImageIndex = 0;
            this.skinTabPage_Main.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Main.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Main.Name = "skinTabPage_Main";
            this.skinTabPage_Main.Size = new System.Drawing.Size(1223, 657);
            this.skinTabPage_Main.TabIndex = 1;
            this.skinTabPage_Main.TabItemImage = null;
            this.skinTabPage_Main.Text = "群控主页";
            // 
            // skinPanel_Main_Left
            // 
            this.skinPanel_Main_Left.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_Main_Left.Controls.Add(this.splitContainer_Main);
            this.skinPanel_Main_Left.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Main_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel_Main_Left.DownBack = null;
            this.skinPanel_Main_Left.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_Main_Left.MouseBack = null;
            this.skinPanel_Main_Left.Name = "skinPanel_Main_Left";
            this.skinPanel_Main_Left.NormlBack = null;
            this.skinPanel_Main_Left.Size = new System.Drawing.Size(1223, 657);
            this.skinPanel_Main_Left.TabIndex = 0;
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.listView_MainList);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.skinPushPanel_Main_Right);
            this.splitContainer_Main.Size = new System.Drawing.Size(1223, 657);
            this.splitContainer_Main.SplitterDistance = 994;
            this.splitContainer_Main.TabIndex = 0;
            // 
            // listView_MainList
            // 
            this.listView_MainList.CheckBoxes = true;
            this.listView_MainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Main_Id,
            this.columnHeader_Main_HardId,
            this.columnHeader_Main_CurCmd,
            this.columnHeader_Main_CurCmdStatus,
            this.columnHeader_Main_CmdDetail,
            this.columnHeader_Main_IsOnline});
            this.listView_MainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_MainList.FullRowSelect = true;
            this.listView_MainList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_MainList.Location = new System.Drawing.Point(0, 0);
            this.listView_MainList.MultiSelect = false;
            this.listView_MainList.Name = "listView_MainList";
            this.listView_MainList.Size = new System.Drawing.Size(994, 657);
            this.listView_MainList.TabIndex = 0;
            this.listView_MainList.UseCompatibleStateImageBehavior = false;
            this.listView_MainList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Main_Id
            // 
            this.columnHeader_Main_Id.Text = "ID";
            // 
            // columnHeader_Main_HardId
            // 
            this.columnHeader_Main_HardId.Text = "硬件ID";
            this.columnHeader_Main_HardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Main_HardId.Width = 120;
            // 
            // columnHeader_Main_CurCmd
            // 
            this.columnHeader_Main_CurCmd.Text = "当前命令";
            this.columnHeader_Main_CurCmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Main_CurCmd.Width = 160;
            // 
            // columnHeader_Main_CurCmdStatus
            // 
            this.columnHeader_Main_CurCmdStatus.Text = "当前命令状态";
            this.columnHeader_Main_CurCmdStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Main_CurCmdStatus.Width = 120;
            // 
            // columnHeader_Main_CmdDetail
            // 
            this.columnHeader_Main_CmdDetail.Text = "命令详细";
            this.columnHeader_Main_CmdDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Main_CmdDetail.Width = 260;
            // 
            // columnHeader_Main_IsOnline
            // 
            this.columnHeader_Main_IsOnline.Text = "是否在线";
            this.columnHeader_Main_IsOnline.Width = 120;
            // 
            // skinPushPanel_Main_Right
            // 
            this.skinPushPanel_Main_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPushPanel_Main_Right.Items.AddRange(new CCWin.SkinControl.PushPanelItem[] {
            this.pushPanelItem_AddFriend,
            this.pushPanelItem_GroupSend,
            this.pushPanelItem_NumberMgr,
            this.pushPanelItem_ScriptMgr});
            this.skinPushPanel_Main_Right.Location = new System.Drawing.Point(0, 0);
            this.skinPushPanel_Main_Right.Name = "skinPushPanel_Main_Right";
            this.skinPushPanel_Main_Right.Size = new System.Drawing.Size(225, 657);
            this.skinPushPanel_Main_Right.TabIndex = 0;
            // 
            // pushPanelItem_AddFriend
            // 
            this.pushPanelItem_AddFriend.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_AddFriend.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_AddFriend.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_AddFriend.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_AddFriend.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_AddFriend.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_AddFriend.Controls.Add(this.button_PassivityAddFriend);
            this.pushPanelItem_AddFriend.Controls.Add(this.button_ImportContact);
            this.pushPanelItem_AddFriend.Controls.Add(this.button__AddFriendByContact);
            this.pushPanelItem_AddFriend.Controls.Add(this.button_AddFriendByCsv);
            this.pushPanelItem_AddFriend.Controls.Add(this.button_AddFriendBySearch);
            this.pushPanelItem_AddFriend.Name = "pushPanelItem_AddFriend";
            this.pushPanelItem_AddFriend.Text = "添加好友";
            // 
            // button_PassivityAddFriend
            // 
            this.button_PassivityAddFriend.FlatAppearance.BorderSize = 0;
            this.button_PassivityAddFriend.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_PassivityAddFriend.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_PassivityAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PassivityAddFriend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_PassivityAddFriend.ForeColor = System.Drawing.Color.Black;
            this.button_PassivityAddFriend.Image = global::WxControl.Properties.Resources.brightness;
            this.button_PassivityAddFriend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_PassivityAddFriend.Location = new System.Drawing.Point(60, 459);
            this.button_PassivityAddFriend.Name = "button_PassivityAddFriend";
            this.button_PassivityAddFriend.Size = new System.Drawing.Size(112, 102);
            this.button_PassivityAddFriend.TabIndex = 9;
            this.button_PassivityAddFriend.Text = "通讯录被动添加";
            this.button_PassivityAddFriend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_PassivityAddFriend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_PassivityAddFriend.UseVisualStyleBackColor = true;
            // 
            // button_ImportContact
            // 
            this.button_ImportContact.FlatAppearance.BorderSize = 0;
            this.button_ImportContact.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_ImportContact.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ImportContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ImportContact.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ImportContact.ForeColor = System.Drawing.Color.Black;
            this.button_ImportContact.Image = global::WxControl.Properties.Resources.brightness;
            this.button_ImportContact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ImportContact.Location = new System.Drawing.Point(56, 351);
            this.button_ImportContact.Name = "button_ImportContact";
            this.button_ImportContact.Size = new System.Drawing.Size(112, 102);
            this.button_ImportContact.TabIndex = 8;
            this.button_ImportContact.Text = "导入通讯录";
            this.button_ImportContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ImportContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_ImportContact.UseVisualStyleBackColor = true;
            // 
            // button__AddFriendByContact
            // 
            this.button__AddFriendByContact.FlatAppearance.BorderSize = 0;
            this.button__AddFriendByContact.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button__AddFriendByContact.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button__AddFriendByContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__AddFriendByContact.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button__AddFriendByContact.ForeColor = System.Drawing.Color.Black;
            this.button__AddFriendByContact.Image = global::WxControl.Properties.Resources.brightness;
            this.button__AddFriendByContact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button__AddFriendByContact.Location = new System.Drawing.Point(56, 243);
            this.button__AddFriendByContact.Name = "button__AddFriendByContact";
            this.button__AddFriendByContact.Size = new System.Drawing.Size(112, 102);
            this.button__AddFriendByContact.TabIndex = 7;
            this.button__AddFriendByContact.Text = "通讯录添加好友";
            this.button__AddFriendByContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button__AddFriendByContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button__AddFriendByContact.UseVisualStyleBackColor = true;
            // 
            // button_AddFriendByCsv
            // 
            this.button_AddFriendByCsv.FlatAppearance.BorderSize = 0;
            this.button_AddFriendByCsv.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_AddFriendByCsv.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_AddFriendByCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddFriendByCsv.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AddFriendByCsv.ForeColor = System.Drawing.Color.Black;
            this.button_AddFriendByCsv.Image = global::WxControl.Properties.Resources.brightness;
            this.button_AddFriendByCsv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AddFriendByCsv.Location = new System.Drawing.Point(53, 135);
            this.button_AddFriendByCsv.Name = "button_AddFriendByCsv";
            this.button_AddFriendByCsv.Size = new System.Drawing.Size(112, 102);
            this.button_AddFriendByCsv.TabIndex = 6;
            this.button_AddFriendByCsv.Text = "CSV搜索添加好友";
            this.button_AddFriendByCsv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_AddFriendByCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_AddFriendByCsv.UseVisualStyleBackColor = true;
            // 
            // button_AddFriendBySearch
            // 
            this.button_AddFriendBySearch.FlatAppearance.BorderSize = 0;
            this.button_AddFriendBySearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_AddFriendBySearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_AddFriendBySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddFriendBySearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AddFriendBySearch.ForeColor = System.Drawing.Color.Black;
            this.button_AddFriendBySearch.Image = global::WxControl.Properties.Resources.brightness;
            this.button_AddFriendBySearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AddFriendBySearch.Location = new System.Drawing.Point(53, 27);
            this.button_AddFriendBySearch.Name = "button_AddFriendBySearch";
            this.button_AddFriendBySearch.Size = new System.Drawing.Size(112, 102);
            this.button_AddFriendBySearch.TabIndex = 5;
            this.button_AddFriendBySearch.Text = "搜索添加好友";
            this.button_AddFriendBySearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_AddFriendBySearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_AddFriendBySearch.UseVisualStyleBackColor = true;
            // 
            // pushPanelItem_GroupSend
            // 
            this.pushPanelItem_GroupSend.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_GroupSend.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_GroupSend.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_GroupSend.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_GroupSend.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_GroupSend.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_GroupSend.Controls.Add(this.button_GroupSendImgAndText);
            this.pushPanelItem_GroupSend.Controls.Add(this.button_GroupSendImg);
            this.pushPanelItem_GroupSend.Controls.Add(this.button_GroupSendText);
            this.pushPanelItem_GroupSend.Name = "pushPanelItem_GroupSend";
            this.pushPanelItem_GroupSend.Text = "群发信息";
            // 
            // button_GroupSendImgAndText
            // 
            this.button_GroupSendImgAndText.FlatAppearance.BorderSize = 0;
            this.button_GroupSendImgAndText.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_GroupSendImgAndText.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_GroupSendImgAndText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GroupSendImgAndText.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_GroupSendImgAndText.ForeColor = System.Drawing.Color.Black;
            this.button_GroupSendImgAndText.Image = global::WxControl.Properties.Resources.brightness;
            this.button_GroupSendImgAndText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_GroupSendImgAndText.Location = new System.Drawing.Point(49, 258);
            this.button_GroupSendImgAndText.Name = "button_GroupSendImgAndText";
            this.button_GroupSendImgAndText.Size = new System.Drawing.Size(124, 102);
            this.button_GroupSendImgAndText.TabIndex = 12;
            this.button_GroupSendImgAndText.Text = "图片文本信息群发";
            this.button_GroupSendImgAndText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_GroupSendImgAndText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_GroupSendImgAndText.UseVisualStyleBackColor = true;
            // 
            // button_GroupSendImg
            // 
            this.button_GroupSendImg.FlatAppearance.BorderSize = 0;
            this.button_GroupSendImg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_GroupSendImg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_GroupSendImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GroupSendImg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_GroupSendImg.ForeColor = System.Drawing.Color.Black;
            this.button_GroupSendImg.Image = global::WxControl.Properties.Resources.brightness;
            this.button_GroupSendImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_GroupSendImg.Location = new System.Drawing.Point(49, 150);
            this.button_GroupSendImg.Name = "button_GroupSendImg";
            this.button_GroupSendImg.Size = new System.Drawing.Size(124, 102);
            this.button_GroupSendImg.TabIndex = 11;
            this.button_GroupSendImg.Text = "图片信息群发";
            this.button_GroupSendImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_GroupSendImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_GroupSendImg.UseVisualStyleBackColor = true;
            // 
            // button_GroupSendText
            // 
            this.button_GroupSendText.FlatAppearance.BorderSize = 0;
            this.button_GroupSendText.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_GroupSendText.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_GroupSendText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GroupSendText.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_GroupSendText.ForeColor = System.Drawing.Color.Black;
            this.button_GroupSendText.Image = global::WxControl.Properties.Resources.brightness;
            this.button_GroupSendText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_GroupSendText.Location = new System.Drawing.Point(49, 41);
            this.button_GroupSendText.Name = "button_GroupSendText";
            this.button_GroupSendText.Size = new System.Drawing.Size(124, 102);
            this.button_GroupSendText.TabIndex = 10;
            this.button_GroupSendText.Text = "文本信息群发";
            this.button_GroupSendText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_GroupSendText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_GroupSendText.UseVisualStyleBackColor = true;
            // 
            // pushPanelItem_NumberMgr
            // 
            this.pushPanelItem_NumberMgr.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_NumberMgr.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_NumberMgr.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_NumberMgr.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_NumberMgr.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_NumberMgr.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_NumberMgr.Controls.Add(this.button_CSVFileMgr);
            this.pushPanelItem_NumberMgr.Controls.Add(this.button_TeleFileMgr);
            this.pushPanelItem_NumberMgr.Controls.Add(this.button_OutExport);
            this.pushPanelItem_NumberMgr.Name = "pushPanelItem_NumberMgr";
            this.pushPanelItem_NumberMgr.Text = "数据管理";
            // 
            // button_CSVFileMgr
            // 
            this.button_CSVFileMgr.FlatAppearance.BorderSize = 0;
            this.button_CSVFileMgr.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_CSVFileMgr.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_CSVFileMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CSVFileMgr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CSVFileMgr.ForeColor = System.Drawing.Color.Black;
            this.button_CSVFileMgr.Image = global::WxControl.Properties.Resources.brightness;
            this.button_CSVFileMgr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_CSVFileMgr.Location = new System.Drawing.Point(49, 246);
            this.button_CSVFileMgr.Name = "button_CSVFileMgr";
            this.button_CSVFileMgr.Size = new System.Drawing.Size(112, 102);
            this.button_CSVFileMgr.TabIndex = 13;
            this.button_CSVFileMgr.Text = "CSV号码库管理";
            this.button_CSVFileMgr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_CSVFileMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_CSVFileMgr.UseVisualStyleBackColor = true;
            // 
            // button_TeleFileMgr
            // 
            this.button_TeleFileMgr.FlatAppearance.BorderSize = 0;
            this.button_TeleFileMgr.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_TeleFileMgr.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_TeleFileMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TeleFileMgr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TeleFileMgr.ForeColor = System.Drawing.Color.Black;
            this.button_TeleFileMgr.Image = global::WxControl.Properties.Resources.brightness;
            this.button_TeleFileMgr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_TeleFileMgr.Location = new System.Drawing.Point(49, 138);
            this.button_TeleFileMgr.Name = "button_TeleFileMgr";
            this.button_TeleFileMgr.Size = new System.Drawing.Size(112, 102);
            this.button_TeleFileMgr.TabIndex = 12;
            this.button_TeleFileMgr.Text = "号码库管理";
            this.button_TeleFileMgr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_TeleFileMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_TeleFileMgr.UseVisualStyleBackColor = true;
            // 
            // button_OutExport
            // 
            this.button_OutExport.FlatAppearance.BorderSize = 0;
            this.button_OutExport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_OutExport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_OutExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OutExport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OutExport.ForeColor = System.Drawing.Color.Black;
            this.button_OutExport.Image = global::WxControl.Properties.Resources.brightness;
            this.button_OutExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_OutExport.Location = new System.Drawing.Point(49, 30);
            this.button_OutExport.Name = "button_OutExport";
            this.button_OutExport.Size = new System.Drawing.Size(112, 102);
            this.button_OutExport.TabIndex = 11;
            this.button_OutExport.Text = "导出设备ID";
            this.button_OutExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_OutExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_OutExport.UseVisualStyleBackColor = true;
            // 
            // pushPanelItem_ScriptMgr
            // 
            this.pushPanelItem_ScriptMgr.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_ScriptMgr.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_ScriptMgr.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_ScriptMgr.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_ScriptMgr.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_ScriptMgr.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_ScriptMgr.Controls.Add(this.button_CheckLuaGroup);
            this.pushPanelItem_ScriptMgr.Controls.Add(this.button_UpdateLua);
            this.pushPanelItem_ScriptMgr.Name = "pushPanelItem_ScriptMgr";
            this.pushPanelItem_ScriptMgr.Text = "脚本管理";
            // 
            // button_CheckLuaGroup
            // 
            this.button_CheckLuaGroup.FlatAppearance.BorderSize = 0;
            this.button_CheckLuaGroup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_CheckLuaGroup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_CheckLuaGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CheckLuaGroup.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CheckLuaGroup.ForeColor = System.Drawing.Color.Black;
            this.button_CheckLuaGroup.Image = global::WxControl.Properties.Resources.brightness;
            this.button_CheckLuaGroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_CheckLuaGroup.Location = new System.Drawing.Point(53, 142);
            this.button_CheckLuaGroup.Name = "button_CheckLuaGroup";
            this.button_CheckLuaGroup.Size = new System.Drawing.Size(112, 102);
            this.button_CheckLuaGroup.TabIndex = 13;
            this.button_CheckLuaGroup.Text = "检测手机脚本群";
            this.button_CheckLuaGroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_CheckLuaGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_CheckLuaGroup.UseVisualStyleBackColor = true;
            // 
            // button_UpdateLua
            // 
            this.button_UpdateLua.FlatAppearance.BorderSize = 0;
            this.button_UpdateLua.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_UpdateLua.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_UpdateLua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateLua.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_UpdateLua.ForeColor = System.Drawing.Color.Black;
            this.button_UpdateLua.Image = global::WxControl.Properties.Resources.brightness;
            this.button_UpdateLua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_UpdateLua.Location = new System.Drawing.Point(53, 34);
            this.button_UpdateLua.Name = "button_UpdateLua";
            this.button_UpdateLua.Size = new System.Drawing.Size(112, 102);
            this.button_UpdateLua.TabIndex = 12;
            this.button_UpdateLua.Text = "更新手机脚本";
            this.button_UpdateLua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_UpdateLua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_UpdateLua.UseVisualStyleBackColor = true;
            // 
            // skinTabPage_Location
            // 
            this.skinTabPage_Location.BackColor = System.Drawing.Color.White;
            this.skinTabPage_Location.BorderColor = System.Drawing.Color.White;
            this.skinTabPage_Location.Controls.Add(this.splitContainer_Simu);
            this.skinTabPage_Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Location.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Location.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Location.ImageIndex = 5;
            this.skinTabPage_Location.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Location.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Location.Name = "skinTabPage_Location";
            this.skinTabPage_Location.Size = new System.Drawing.Size(1223, 657);
            this.skinTabPage_Location.TabIndex = 2;
            this.skinTabPage_Location.TabItemImage = null;
            this.skinTabPage_Location.Text = "模拟定位";
            // 
            // splitContainer_Simu
            // 
            this.splitContainer_Simu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Simu.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Simu.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Simu.Name = "splitContainer_Simu";
            // 
            // splitContainer_Simu.Panel1
            // 
            this.splitContainer_Simu.Panel1.Controls.Add(this.listView_SimuAddr);
            // 
            // splitContainer_Simu.Panel2
            // 
            this.splitContainer_Simu.Panel2.Controls.Add(this.skinPushPanel_Simu);
            this.splitContainer_Simu.Size = new System.Drawing.Size(1223, 657);
            this.splitContainer_Simu.SplitterDistance = 992;
            this.splitContainer_Simu.TabIndex = 0;
            // 
            // listView_SimuAddr
            // 
            this.listView_SimuAddr.CheckBoxes = true;
            this.listView_SimuAddr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Simu_Id,
            this.columnHeader_Simu_HardId,
            this.columnHeader_Simu_Longitude,
            this.columnHeader_Simu_Latidute,
            this.columnHeader_Simu_Addr});
            this.listView_SimuAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_SimuAddr.FullRowSelect = true;
            this.listView_SimuAddr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_SimuAddr.Location = new System.Drawing.Point(0, 0);
            this.listView_SimuAddr.MultiSelect = false;
            this.listView_SimuAddr.Name = "listView_SimuAddr";
            this.listView_SimuAddr.Size = new System.Drawing.Size(992, 657);
            this.listView_SimuAddr.TabIndex = 1;
            this.listView_SimuAddr.UseCompatibleStateImageBehavior = false;
            this.listView_SimuAddr.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Simu_Id
            // 
            this.columnHeader_Simu_Id.Text = "ID";
            // 
            // columnHeader_Simu_HardId
            // 
            this.columnHeader_Simu_HardId.Text = "硬件ID";
            this.columnHeader_Simu_HardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Simu_HardId.Width = 120;
            // 
            // columnHeader_Simu_Longitude
            // 
            this.columnHeader_Simu_Longitude.Text = "经度";
            this.columnHeader_Simu_Longitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Simu_Longitude.Width = 160;
            // 
            // columnHeader_Simu_Latidute
            // 
            this.columnHeader_Simu_Latidute.Text = "纬度";
            this.columnHeader_Simu_Latidute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Simu_Latidute.Width = 120;
            // 
            // columnHeader_Simu_Addr
            // 
            this.columnHeader_Simu_Addr.Text = "地址";
            this.columnHeader_Simu_Addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Simu_Addr.Width = 370;
            // 
            // skinPushPanel_Simu
            // 
            this.skinPushPanel_Simu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPushPanel_Simu.Items.AddRange(new CCWin.SkinControl.PushPanelItem[] {
            this.pushPanelItem_SimuAddr,
            this.pushPanelItem_NearByPerson});
            this.skinPushPanel_Simu.Location = new System.Drawing.Point(0, 0);
            this.skinPushPanel_Simu.Name = "skinPushPanel_Simu";
            this.skinPushPanel_Simu.Size = new System.Drawing.Size(227, 657);
            this.skinPushPanel_Simu.TabIndex = 1;
            // 
            // pushPanelItem_SimuAddr
            // 
            this.pushPanelItem_SimuAddr.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_SimuAddr.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_SimuAddr.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_SimuAddr.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_SimuAddr.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_SimuAddr.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_SimuAddr.Controls.Add(this.button_ClearSimuAddr);
            this.pushPanelItem_SimuAddr.Controls.Add(this.button_SimuAddr);
            this.pushPanelItem_SimuAddr.Name = "pushPanelItem_SimuAddr";
            this.pushPanelItem_SimuAddr.Text = "模拟地址";
            // 
            // button_ClearSimuAddr
            // 
            this.button_ClearSimuAddr.FlatAppearance.BorderSize = 0;
            this.button_ClearSimuAddr.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_ClearSimuAddr.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ClearSimuAddr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearSimuAddr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClearSimuAddr.ForeColor = System.Drawing.Color.Black;
            this.button_ClearSimuAddr.Image = global::WxControl.Properties.Resources.brightness;
            this.button_ClearSimuAddr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ClearSimuAddr.Location = new System.Drawing.Point(53, 135);
            this.button_ClearSimuAddr.Name = "button_ClearSimuAddr";
            this.button_ClearSimuAddr.Size = new System.Drawing.Size(112, 102);
            this.button_ClearSimuAddr.TabIndex = 6;
            this.button_ClearSimuAddr.Text = "清理模拟地址";
            this.button_ClearSimuAddr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ClearSimuAddr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_ClearSimuAddr.UseVisualStyleBackColor = true;
            // 
            // button_SimuAddr
            // 
            this.button_SimuAddr.FlatAppearance.BorderSize = 0;
            this.button_SimuAddr.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_SimuAddr.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_SimuAddr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SimuAddr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SimuAddr.ForeColor = System.Drawing.Color.Black;
            this.button_SimuAddr.Image = global::WxControl.Properties.Resources.brightness;
            this.button_SimuAddr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_SimuAddr.Location = new System.Drawing.Point(53, 27);
            this.button_SimuAddr.Name = "button_SimuAddr";
            this.button_SimuAddr.Size = new System.Drawing.Size(112, 102);
            this.button_SimuAddr.TabIndex = 5;
            this.button_SimuAddr.Text = "模拟地址";
            this.button_SimuAddr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_SimuAddr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_SimuAddr.UseVisualStyleBackColor = true;
            // 
            // pushPanelItem_NearByPerson
            // 
            this.pushPanelItem_NearByPerson.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_NearByPerson.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_NearByPerson.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_NearByPerson.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_NearByPerson.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_NearByPerson.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_NearByPerson.Controls.Add(this.button_ClearNearbyPerson);
            this.pushPanelItem_NearByPerson.Controls.Add(this.button_AllowNearbyPerson);
            this.pushPanelItem_NearByPerson.Controls.Add(this.button_RefreshNearbyPerson);
            this.pushPanelItem_NearByPerson.Controls.Add(this.button_SayHiForNearbyPerson);
            this.pushPanelItem_NearByPerson.Name = "pushPanelItem_NearByPerson";
            this.pushPanelItem_NearByPerson.Text = "附近的人";
            // 
            // button_ClearNearbyPerson
            // 
            this.button_ClearNearbyPerson.FlatAppearance.BorderSize = 0;
            this.button_ClearNearbyPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_ClearNearbyPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ClearNearbyPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearNearbyPerson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClearNearbyPerson.ForeColor = System.Drawing.Color.Black;
            this.button_ClearNearbyPerson.Image = global::WxControl.Properties.Resources.brightness;
            this.button_ClearNearbyPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ClearNearbyPerson.Location = new System.Drawing.Point(53, 353);
            this.button_ClearNearbyPerson.Name = "button_ClearNearbyPerson";
            this.button_ClearNearbyPerson.Size = new System.Drawing.Size(124, 102);
            this.button_ClearNearbyPerson.TabIndex = 13;
            this.button_ClearNearbyPerson.Text = "清空附近人";
            this.button_ClearNearbyPerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ClearNearbyPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_ClearNearbyPerson.UseVisualStyleBackColor = true;
            // 
            // button_AllowNearbyPerson
            // 
            this.button_AllowNearbyPerson.FlatAppearance.BorderSize = 0;
            this.button_AllowNearbyPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_AllowNearbyPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_AllowNearbyPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AllowNearbyPerson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AllowNearbyPerson.ForeColor = System.Drawing.Color.Black;
            this.button_AllowNearbyPerson.Image = global::WxControl.Properties.Resources.brightness;
            this.button_AllowNearbyPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AllowNearbyPerson.Location = new System.Drawing.Point(49, 245);
            this.button_AllowNearbyPerson.Name = "button_AllowNearbyPerson";
            this.button_AllowNearbyPerson.Size = new System.Drawing.Size(124, 102);
            this.button_AllowNearbyPerson.TabIndex = 12;
            this.button_AllowNearbyPerson.Text = "批准附近人";
            this.button_AllowNearbyPerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_AllowNearbyPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_AllowNearbyPerson.UseVisualStyleBackColor = true;
            // 
            // button_RefreshNearbyPerson
            // 
            this.button_RefreshNearbyPerson.FlatAppearance.BorderSize = 0;
            this.button_RefreshNearbyPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_RefreshNearbyPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_RefreshNearbyPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RefreshNearbyPerson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_RefreshNearbyPerson.ForeColor = System.Drawing.Color.Black;
            this.button_RefreshNearbyPerson.Image = global::WxControl.Properties.Resources.brightness;
            this.button_RefreshNearbyPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_RefreshNearbyPerson.Location = new System.Drawing.Point(49, 137);
            this.button_RefreshNearbyPerson.Name = "button_RefreshNearbyPerson";
            this.button_RefreshNearbyPerson.Size = new System.Drawing.Size(124, 102);
            this.button_RefreshNearbyPerson.TabIndex = 11;
            this.button_RefreshNearbyPerson.Text = "刷新附近人";
            this.button_RefreshNearbyPerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_RefreshNearbyPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_RefreshNearbyPerson.UseVisualStyleBackColor = true;
            // 
            // button_SayHiForNearbyPerson
            // 
            this.button_SayHiForNearbyPerson.FlatAppearance.BorderSize = 0;
            this.button_SayHiForNearbyPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_SayHiForNearbyPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_SayHiForNearbyPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SayHiForNearbyPerson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SayHiForNearbyPerson.ForeColor = System.Drawing.Color.Black;
            this.button_SayHiForNearbyPerson.Image = global::WxControl.Properties.Resources.brightness;
            this.button_SayHiForNearbyPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_SayHiForNearbyPerson.Location = new System.Drawing.Point(49, 28);
            this.button_SayHiForNearbyPerson.Name = "button_SayHiForNearbyPerson";
            this.button_SayHiForNearbyPerson.Size = new System.Drawing.Size(124, 102);
            this.button_SayHiForNearbyPerson.TabIndex = 10;
            this.button_SayHiForNearbyPerson.Text = "喊话附近人";
            this.button_SayHiForNearbyPerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_SayHiForNearbyPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_SayHiForNearbyPerson.UseVisualStyleBackColor = true;
            // 
            // skinTabPage_Friend
            // 
            this.skinTabPage_Friend.BackColor = System.Drawing.Color.White;
            this.skinTabPage_Friend.BorderColor = System.Drawing.Color.White;
            this.skinTabPage_Friend.Controls.Add(this.splitContainer_Friend);
            this.skinTabPage_Friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Friend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Friend.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Friend.ImageIndex = 7;
            this.skinTabPage_Friend.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Friend.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Friend.Name = "skinTabPage_Friend";
            this.skinTabPage_Friend.Size = new System.Drawing.Size(1223, 657);
            this.skinTabPage_Friend.TabIndex = 4;
            this.skinTabPage_Friend.TabItemImage = null;
            this.skinTabPage_Friend.Text = "朋友圈";
            // 
            // splitContainer_Friend
            // 
            this.splitContainer_Friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Friend.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Friend.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Friend.Name = "splitContainer_Friend";
            // 
            // splitContainer_Friend.Panel1
            // 
            this.splitContainer_Friend.Panel1.Controls.Add(this.listView_Friend);
            // 
            // splitContainer_Friend.Panel2
            // 
            this.splitContainer_Friend.Panel2.Controls.Add(this.skinPanel_Friend);
            this.splitContainer_Friend.Panel2.Controls.Add(this.skinPushPanel_Friend);
            this.splitContainer_Friend.Size = new System.Drawing.Size(1223, 657);
            this.splitContainer_Friend.SplitterDistance = 306;
            this.splitContainer_Friend.TabIndex = 0;
            // 
            // listView_Friend
            // 
            this.listView_Friend.CheckBoxes = true;
            this.listView_Friend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Friend_Id,
            this.columnHeader_Friend_HardId,
            this.columnHeader_Friend_Mark});
            this.listView_Friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Friend.GridLines = true;
            this.listView_Friend.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Friend.Location = new System.Drawing.Point(0, 0);
            this.listView_Friend.MultiSelect = false;
            this.listView_Friend.Name = "listView_Friend";
            this.listView_Friend.Size = new System.Drawing.Size(306, 657);
            this.listView_Friend.TabIndex = 0;
            this.listView_Friend.UseCompatibleStateImageBehavior = false;
            this.listView_Friend.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Friend_Id
            // 
            this.columnHeader_Friend_Id.Text = "ID";
            // 
            // columnHeader_Friend_HardId
            // 
            this.columnHeader_Friend_HardId.Text = "硬件ID";
            this.columnHeader_Friend_HardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Friend_HardId.Width = 120;
            // 
            // columnHeader_Friend_Mark
            // 
            this.columnHeader_Friend_Mark.Text = "备注";
            this.columnHeader_Friend_Mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Friend_Mark.Width = 120;
            // 
            // skinPanel_Friend
            // 
            this.skinPanel_Friend.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_Friend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel_Friend.Controls.Add(this.groupBox_Friend_Text);
            this.skinPanel_Friend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel_Friend.DownBack = null;
            this.skinPanel_Friend.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_Friend.MouseBack = null;
            this.skinPanel_Friend.Name = "skinPanel_Friend";
            this.skinPanel_Friend.NormlBack = null;
            this.skinPanel_Friend.Size = new System.Drawing.Size(699, 657);
            this.skinPanel_Friend.TabIndex = 3;
            // 
            // groupBox_Friend_Text
            // 
            this.groupBox_Friend_Text.Controls.Add(this.skinTextBox_Friend);
            this.groupBox_Friend_Text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Friend_Text.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Friend_Text.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox_Friend_Text.Location = new System.Drawing.Point(0, 469);
            this.groupBox_Friend_Text.Name = "groupBox_Friend_Text";
            this.groupBox_Friend_Text.Size = new System.Drawing.Size(697, 186);
            this.groupBox_Friend_Text.TabIndex = 0;
            this.groupBox_Friend_Text.TabStop = false;
            this.groupBox_Friend_Text.Text = "朋友圈文本";
            // 
            // skinTextBox_Friend
            // 
            this.skinTextBox_Friend.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Friend.DownBack = null;
            this.skinTextBox_Friend.Icon = global::WxControl.Properties.Resources.friend;
            this.skinTextBox_Friend.IconIsButton = false;
            this.skinTextBox_Friend.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Friend.IsPasswordChat = '\0';
            this.skinTextBox_Friend.IsSystemPasswordChar = false;
            this.skinTextBox_Friend.Lines = new string[0];
            this.skinTextBox_Friend.Location = new System.Drawing.Point(3, 19);
            this.skinTextBox_Friend.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Friend.MaxLength = 32767;
            this.skinTextBox_Friend.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Friend.MouseBack = null;
            this.skinTextBox_Friend.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Friend.Multiline = true;
            this.skinTextBox_Friend.Name = "skinTextBox_Friend";
            this.skinTextBox_Friend.NormlBack = null;
            this.skinTextBox_Friend.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.skinTextBox_Friend.ReadOnly = false;
            this.skinTextBox_Friend.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Friend.Size = new System.Drawing.Size(691, 164);
            // 
            // 
            // 
            this.skinTextBox_Friend.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Friend.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Friend.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Friend.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Friend.SkinTxt.Multiline = true;
            this.skinTextBox_Friend.SkinTxt.Name = "BaseText";
            this.skinTextBox_Friend.SkinTxt.Size = new System.Drawing.Size(658, 154);
            this.skinTextBox_Friend.SkinTxt.TabIndex = 0;
            this.skinTextBox_Friend.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Friend.SkinTxt.WaterText = "";
            this.skinTextBox_Friend.TabIndex = 0;
            this.skinTextBox_Friend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Friend.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Friend.WaterText = "";
            this.skinTextBox_Friend.WordWrap = true;
            // 
            // skinPushPanel_Friend
            // 
            this.skinPushPanel_Friend.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinPushPanel_Friend.Items.AddRange(new CCWin.SkinControl.PushPanelItem[] {
            this.pushPanelItem_Friend});
            this.skinPushPanel_Friend.Location = new System.Drawing.Point(699, 0);
            this.skinPushPanel_Friend.Name = "skinPushPanel_Friend";
            this.skinPushPanel_Friend.Size = new System.Drawing.Size(214, 657);
            this.skinPushPanel_Friend.TabIndex = 2;
            // 
            // pushPanelItem_Friend
            // 
            this.pushPanelItem_Friend.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_Friend.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_Friend.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_Friend.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_Friend.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_Friend.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_Friend.Controls.Add(this.button_PublishFriend);
            this.pushPanelItem_Friend.ForeColor = System.Drawing.Color.White;
            this.pushPanelItem_Friend.Name = "pushPanelItem_Friend";
            this.pushPanelItem_Friend.Text = "朋友圈";
            // 
            // button_PublishFriend
            // 
            this.button_PublishFriend.FlatAppearance.BorderSize = 0;
            this.button_PublishFriend.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_PublishFriend.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_PublishFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PublishFriend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_PublishFriend.ForeColor = System.Drawing.Color.Black;
            this.button_PublishFriend.Image = global::WxControl.Properties.Resources.brightness;
            this.button_PublishFriend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_PublishFriend.Location = new System.Drawing.Point(53, 27);
            this.button_PublishFriend.Name = "button_PublishFriend";
            this.button_PublishFriend.Size = new System.Drawing.Size(112, 102);
            this.button_PublishFriend.TabIndex = 5;
            this.button_PublishFriend.Text = "发布朋友圈";
            this.button_PublishFriend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_PublishFriend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_PublishFriend.UseVisualStyleBackColor = true;
            // 
            // skinTabPage_Plan
            // 
            this.skinTabPage_Plan.BackColor = System.Drawing.Color.White;
            this.skinTabPage_Plan.BorderColor = System.Drawing.Color.White;
            this.skinTabPage_Plan.Controls.Add(this.splitContainer_Task);
            this.skinTabPage_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage_Plan.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage_Plan.ForeColor = System.Drawing.Color.White;
            this.skinTabPage_Plan.ImageIndex = 3;
            this.skinTabPage_Plan.Location = new System.Drawing.Point(0, 75);
            this.skinTabPage_Plan.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage_Plan.Name = "skinTabPage_Plan";
            this.skinTabPage_Plan.Size = new System.Drawing.Size(1223, 657);
            this.skinTabPage_Plan.TabIndex = 3;
            this.skinTabPage_Plan.TabItemImage = null;
            this.skinTabPage_Plan.Text = "计划任务";
            // 
            // splitContainer_Task
            // 
            this.splitContainer_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Task.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Task.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Task.Name = "splitContainer_Task";
            // 
            // splitContainer_Task.Panel1
            // 
            this.splitContainer_Task.Panel1.Controls.Add(this.listView_Plan_Phone);
            // 
            // splitContainer_Task.Panel2
            // 
            this.splitContainer_Task.Panel2.Controls.Add(this.skinPanel_Plan);
            this.splitContainer_Task.Panel2.Controls.Add(this.skinPushPanel_Plan);
            this.splitContainer_Task.Size = new System.Drawing.Size(1223, 657);
            this.splitContainer_Task.SplitterDistance = 304;
            this.splitContainer_Task.TabIndex = 0;
            // 
            // listView_Plan_Phone
            // 
            this.listView_Plan_Phone.CheckBoxes = true;
            this.listView_Plan_Phone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Plan_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Plan_Phone.GridLines = true;
            this.listView_Plan_Phone.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Plan_Phone.Location = new System.Drawing.Point(0, 0);
            this.listView_Plan_Phone.MultiSelect = false;
            this.listView_Plan_Phone.Name = "listView_Plan_Phone";
            this.listView_Plan_Phone.Size = new System.Drawing.Size(304, 657);
            this.listView_Plan_Phone.TabIndex = 1;
            this.listView_Plan_Phone.UseCompatibleStateImageBehavior = false;
            this.listView_Plan_Phone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "硬件ID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "备注";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // skinPushPanel_Plan
            // 
            this.skinPushPanel_Plan.Dock = System.Windows.Forms.DockStyle.Right;
            this.skinPushPanel_Plan.Items.AddRange(new CCWin.SkinControl.PushPanelItem[] {
            this.pushPanelItem_Plan,
            this.pushPanelItem_ExportImportPlan});
            this.skinPushPanel_Plan.Location = new System.Drawing.Point(701, 0);
            this.skinPushPanel_Plan.Name = "skinPushPanel_Plan";
            this.skinPushPanel_Plan.Size = new System.Drawing.Size(214, 657);
            this.skinPushPanel_Plan.TabIndex = 3;
            // 
            // pushPanelItem_Plan
            // 
            this.pushPanelItem_Plan.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_Plan.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_Plan.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_Plan.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_Plan.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_Plan.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_Plan.Controls.Add(this.button_TimeTaskList);
            this.pushPanelItem_Plan.Controls.Add(this.button_TimeTask);
            this.pushPanelItem_Plan.Controls.Add(this.button_DismisTask);
            this.pushPanelItem_Plan.ForeColor = System.Drawing.Color.White;
            this.pushPanelItem_Plan.Name = "pushPanelItem_Plan";
            this.pushPanelItem_Plan.Text = "任务系统";
            // 
            // button_DismisTask
            // 
            this.button_DismisTask.FlatAppearance.BorderSize = 0;
            this.button_DismisTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_DismisTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_DismisTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DismisTask.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DismisTask.ForeColor = System.Drawing.Color.Black;
            this.button_DismisTask.Image = global::WxControl.Properties.Resources.brightness;
            this.button_DismisTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_DismisTask.Location = new System.Drawing.Point(53, 27);
            this.button_DismisTask.Name = "button_DismisTask";
            this.button_DismisTask.Size = new System.Drawing.Size(112, 102);
            this.button_DismisTask.TabIndex = 5;
            this.button_DismisTask.Text = "撤销最新任务";
            this.button_DismisTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_DismisTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_DismisTask.UseVisualStyleBackColor = true;
            // 
            // pushPanelItem_ExportImportPlan
            // 
            this.pushPanelItem_ExportImportPlan.Border = System.Drawing.SystemColors.ControlDark;
            this.pushPanelItem_ExportImportPlan.CaptionBackHover = System.Drawing.SystemColors.ControlLight;
            this.pushPanelItem_ExportImportPlan.CaptionBackNormal = System.Drawing.SystemColors.ControlLightLight;
            this.pushPanelItem_ExportImportPlan.CaptionBackPressed = System.Drawing.SystemColors.ControlDarkDark;
            this.pushPanelItem_ExportImportPlan.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem_ExportImportPlan.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem_ExportImportPlan.Controls.Add(this.button_ImportTaskList);
            this.pushPanelItem_ExportImportPlan.Controls.Add(this.button_ExportTaskList);
            this.pushPanelItem_ExportImportPlan.Name = "pushPanelItem_ExportImportPlan";
            this.pushPanelItem_ExportImportPlan.Text = "导入导出任务";
            // 
            // button_TimeTask
            // 
            this.button_TimeTask.FlatAppearance.BorderSize = 0;
            this.button_TimeTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_TimeTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_TimeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimeTask.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TimeTask.ForeColor = System.Drawing.Color.Black;
            this.button_TimeTask.Image = global::WxControl.Properties.Resources.brightness;
            this.button_TimeTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_TimeTask.Location = new System.Drawing.Point(53, 135);
            this.button_TimeTask.Name = "button_TimeTask";
            this.button_TimeTask.Size = new System.Drawing.Size(112, 102);
            this.button_TimeTask.TabIndex = 6;
            this.button_TimeTask.Text = "发布定时任务";
            this.button_TimeTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_TimeTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_TimeTask.UseVisualStyleBackColor = true;
            // 
            // button_TimeTaskList
            // 
            this.button_TimeTaskList.FlatAppearance.BorderSize = 0;
            this.button_TimeTaskList.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_TimeTaskList.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_TimeTaskList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimeTaskList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TimeTaskList.ForeColor = System.Drawing.Color.Black;
            this.button_TimeTaskList.Image = global::WxControl.Properties.Resources.brightness;
            this.button_TimeTaskList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_TimeTaskList.Location = new System.Drawing.Point(53, 243);
            this.button_TimeTaskList.Name = "button_TimeTaskList";
            this.button_TimeTaskList.Size = new System.Drawing.Size(112, 102);
            this.button_TimeTaskList.TabIndex = 7;
            this.button_TimeTaskList.Text = "发布定时任务列表";
            this.button_TimeTaskList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_TimeTaskList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_TimeTaskList.UseVisualStyleBackColor = true;
            // 
            // button_ExportTaskList
            // 
            this.button_ExportTaskList.FlatAppearance.BorderSize = 0;
            this.button_ExportTaskList.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_ExportTaskList.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ExportTaskList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExportTaskList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ExportTaskList.ForeColor = System.Drawing.Color.Black;
            this.button_ExportTaskList.Image = global::WxControl.Properties.Resources.brightness;
            this.button_ExportTaskList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ExportTaskList.Location = new System.Drawing.Point(53, 27);
            this.button_ExportTaskList.Name = "button_ExportTaskList";
            this.button_ExportTaskList.Size = new System.Drawing.Size(112, 102);
            this.button_ExportTaskList.TabIndex = 6;
            this.button_ExportTaskList.Text = "导出定时任务";
            this.button_ExportTaskList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ExportTaskList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_ExportTaskList.UseVisualStyleBackColor = true;
            // 
            // button_ImportTaskList
            // 
            this.button_ImportTaskList.FlatAppearance.BorderSize = 0;
            this.button_ImportTaskList.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_ImportTaskList.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ImportTaskList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ImportTaskList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ImportTaskList.ForeColor = System.Drawing.Color.Black;
            this.button_ImportTaskList.Image = global::WxControl.Properties.Resources.brightness;
            this.button_ImportTaskList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ImportTaskList.Location = new System.Drawing.Point(53, 135);
            this.button_ImportTaskList.Name = "button_ImportTaskList";
            this.button_ImportTaskList.Size = new System.Drawing.Size(112, 102);
            this.button_ImportTaskList.TabIndex = 7;
            this.button_ImportTaskList.Text = "导入定时任务";
            this.button_ImportTaskList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ImportTaskList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_ImportTaskList.UseVisualStyleBackColor = true;
            // 
            // skinPanel_Plan
            // 
            this.skinPanel_Plan.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel_Plan.Controls.Add(this.listView_Plan_Task);
            this.skinPanel_Plan.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel_Plan.DownBack = null;
            this.skinPanel_Plan.Location = new System.Drawing.Point(0, 0);
            this.skinPanel_Plan.MouseBack = null;
            this.skinPanel_Plan.Name = "skinPanel_Plan";
            this.skinPanel_Plan.NormlBack = null;
            this.skinPanel_Plan.Size = new System.Drawing.Size(701, 657);
            this.skinPanel_Plan.TabIndex = 4;
            // 
            // listView_Plan_Task
            // 
            this.listView_Plan_Task.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Task_Id,
            this.columnHeader_Task_HardId,
            this.columnHeader_Task_Name,
            this.columnHeader_Task_Status,
            this.columnHeader_Task_Time,
            this.columnHeader_Task_Detail});
            this.listView_Plan_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Plan_Task.GridLines = true;
            this.listView_Plan_Task.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Plan_Task.Location = new System.Drawing.Point(0, 0);
            this.listView_Plan_Task.MultiSelect = false;
            this.listView_Plan_Task.Name = "listView_Plan_Task";
            this.listView_Plan_Task.Size = new System.Drawing.Size(701, 657);
            this.listView_Plan_Task.TabIndex = 2;
            this.listView_Plan_Task.UseCompatibleStateImageBehavior = false;
            this.listView_Plan_Task.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Task_Id
            // 
            this.columnHeader_Task_Id.Text = "ID";
            // 
            // columnHeader_Task_HardId
            // 
            this.columnHeader_Task_HardId.Text = "硬件ID";
            this.columnHeader_Task_HardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Task_HardId.Width = 120;
            // 
            // columnHeader_Task_Name
            // 
            this.columnHeader_Task_Name.Text = "任务名称";
            this.columnHeader_Task_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Task_Name.Width = 120;
            // 
            // columnHeader_Task_Status
            // 
            this.columnHeader_Task_Status.Text = "任务状态";
            this.columnHeader_Task_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Task_Status.Width = 120;
            // 
            // columnHeader_Task_Time
            // 
            this.columnHeader_Task_Time.Text = "任务时间";
            this.columnHeader_Task_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Task_Time.Width = 120;
            // 
            // columnHeader_Task_Detail
            // 
            this.columnHeader_Task_Detail.Text = "任务描述";
            this.columnHeader_Task_Detail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Task_Detail.Width = 150;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1231, 786);
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
            this.skinTabPage_Main.ResumeLayout(false);
            this.skinPanel_Main_Left.ResumeLayout(false);
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Main_Right)).EndInit();
            this.skinPushPanel_Main_Right.ResumeLayout(false);
            this.pushPanelItem_AddFriend.ResumeLayout(false);
            this.pushPanelItem_GroupSend.ResumeLayout(false);
            this.pushPanelItem_NumberMgr.ResumeLayout(false);
            this.pushPanelItem_ScriptMgr.ResumeLayout(false);
            this.skinTabPage_Location.ResumeLayout(false);
            this.splitContainer_Simu.Panel1.ResumeLayout(false);
            this.splitContainer_Simu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Simu)).EndInit();
            this.splitContainer_Simu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Simu)).EndInit();
            this.skinPushPanel_Simu.ResumeLayout(false);
            this.pushPanelItem_SimuAddr.ResumeLayout(false);
            this.pushPanelItem_NearByPerson.ResumeLayout(false);
            this.skinTabPage_Friend.ResumeLayout(false);
            this.splitContainer_Friend.Panel1.ResumeLayout(false);
            this.splitContainer_Friend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Friend)).EndInit();
            this.splitContainer_Friend.ResumeLayout(false);
            this.skinPanel_Friend.ResumeLayout(false);
            this.groupBox_Friend_Text.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Friend)).EndInit();
            this.skinPushPanel_Friend.ResumeLayout(false);
            this.pushPanelItem_Friend.ResumeLayout(false);
            this.skinTabPage_Plan.ResumeLayout(false);
            this.splitContainer_Task.Panel1.ResumeLayout(false);
            this.splitContainer_Task.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Task)).EndInit();
            this.splitContainer_Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel_Plan)).EndInit();
            this.skinPushPanel_Plan.ResumeLayout(false);
            this.pushPanelItem_Plan.ResumeLayout(false);
            this.pushPanelItem_ExportImportPlan.ResumeLayout(false);
            this.skinPanel_Plan.ResumeLayout(false);
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
        private CCWin.SkinControl.SkinTabPage skinTabPage_Friend;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private CCWin.SkinControl.SkinListView skinListView_Phone;
        private System.Windows.Forms.ColumnHeader columnHeader_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_HardId;
        private System.Windows.Forms.ColumnHeader columnHeader_Mark;
        private CCWin.SkinControl.SkinPanel skinPanel_PhoneMain;
        private CCWin.SkinControl.SkinPanel skinPanel_Main_Left;
        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.ListView listView_MainList;
        private System.Windows.Forms.ColumnHeader columnHeader_Main_Id;
        private CCWin.SkinControl.SkinPushPanel skinPushPanel_Main_Right;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_AddFriend;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_GroupSend;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_NumberMgr;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_ScriptMgr;
        private System.Windows.Forms.Button button_AddFriendBySearch;
        private System.Windows.Forms.Button button_AddFriendByCsv;
        private System.Windows.Forms.Button button__AddFriendByContact;
        private System.Windows.Forms.Button button_ImportContact;
        private System.Windows.Forms.Button button_PassivityAddFriend;
        private System.Windows.Forms.Button button_GroupSendText;
        private System.Windows.Forms.Button button_GroupSendImg;
        private System.Windows.Forms.Button button_GroupSendImgAndText;
        private System.Windows.Forms.Button button_OutExport;
        private System.Windows.Forms.Button button_TeleFileMgr;
        private System.Windows.Forms.Button button_CSVFileMgr;
        private System.Windows.Forms.Button button_UpdateLua;
        private System.Windows.Forms.Button button_CheckLuaGroup;
        private System.Windows.Forms.ColumnHeader columnHeader_Main_HardId;
        private System.Windows.Forms.ColumnHeader columnHeader_Main_CurCmd;
        private System.Windows.Forms.ColumnHeader columnHeader_Main_CurCmdStatus;
        private System.Windows.Forms.ColumnHeader columnHeader_Main_CmdDetail;
        private System.Windows.Forms.ColumnHeader columnHeader_Main_IsOnline;
        private System.Windows.Forms.SplitContainer splitContainer_Simu;
        private System.Windows.Forms.ListView listView_SimuAddr;
        private System.Windows.Forms.ColumnHeader columnHeader_Simu_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_Simu_HardId;
        private System.Windows.Forms.ColumnHeader columnHeader_Simu_Longitude;
        private System.Windows.Forms.ColumnHeader columnHeader_Simu_Latidute;
        private System.Windows.Forms.ColumnHeader columnHeader_Simu_Addr;
        private CCWin.SkinControl.SkinPushPanel skinPushPanel_Simu;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_SimuAddr;
        private System.Windows.Forms.Button button_ClearSimuAddr;
        private System.Windows.Forms.Button button_SimuAddr;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_NearByPerson;
        private System.Windows.Forms.Button button_AllowNearbyPerson;
        private System.Windows.Forms.Button button_RefreshNearbyPerson;
        private System.Windows.Forms.Button button_SayHiForNearbyPerson;
        private System.Windows.Forms.Button button_ClearNearbyPerson;
        private System.Windows.Forms.SplitContainer splitContainer_Friend;
        private System.Windows.Forms.ListView listView_Friend;
        private System.Windows.Forms.ColumnHeader columnHeader_Friend_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_Friend_HardId;
        private System.Windows.Forms.ColumnHeader columnHeader_Friend_Mark;
        private CCWin.SkinControl.SkinPushPanel skinPushPanel_Friend;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_Friend;
        private System.Windows.Forms.Button button_PublishFriend;
        private CCWin.SkinControl.SkinPanel skinPanel_Friend;
        private System.Windows.Forms.GroupBox groupBox_Friend_Text;
        private CCWin.SkinControl.SkinTextBox skinTextBox_Friend;
        private System.Windows.Forms.SplitContainer splitContainer_Task;
        private System.Windows.Forms.ListView listView_Plan_Phone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private CCWin.SkinControl.SkinPushPanel skinPushPanel_Plan;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_Plan;
        private System.Windows.Forms.Button button_DismisTask;
        private CCWin.SkinControl.PushPanelItem pushPanelItem_ExportImportPlan;
        private System.Windows.Forms.Button button_TimeTask;
        private System.Windows.Forms.Button button_TimeTaskList;
        private System.Windows.Forms.Button button_ExportTaskList;
        private System.Windows.Forms.Button button_ImportTaskList;
        private CCWin.SkinControl.SkinPanel skinPanel_Plan;
        private System.Windows.Forms.ListView listView_Plan_Task;
        private System.Windows.Forms.ColumnHeader columnHeader_Task_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_Task_HardId;
        private System.Windows.Forms.ColumnHeader columnHeader_Task_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Task_Status;
        private System.Windows.Forms.ColumnHeader columnHeader_Task_Time;
        private System.Windows.Forms.ColumnHeader columnHeader_Task_Detail;
    }
}

