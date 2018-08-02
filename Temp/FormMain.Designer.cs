namespace Temp
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_BView = new System.Windows.Forms.TabPage();
            this.panel_control = new System.Windows.Forms.Panel();
            this.checkBox_afterINT = new System.Windows.Forms.CheckBox();
            this.checkBox_beforeINT = new System.Windows.Forms.CheckBox();
            this.button_fullScreen = new System.Windows.Forms.Button();
            this.button_cancelFullScreen = new System.Windows.Forms.Button();
            this.label_la_m_dm_yard = new System.Windows.Forms.Label();
            this.label_la_km_mile_2 = new System.Windows.Forms.Label();
            this.label_la_km_mile_1 = new System.Windows.Forms.Label();
            this.textBox_num_km_mile_2 = new System.Windows.Forms.TextBox();
            this.textBox_num_m_dm_yard = new System.Windows.Forms.TextBox();
            this.textBox_num_km_mile_1 = new System.Windows.Forms.TextBox();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_littleRound = new System.Windows.Forms.Button();
            this.button_bigRound = new System.Windows.Forms.Button();
            this.button_less = new System.Windows.Forms.Button();
            this.button_more = new System.Windows.Forms.Button();
            this.textBox_playSpeedingSpinner = new System.Windows.Forms.TextBox();
            this.textBox_periodSpinner = new System.Windows.Forms.TextBox();
            this.trackBar_playSpeedingSlider = new System.Windows.Forms.TrackBar();
            this.trackBar_periodSlider = new System.Windows.Forms.TrackBar();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.trackBar_slider = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_infos = new System.Windows.Forms.TabControl();
            this.tabPage_info = new System.Windows.Forms.TabPage();
            this.tabPage_AData = new System.Windows.Forms.TabPage();
            this.tabPage_summary = new System.Windows.Forms.TabPage();
            this.tabPage_gpsTrack = new System.Windows.Forms.TabPage();
            this.panel_BViewCommand = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel_chooserFile = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_file1 = new System.Windows.Forms.RadioButton();
            this.radioButton_file2 = new System.Windows.Forms.RadioButton();
            this.radioButton_doubleB = new System.Windows.Forms.RadioButton();
            this.button_unlock = new System.Windows.Forms.Button();
            this.button_lock = new System.Windows.Forms.Button();
            this.button_damageReport = new System.Windows.Forms.Button();
            this.button_playbackAdmin = new System.Windows.Forms.Button();
            this.button_playSet = new System.Windows.Forms.Button();
            this.button_contrastPlay = new System.Windows.Forms.Button();
            this.button_dataMaintain = new System.Windows.Forms.Button();
            this.button_dataTable = new System.Windows.Forms.Button();
            this.button_magnifierDisplay = new System.Windows.Forms.Button();
            this.button_labelSearch = new System.Windows.Forms.Button();
            this.button_showTable = new System.Windows.Forms.Button();
            this.button_AILable = new System.Windows.Forms.Button();
            this.button_softwareScreenshot = new System.Windows.Forms.Button();
            this.flowLayoutPanel_singSelect = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_basicData = new System.Windows.Forms.RadioButton();
            this.radioButton_AViewData = new System.Windows.Forms.RadioButton();
            this.radioButton_runningData = new System.Windows.Forms.RadioButton();
            this.radioButton_gpsTrack = new System.Windows.Forms.RadioButton();
            this.button_openFile = new System.Windows.Forms.Button();
            this.tabPage_dataQuery = new System.Windows.Forms.TabPage();
            this.tabPage_reportQuery = new System.Windows.Forms.TabPage();
            this.tabPage_systemSetting = new System.Windows.Forms.TabPage();
            this.notifyIcon_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_mainNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_maximize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_recover = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ucbViewControl = new Temp.UC.UCBViewControl();
            this.ucBasicInfo = new Temp.UC.UCBasicInfo();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_BView.SuspendLayout();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_playSpeedingSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_periodSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_slider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl_infos.SuspendLayout();
            this.tabPage_info.SuspendLayout();
            this.panel_BViewCommand.SuspendLayout();
            this.flowLayoutPanel_chooserFile.SuspendLayout();
            this.flowLayoutPanel_singSelect.SuspendLayout();
            this.contextMenuStrip_mainNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_BView);
            this.tabControl_Main.Controls.Add(this.tabPage_dataQuery);
            this.tabControl_Main.Controls.Add(this.tabPage_reportQuery);
            this.tabControl_Main.Controls.Add(this.tabPage_systemSetting);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1264, 681);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_BView
            // 
            this.tabPage_BView.Controls.Add(this.ucbViewControl);
            this.tabPage_BView.Controls.Add(this.panel_control);
            this.tabPage_BView.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_BView.Controls.Add(this.panel_BViewCommand);
            this.tabPage_BView.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BView.Name = "tabPage_BView";
            this.tabPage_BView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BView.Size = new System.Drawing.Size(1256, 655);
            this.tabPage_BView.TabIndex = 0;
            this.tabPage_BView.Text = "B显数据";
            this.tabPage_BView.UseVisualStyleBackColor = true;
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.checkBox_afterINT);
            this.panel_control.Controls.Add(this.checkBox_beforeINT);
            this.panel_control.Controls.Add(this.button_fullScreen);
            this.panel_control.Controls.Add(this.button_cancelFullScreen);
            this.panel_control.Controls.Add(this.label_la_m_dm_yard);
            this.panel_control.Controls.Add(this.label_la_km_mile_2);
            this.panel_control.Controls.Add(this.label_la_km_mile_1);
            this.panel_control.Controls.Add(this.textBox_num_km_mile_2);
            this.panel_control.Controls.Add(this.textBox_num_m_dm_yard);
            this.panel_control.Controls.Add(this.textBox_num_km_mile_1);
            this.panel_control.Controls.Add(this.button_right);
            this.panel_control.Controls.Add(this.button_left);
            this.panel_control.Controls.Add(this.button_littleRound);
            this.panel_control.Controls.Add(this.button_bigRound);
            this.panel_control.Controls.Add(this.button_less);
            this.panel_control.Controls.Add(this.button_more);
            this.panel_control.Controls.Add(this.textBox_playSpeedingSpinner);
            this.panel_control.Controls.Add(this.textBox_periodSpinner);
            this.panel_control.Controls.Add(this.trackBar_playSpeedingSlider);
            this.panel_control.Controls.Add(this.trackBar_periodSlider);
            this.panel_control.Controls.Add(this.button_play);
            this.panel_control.Controls.Add(this.button_stop);
            this.panel_control.Controls.Add(this.trackBar_slider);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_control.Location = new System.Drawing.Point(3, 277);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(1250, 100);
            this.panel_control.TabIndex = 0;
            // 
            // checkBox_afterINT
            // 
            this.checkBox_afterINT.AutoSize = true;
            this.checkBox_afterINT.Location = new System.Drawing.Point(1163, 62);
            this.checkBox_afterINT.Name = "checkBox_afterINT";
            this.checkBox_afterINT.Size = new System.Drawing.Size(60, 16);
            this.checkBox_afterINT.TabIndex = 41;
            this.checkBox_afterINT.Text = "中断后";
            this.checkBox_afterINT.UseVisualStyleBackColor = true;
            // 
            // checkBox_beforeINT
            // 
            this.checkBox_beforeINT.AutoSize = true;
            this.checkBox_beforeINT.Location = new System.Drawing.Point(1163, 26);
            this.checkBox_beforeINT.Name = "checkBox_beforeINT";
            this.checkBox_beforeINT.Size = new System.Drawing.Size(60, 16);
            this.checkBox_beforeINT.TabIndex = 40;
            this.checkBox_beforeINT.Text = "中断前";
            this.checkBox_beforeINT.UseVisualStyleBackColor = true;
            // 
            // button_fullScreen
            // 
            this.button_fullScreen.Location = new System.Drawing.Point(1082, 18);
            this.button_fullScreen.Name = "button_fullScreen";
            this.button_fullScreen.Size = new System.Drawing.Size(75, 30);
            this.button_fullScreen.TabIndex = 38;
            this.button_fullScreen.Text = "全屏";
            this.button_fullScreen.UseVisualStyleBackColor = true;
            // 
            // button_cancelFullScreen
            // 
            this.button_cancelFullScreen.Location = new System.Drawing.Point(1082, 54);
            this.button_cancelFullScreen.Name = "button_cancelFullScreen";
            this.button_cancelFullScreen.Size = new System.Drawing.Size(75, 30);
            this.button_cancelFullScreen.TabIndex = 39;
            this.button_cancelFullScreen.Text = "取消全屏";
            this.button_cancelFullScreen.UseVisualStyleBackColor = true;
            // 
            // label_la_m_dm_yard
            // 
            this.label_la_m_dm_yard.AutoSize = true;
            this.label_la_m_dm_yard.Location = new System.Drawing.Point(1048, 69);
            this.label_la_m_dm_yard.Name = "label_la_m_dm_yard";
            this.label_la_m_dm_yard.Size = new System.Drawing.Size(17, 12);
            this.label_la_m_dm_yard.TabIndex = 0;
            this.label_la_m_dm_yard.Text = "ya";
            // 
            // label_la_km_mile_2
            // 
            this.label_la_km_mile_2.AutoSize = true;
            this.label_la_km_mile_2.Location = new System.Drawing.Point(1048, 42);
            this.label_la_km_mile_2.Name = "label_la_km_mile_2";
            this.label_la_km_mile_2.Size = new System.Drawing.Size(17, 12);
            this.label_la_km_mile_2.TabIndex = 0;
            this.label_la_km_mile_2.Text = "km";
            // 
            // label_la_km_mile_1
            // 
            this.label_la_km_mile_1.AutoSize = true;
            this.label_la_km_mile_1.Location = new System.Drawing.Point(1048, 15);
            this.label_la_km_mile_1.Name = "label_la_km_mile_1";
            this.label_la_km_mile_1.Size = new System.Drawing.Size(17, 12);
            this.label_la_km_mile_1.TabIndex = 0;
            this.label_la_km_mile_1.Text = "km";
            // 
            // textBox_num_km_mile_2
            // 
            this.textBox_num_km_mile_2.Location = new System.Drawing.Point(913, 39);
            this.textBox_num_km_mile_2.Name = "textBox_num_km_mile_2";
            this.textBox_num_km_mile_2.Size = new System.Drawing.Size(129, 21);
            this.textBox_num_km_mile_2.TabIndex = 36;
            // 
            // textBox_num_m_dm_yard
            // 
            this.textBox_num_m_dm_yard.Location = new System.Drawing.Point(913, 66);
            this.textBox_num_m_dm_yard.Name = "textBox_num_m_dm_yard";
            this.textBox_num_m_dm_yard.Size = new System.Drawing.Size(129, 21);
            this.textBox_num_m_dm_yard.TabIndex = 37;
            // 
            // textBox_num_km_mile_1
            // 
            this.textBox_num_km_mile_1.Location = new System.Drawing.Point(913, 12);
            this.textBox_num_km_mile_1.Name = "textBox_num_km_mile_1";
            this.textBox_num_km_mile_1.Size = new System.Drawing.Size(129, 21);
            this.textBox_num_km_mile_1.TabIndex = 35;
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(421, 18);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 30);
            this.button_right.TabIndex = 32;
            this.button_right.Text = "右";
            this.button_right.UseVisualStyleBackColor = true;
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(421, 54);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 30);
            this.button_left.TabIndex = 33;
            this.button_left.Text = "左";
            this.button_left.UseVisualStyleBackColor = true;
            // 
            // button_littleRound
            // 
            this.button_littleRound.Location = new System.Drawing.Point(344, 54);
            this.button_littleRound.Name = "button_littleRound";
            this.button_littleRound.Size = new System.Drawing.Size(75, 30);
            this.button_littleRound.TabIndex = 31;
            this.button_littleRound.Text = "缩小";
            this.button_littleRound.UseVisualStyleBackColor = true;
            // 
            // button_bigRound
            // 
            this.button_bigRound.Location = new System.Drawing.Point(344, 18);
            this.button_bigRound.Name = "button_bigRound";
            this.button_bigRound.Size = new System.Drawing.Size(75, 30);
            this.button_bigRound.TabIndex = 30;
            this.button_bigRound.Text = "放大";
            this.button_bigRound.UseVisualStyleBackColor = true;
            // 
            // button_less
            // 
            this.button_less.Location = new System.Drawing.Point(263, 54);
            this.button_less.Name = "button_less";
            this.button_less.Size = new System.Drawing.Size(75, 30);
            this.button_less.TabIndex = 29;
            this.button_less.Text = "下一屏";
            this.button_less.UseVisualStyleBackColor = true;
            // 
            // button_more
            // 
            this.button_more.Location = new System.Drawing.Point(263, 18);
            this.button_more.Name = "button_more";
            this.button_more.Size = new System.Drawing.Size(75, 30);
            this.button_more.TabIndex = 28;
            this.button_more.Text = "上一屏";
            this.button_more.UseVisualStyleBackColor = true;
            // 
            // textBox_playSpeedingSpinner
            // 
            this.textBox_playSpeedingSpinner.Location = new System.Drawing.Point(203, 65);
            this.textBox_playSpeedingSpinner.Name = "textBox_playSpeedingSpinner";
            this.textBox_playSpeedingSpinner.Size = new System.Drawing.Size(45, 21);
            this.textBox_playSpeedingSpinner.TabIndex = 27;
            this.textBox_playSpeedingSpinner.Text = "1";
            // 
            // textBox_periodSpinner
            // 
            this.textBox_periodSpinner.Location = new System.Drawing.Point(203, 19);
            this.textBox_periodSpinner.Name = "textBox_periodSpinner";
            this.textBox_periodSpinner.Size = new System.Drawing.Size(45, 21);
            this.textBox_periodSpinner.TabIndex = 26;
            this.textBox_periodSpinner.Text = "10";
            // 
            // trackBar_playSpeedingSlider
            // 
            this.trackBar_playSpeedingSlider.AutoSize = false;
            this.trackBar_playSpeedingSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_playSpeedingSlider.Location = new System.Drawing.Point(51, 62);
            this.trackBar_playSpeedingSlider.Maximum = 1500;
            this.trackBar_playSpeedingSlider.Minimum = 1;
            this.trackBar_playSpeedingSlider.Name = "trackBar_playSpeedingSlider";
            this.trackBar_playSpeedingSlider.Size = new System.Drawing.Size(146, 25);
            this.trackBar_playSpeedingSlider.TabIndex = 25;
            this.trackBar_playSpeedingSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_playSpeedingSlider.Value = 1;
            // 
            // trackBar_periodSlider
            // 
            this.trackBar_periodSlider.AutoSize = false;
            this.trackBar_periodSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_periodSlider.Location = new System.Drawing.Point(51, 16);
            this.trackBar_periodSlider.Maximum = 100;
            this.trackBar_periodSlider.Name = "trackBar_periodSlider";
            this.trackBar_periodSlider.Size = new System.Drawing.Size(146, 25);
            this.trackBar_periodSlider.TabIndex = 24;
            this.trackBar_periodSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_periodSlider.Value = 10;
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(5, 8);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(40, 40);
            this.button_play.TabIndex = 22;
            this.button_play.Text = "播放";
            this.button_play.UseVisualStyleBackColor = true;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(5, 54);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(40, 40);
            this.button_stop.TabIndex = 23;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // trackBar_slider
            // 
            this.trackBar_slider.AutoSize = false;
            this.trackBar_slider.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_slider.Location = new System.Drawing.Point(502, 30);
            this.trackBar_slider.Maximum = 100;
            this.trackBar_slider.Name = "trackBar_slider";
            this.trackBar_slider.Size = new System.Drawing.Size(405, 40);
            this.trackBar_slider.TabIndex = 34;
            this.trackBar_slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_slider.Value = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.28F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl_infos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 377);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl_infos
            // 
            this.tabControl_infos.Controls.Add(this.tabPage_info);
            this.tabControl_infos.Controls.Add(this.tabPage_AData);
            this.tabControl_infos.Controls.Add(this.tabPage_summary);
            this.tabControl_infos.Controls.Add(this.tabPage_gpsTrack);
            this.tabControl_infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_infos.Location = new System.Drawing.Point(3, 3);
            this.tabControl_infos.Name = "tabControl_infos";
            this.tabControl_infos.SelectedIndex = 0;
            this.tabControl_infos.Size = new System.Drawing.Size(509, 269);
            this.tabControl_infos.TabIndex = 0;
            // 
            // tabPage_info
            // 
            this.tabPage_info.Controls.Add(this.ucBasicInfo);
            this.tabPage_info.Location = new System.Drawing.Point(4, 22);
            this.tabPage_info.Name = "tabPage_info";
            this.tabPage_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_info.Size = new System.Drawing.Size(501, 243);
            this.tabPage_info.TabIndex = 0;
            this.tabPage_info.Text = "基本信息";
            this.tabPage_info.UseVisualStyleBackColor = true;
            // 
            // tabPage_AData
            // 
            this.tabPage_AData.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AData.Name = "tabPage_AData";
            this.tabPage_AData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AData.Size = new System.Drawing.Size(501, 243);
            this.tabPage_AData.TabIndex = 1;
            this.tabPage_AData.Text = "A型显示";
            this.tabPage_AData.UseVisualStyleBackColor = true;
            // 
            // tabPage_summary
            // 
            this.tabPage_summary.Location = new System.Drawing.Point(4, 22);
            this.tabPage_summary.Name = "tabPage_summary";
            this.tabPage_summary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_summary.Size = new System.Drawing.Size(501, 243);
            this.tabPage_summary.TabIndex = 2;
            this.tabPage_summary.Text = "作业概况";
            this.tabPage_summary.UseVisualStyleBackColor = true;
            // 
            // tabPage_gpsTrack
            // 
            this.tabPage_gpsTrack.Location = new System.Drawing.Point(4, 22);
            this.tabPage_gpsTrack.Name = "tabPage_gpsTrack";
            this.tabPage_gpsTrack.Size = new System.Drawing.Size(501, 243);
            this.tabPage_gpsTrack.TabIndex = 0;
            this.tabPage_gpsTrack.Text = "GPS轨迹";
            this.tabPage_gpsTrack.UseVisualStyleBackColor = true;
            // 
            // panel_BViewCommand
            // 
            this.panel_BViewCommand.Controls.Add(this.button_exit);
            this.panel_BViewCommand.Controls.Add(this.flowLayoutPanel_chooserFile);
            this.panel_BViewCommand.Controls.Add(this.button_unlock);
            this.panel_BViewCommand.Controls.Add(this.button_lock);
            this.panel_BViewCommand.Controls.Add(this.button_damageReport);
            this.panel_BViewCommand.Controls.Add(this.button_playbackAdmin);
            this.panel_BViewCommand.Controls.Add(this.button_playSet);
            this.panel_BViewCommand.Controls.Add(this.button_contrastPlay);
            this.panel_BViewCommand.Controls.Add(this.button_dataMaintain);
            this.panel_BViewCommand.Controls.Add(this.button_dataTable);
            this.panel_BViewCommand.Controls.Add(this.button_magnifierDisplay);
            this.panel_BViewCommand.Controls.Add(this.button_labelSearch);
            this.panel_BViewCommand.Controls.Add(this.button_showTable);
            this.panel_BViewCommand.Controls.Add(this.button_AILable);
            this.panel_BViewCommand.Controls.Add(this.button_softwareScreenshot);
            this.panel_BViewCommand.Controls.Add(this.flowLayoutPanel_singSelect);
            this.panel_BViewCommand.Controls.Add(this.button_openFile);
            this.panel_BViewCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BViewCommand.Location = new System.Drawing.Point(3, 3);
            this.panel_BViewCommand.Name = "panel_BViewCommand";
            this.panel_BViewCommand.Size = new System.Drawing.Size(1250, 70);
            this.panel_BViewCommand.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(1200, 15);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(40, 40);
            this.button_exit.TabIndex = 21;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_chooserFile
            // 
            this.flowLayoutPanel_chooserFile.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_chooserFile.Controls.Add(this.radioButton_file1);
            this.flowLayoutPanel_chooserFile.Controls.Add(this.radioButton_file2);
            this.flowLayoutPanel_chooserFile.Controls.Add(this.radioButton_doubleB);
            this.flowLayoutPanel_chooserFile.Location = new System.Drawing.Point(885, 12);
            this.flowLayoutPanel_chooserFile.Name = "flowLayoutPanel_chooserFile";
            this.flowLayoutPanel_chooserFile.Size = new System.Drawing.Size(217, 45);
            this.flowLayoutPanel_chooserFile.TabIndex = 0;
            // 
            // radioButton_file1
            // 
            this.radioButton_file1.AutoSize = true;
            this.radioButton_file1.Location = new System.Drawing.Point(10, 15);
            this.radioButton_file1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.radioButton_file1.Name = "radioButton_file1";
            this.radioButton_file1.Size = new System.Drawing.Size(59, 16);
            this.radioButton_file1.TabIndex = 16;
            this.radioButton_file1.TabStop = true;
            this.radioButton_file1.Text = "主文件";
            this.radioButton_file1.UseVisualStyleBackColor = true;
            // 
            // radioButton_file2
            // 
            this.radioButton_file2.AutoSize = true;
            this.radioButton_file2.Location = new System.Drawing.Point(79, 15);
            this.radioButton_file2.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.radioButton_file2.Name = "radioButton_file2";
            this.radioButton_file2.Size = new System.Drawing.Size(59, 16);
            this.radioButton_file2.TabIndex = 17;
            this.radioButton_file2.TabStop = true;
            this.radioButton_file2.Text = "从文件";
            this.radioButton_file2.UseVisualStyleBackColor = true;
            // 
            // radioButton_doubleB
            // 
            this.radioButton_doubleB.AutoSize = true;
            this.radioButton_doubleB.Location = new System.Drawing.Point(148, 15);
            this.radioButton_doubleB.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.radioButton_doubleB.Name = "radioButton_doubleB";
            this.radioButton_doubleB.Size = new System.Drawing.Size(59, 16);
            this.radioButton_doubleB.TabIndex = 18;
            this.radioButton_doubleB.TabStop = true;
            this.radioButton_doubleB.Text = "双显示";
            this.radioButton_doubleB.UseVisualStyleBackColor = true;
            // 
            // button_unlock
            // 
            this.button_unlock.Location = new System.Drawing.Point(1154, 15);
            this.button_unlock.Name = "button_unlock";
            this.button_unlock.Size = new System.Drawing.Size(40, 40);
            this.button_unlock.TabIndex = 20;
            this.button_unlock.Text = "解锁";
            this.button_unlock.UseVisualStyleBackColor = true;
            // 
            // button_lock
            // 
            this.button_lock.Location = new System.Drawing.Point(1108, 15);
            this.button_lock.Name = "button_lock";
            this.button_lock.Size = new System.Drawing.Size(40, 40);
            this.button_lock.TabIndex = 19;
            this.button_lock.Text = "锁定";
            this.button_lock.UseVisualStyleBackColor = true;
            // 
            // button_damageReport
            // 
            this.button_damageReport.Location = new System.Drawing.Point(655, 15);
            this.button_damageReport.Name = "button_damageReport";
            this.button_damageReport.Size = new System.Drawing.Size(40, 40);
            this.button_damageReport.TabIndex = 11;
            this.button_damageReport.Text = "伤损报告";
            this.button_damageReport.UseVisualStyleBackColor = true;
            // 
            // button_playbackAdmin
            // 
            this.button_playbackAdmin.Location = new System.Drawing.Point(701, 15);
            this.button_playbackAdmin.Name = "button_playbackAdmin";
            this.button_playbackAdmin.Size = new System.Drawing.Size(40, 40);
            this.button_playbackAdmin.TabIndex = 12;
            this.button_playbackAdmin.Text = "回放管理";
            this.button_playbackAdmin.UseVisualStyleBackColor = true;
            // 
            // button_playSet
            // 
            this.button_playSet.Location = new System.Drawing.Point(839, 15);
            this.button_playSet.Name = "button_playSet";
            this.button_playSet.Size = new System.Drawing.Size(40, 40);
            this.button_playSet.TabIndex = 15;
            this.button_playSet.Text = "播放设置";
            this.button_playSet.UseVisualStyleBackColor = true;
            // 
            // button_contrastPlay
            // 
            this.button_contrastPlay.Location = new System.Drawing.Point(747, 15);
            this.button_contrastPlay.Name = "button_contrastPlay";
            this.button_contrastPlay.Size = new System.Drawing.Size(40, 40);
            this.button_contrastPlay.TabIndex = 13;
            this.button_contrastPlay.Text = "对比播放文件选择";
            this.button_contrastPlay.UseVisualStyleBackColor = true;
            // 
            // button_dataMaintain
            // 
            this.button_dataMaintain.Location = new System.Drawing.Point(793, 15);
            this.button_dataMaintain.Name = "button_dataMaintain";
            this.button_dataMaintain.Size = new System.Drawing.Size(40, 40);
            this.button_dataMaintain.TabIndex = 14;
            this.button_dataMaintain.Text = "数据维护";
            this.button_dataMaintain.UseVisualStyleBackColor = true;
            // 
            // button_dataTable
            // 
            this.button_dataTable.Location = new System.Drawing.Point(379, 15);
            this.button_dataTable.Name = "button_dataTable";
            this.button_dataTable.Size = new System.Drawing.Size(40, 40);
            this.button_dataTable.TabIndex = 5;
            this.button_dataTable.Text = "参数图表";
            this.button_dataTable.UseVisualStyleBackColor = true;
            // 
            // button_magnifierDisplay
            // 
            this.button_magnifierDisplay.Location = new System.Drawing.Point(425, 15);
            this.button_magnifierDisplay.Name = "button_magnifierDisplay";
            this.button_magnifierDisplay.Size = new System.Drawing.Size(40, 40);
            this.button_magnifierDisplay.TabIndex = 6;
            this.button_magnifierDisplay.Text = "放大显示";
            this.button_magnifierDisplay.UseVisualStyleBackColor = true;
            // 
            // button_labelSearch
            // 
            this.button_labelSearch.Location = new System.Drawing.Point(471, 15);
            this.button_labelSearch.Name = "button_labelSearch";
            this.button_labelSearch.Size = new System.Drawing.Size(40, 40);
            this.button_labelSearch.TabIndex = 7;
            this.button_labelSearch.Text = "标注查找";
            this.button_labelSearch.UseVisualStyleBackColor = true;
            // 
            // button_showTable
            // 
            this.button_showTable.Location = new System.Drawing.Point(563, 15);
            this.button_showTable.Name = "button_showTable";
            this.button_showTable.Size = new System.Drawing.Size(40, 40);
            this.button_showTable.TabIndex = 9;
            this.button_showTable.Text = "疑似图表";
            this.button_showTable.UseVisualStyleBackColor = true;
            // 
            // button_AILable
            // 
            this.button_AILable.Location = new System.Drawing.Point(517, 15);
            this.button_AILable.Name = "button_AILable";
            this.button_AILable.Size = new System.Drawing.Size(40, 40);
            this.button_AILable.TabIndex = 8;
            this.button_AILable.Text = "智能分析";
            this.button_AILable.UseVisualStyleBackColor = true;
            // 
            // button_softwareScreenshot
            // 
            this.button_softwareScreenshot.Location = new System.Drawing.Point(609, 15);
            this.button_softwareScreenshot.Name = "button_softwareScreenshot";
            this.button_softwareScreenshot.Size = new System.Drawing.Size(40, 40);
            this.button_softwareScreenshot.TabIndex = 10;
            this.button_softwareScreenshot.Text = "软件截图";
            this.button_softwareScreenshot.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_singSelect
            // 
            this.flowLayoutPanel_singSelect.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_singSelect.Controls.Add(this.radioButton_basicData);
            this.flowLayoutPanel_singSelect.Controls.Add(this.radioButton_AViewData);
            this.flowLayoutPanel_singSelect.Controls.Add(this.radioButton_runningData);
            this.flowLayoutPanel_singSelect.Controls.Add(this.radioButton_gpsTrack);
            this.flowLayoutPanel_singSelect.Location = new System.Drawing.Point(51, 12);
            this.flowLayoutPanel_singSelect.Name = "flowLayoutPanel_singSelect";
            this.flowLayoutPanel_singSelect.Size = new System.Drawing.Size(322, 45);
            this.flowLayoutPanel_singSelect.TabIndex = 0;
            // 
            // radioButton_basicData
            // 
            this.radioButton_basicData.AutoSize = true;
            this.radioButton_basicData.Location = new System.Drawing.Point(10, 15);
            this.radioButton_basicData.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.radioButton_basicData.Name = "radioButton_basicData";
            this.radioButton_basicData.Size = new System.Drawing.Size(71, 16);
            this.radioButton_basicData.TabIndex = 2;
            this.radioButton_basicData.TabStop = true;
            this.radioButton_basicData.Text = "作业信息";
            this.radioButton_basicData.UseVisualStyleBackColor = true;
            // 
            // radioButton_AViewData
            // 
            this.radioButton_AViewData.AutoSize = true;
            this.radioButton_AViewData.Location = new System.Drawing.Point(91, 15);
            this.radioButton_AViewData.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.radioButton_AViewData.Name = "radioButton_AViewData";
            this.radioButton_AViewData.Size = new System.Drawing.Size(65, 16);
            this.radioButton_AViewData.TabIndex = 2;
            this.radioButton_AViewData.TabStop = true;
            this.radioButton_AViewData.Text = "A型显示";
            this.radioButton_AViewData.UseVisualStyleBackColor = true;
            // 
            // radioButton_runningData
            // 
            this.radioButton_runningData.AutoSize = true;
            this.radioButton_runningData.Location = new System.Drawing.Point(166, 15);
            this.radioButton_runningData.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.radioButton_runningData.Name = "radioButton_runningData";
            this.radioButton_runningData.Size = new System.Drawing.Size(71, 16);
            this.radioButton_runningData.TabIndex = 3;
            this.radioButton_runningData.TabStop = true;
            this.radioButton_runningData.Text = "作业概况";
            this.radioButton_runningData.UseVisualStyleBackColor = true;
            // 
            // radioButton_gpsTrack
            // 
            this.radioButton_gpsTrack.AutoSize = true;
            this.radioButton_gpsTrack.Location = new System.Drawing.Point(247, 15);
            this.radioButton_gpsTrack.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.radioButton_gpsTrack.Name = "radioButton_gpsTrack";
            this.radioButton_gpsTrack.Size = new System.Drawing.Size(65, 16);
            this.radioButton_gpsTrack.TabIndex = 4;
            this.radioButton_gpsTrack.TabStop = true;
            this.radioButton_gpsTrack.Text = "GPS轨迹";
            this.radioButton_gpsTrack.UseVisualStyleBackColor = true;
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(5, 15);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(40, 40);
            this.button_openFile.TabIndex = 1;
            this.button_openFile.Text = "打开作业";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // tabPage_dataQuery
            // 
            this.tabPage_dataQuery.Location = new System.Drawing.Point(4, 22);
            this.tabPage_dataQuery.Name = "tabPage_dataQuery";
            this.tabPage_dataQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dataQuery.Size = new System.Drawing.Size(1256, 655);
            this.tabPage_dataQuery.TabIndex = 1;
            this.tabPage_dataQuery.Text = "数据查询";
            this.tabPage_dataQuery.UseVisualStyleBackColor = true;
            // 
            // tabPage_reportQuery
            // 
            this.tabPage_reportQuery.Location = new System.Drawing.Point(4, 22);
            this.tabPage_reportQuery.Name = "tabPage_reportQuery";
            this.tabPage_reportQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_reportQuery.Size = new System.Drawing.Size(1256, 655);
            this.tabPage_reportQuery.TabIndex = 2;
            this.tabPage_reportQuery.Text = "报告查询";
            this.tabPage_reportQuery.UseVisualStyleBackColor = true;
            // 
            // tabPage_systemSetting
            // 
            this.tabPage_systemSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_systemSetting.Name = "tabPage_systemSetting";
            this.tabPage_systemSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_systemSetting.Size = new System.Drawing.Size(1256, 655);
            this.tabPage_systemSetting.TabIndex = 3;
            this.tabPage_systemSetting.Text = "系统设置";
            this.tabPage_systemSetting.UseVisualStyleBackColor = true;
            // 
            // notifyIcon_main
            // 
            this.notifyIcon_main.ContextMenuStrip = this.contextMenuStrip_mainNotify;
            this.notifyIcon_main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_main.Icon")));
            this.notifyIcon_main.Text = "回放软件";
            this.notifyIcon_main.Visible = true;
            this.notifyIcon_main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_main_MouseDoubleClick);
            // 
            // contextMenuStrip_mainNotify
            // 
            this.contextMenuStrip_mainNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_maximize,
            this.toolStripMenuItem_minimize,
            this.toolStripMenuItem_recover,
            this.toolStripMenuItem_exit});
            this.contextMenuStrip_mainNotify.Name = "contextMenuStrip_mainNotify";
            this.contextMenuStrip_mainNotify.Size = new System.Drawing.Size(113, 92);
            // 
            // toolStripMenuItem_maximize
            // 
            this.toolStripMenuItem_maximize.Name = "toolStripMenuItem_maximize";
            this.toolStripMenuItem_maximize.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_maximize.Text = "最大化";
            this.toolStripMenuItem_maximize.Click += new System.EventHandler(this.toolStripMenuItem_maximize_Click);
            // 
            // toolStripMenuItem_minimize
            // 
            this.toolStripMenuItem_minimize.Name = "toolStripMenuItem_minimize";
            this.toolStripMenuItem_minimize.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_minimize.Text = "最小化";
            this.toolStripMenuItem_minimize.Click += new System.EventHandler(this.toolStripMenuItem_minimize_Click);
            // 
            // toolStripMenuItem_recover
            // 
            this.toolStripMenuItem_recover.Name = "toolStripMenuItem_recover";
            this.toolStripMenuItem_recover.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_recover.Text = "还原";
            this.toolStripMenuItem_recover.DoubleClick += new System.EventHandler(this.toolStripMenuItem_recover_Click);
            // 
            // toolStripMenuItem_exit
            // 
            this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            this.toolStripMenuItem_exit.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_exit.Text = "退出";
            this.toolStripMenuItem_exit.Click += new System.EventHandler(this.toolStripMenuItem_exit_Click);
            // 
            // ucbViewControl
            // 
            this.ucbViewControl.BackColor = System.Drawing.Color.Black;
            this.ucbViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucbViewControl.Location = new System.Drawing.Point(3, 73);
            this.ucbViewControl.Name = "ucbViewControl";
            this.ucbViewControl.Size = new System.Drawing.Size(1250, 204);
            this.ucbViewControl.TabIndex = 0;
            // 
            // ucBasicInfo
            // 
            this.ucBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBasicInfo.Location = new System.Drawing.Point(3, 3);
            this.ucBasicInfo.Name = "ucBasicInfo";
            this.ucBasicInfo.Size = new System.Drawing.Size(495, 237);
            this.ucBasicInfo.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl_Main);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "FormMain";
            this.Text = "Replay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_BView.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_playSpeedingSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_periodSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_slider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl_infos.ResumeLayout(false);
            this.tabPage_info.ResumeLayout(false);
            this.panel_BViewCommand.ResumeLayout(false);
            this.flowLayoutPanel_chooserFile.ResumeLayout(false);
            this.flowLayoutPanel_chooserFile.PerformLayout();
            this.flowLayoutPanel_singSelect.ResumeLayout(false);
            this.flowLayoutPanel_singSelect.PerformLayout();
            this.contextMenuStrip_mainNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_BView;
        private System.Windows.Forms.Panel panel_BViewCommand;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_singSelect;
        private System.Windows.Forms.RadioButton radioButton_basicData;
        private System.Windows.Forms.RadioButton radioButton_AViewData;
        private System.Windows.Forms.RadioButton radioButton_runningData;
        private System.Windows.Forms.RadioButton radioButton_gpsTrack;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_damageReport;
        private System.Windows.Forms.Button button_playbackAdmin;
        private System.Windows.Forms.Button button_playSet;
        private System.Windows.Forms.Button button_contrastPlay;
        private System.Windows.Forms.Button button_dataMaintain;
        private System.Windows.Forms.Button button_dataTable;
        private System.Windows.Forms.Button button_magnifierDisplay;
        private System.Windows.Forms.Button button_labelSearch;
        private System.Windows.Forms.Button button_showTable;
        private System.Windows.Forms.Button button_AILable;
        private System.Windows.Forms.Button button_softwareScreenshot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_chooserFile;
        private System.Windows.Forms.RadioButton radioButton_file1;
        private System.Windows.Forms.RadioButton radioButton_file2;
        private System.Windows.Forms.RadioButton radioButton_doubleB;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_lock;
        private System.Windows.Forms.Button button_unlock;
        private System.Windows.Forms.TrackBar trackBar_slider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.TrackBar trackBar_playSpeedingSlider;
        private System.Windows.Forms.TrackBar trackBar_periodSlider;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_littleRound;
        private System.Windows.Forms.Button button_bigRound;
        private System.Windows.Forms.Button button_less;
        private System.Windows.Forms.Button button_more;
        private System.Windows.Forms.TextBox textBox_playSpeedingSpinner;
        private System.Windows.Forms.TextBox textBox_periodSpinner;
        private System.Windows.Forms.CheckBox checkBox_afterINT;
        private System.Windows.Forms.CheckBox checkBox_beforeINT;
        private System.Windows.Forms.Button button_fullScreen;
        private System.Windows.Forms.Button button_cancelFullScreen;
        private System.Windows.Forms.Label label_la_m_dm_yard;
        private System.Windows.Forms.Label label_la_km_mile_2;
        private System.Windows.Forms.Label label_la_km_mile_1;
        private System.Windows.Forms.TextBox textBox_num_km_mile_2;
        private System.Windows.Forms.TextBox textBox_num_m_dm_yard;
        private System.Windows.Forms.TextBox textBox_num_km_mile_1;
        private System.Windows.Forms.TabControl tabControl_infos;
        private System.Windows.Forms.TabPage tabPage_info;
        private System.Windows.Forms.TabPage tabPage_AData;
        private System.Windows.Forms.TabPage tabPage_summary;
        private System.Windows.Forms.TabPage tabPage_gpsTrack;
        private System.Windows.Forms.TabPage tabPage_dataQuery;
        private System.Windows.Forms.TabPage tabPage_reportQuery;
        private System.Windows.Forms.TabPage tabPage_systemSetting;
        private System.Windows.Forms.NotifyIcon notifyIcon_main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_mainNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_maximize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_minimize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_recover;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
        private UC.UCBViewControl ucbViewControl;
        private UC.UCBasicInfo ucBasicInfo;
    }
}

