namespace PhotogrammetrySpaceResection
{
    partial class SpaceResectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceResectionForm));
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.InputDataGridView = new CCWin.SkinControl.SkinDataGridView();
            this.PointNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoPointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoPointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroundPointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroundPointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroundPointZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioTextBox = new CCWin.SkinControl.SkinTextBox();
            this.RatioLabel = new CCWin.SkinControl.SkinLabel();
            this.ElementGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.ReTimeLimitTextBox = new CCWin.SkinControl.SkinTextBox();
            this.LimitTextBox = new CCWin.SkinControl.SkinTextBox();
            this.ReTimeLimitLabel = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.InnerFTextBox = new CCWin.SkinControl.SkinTextBox();
            this.InnerYTextBox = new CCWin.SkinControl.SkinTextBox();
            this.InnerXTextBox = new CCWin.SkinControl.SkinTextBox();
            this.InnerFLabel = new CCWin.SkinControl.SkinLabel();
            this.InnerYLabel = new CCWin.SkinControl.SkinLabel();
            this.InnerXLabel = new CCWin.SkinControl.SkinLabel();
            this.LimitLabel = new CCWin.SkinControl.SkinLabel();
            this.ReadFromFileButton = new CCWin.SkinControl.SkinButton();
            this.ChangeFilePathButton = new CCWin.SkinControl.SkinButton();
            this.FilePathTextBox = new CCWin.SkinControl.SkinTextBox();
            this.FileManagementGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.OpenFileLocationButton = new CCWin.SkinControl.SkinButton();
            this.SaveToFileButton = new CCWin.SkinControl.SkinButton();
            this.FileTypeGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.XMLRadioButton = new CCWin.SkinControl.SkinRadioButton();
            this.CSVRadioButton = new CCWin.SkinControl.SkinRadioButton();
            this.ClearDataGridViewButton = new CCWin.SkinControl.SkinButton();
            this.ResultGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.ResultGifBox = new CCWin.SkinControl.GifBox();
            this.ResultTextBox = new CCWin.SkinControl.SkinTextBox();
            this.gifBox1 = new CCWin.SkinControl.GifBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGridView)).BeginInit();
            this.ElementGroupBox.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.FileManagementGroupBox.SuspendLayout();
            this.FileTypeGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.ResultTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.Location = new System.Drawing.Point(10, 210);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 6;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(137, 35);
            this.skinButton1.TabIndex = 7;
            this.skinButton1.Text = "计算";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.Calculate);
            // 
            // InputDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.InputDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InputDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.InputDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InputDataGridView.ColumnFont = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InputDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PointNo,
            this.PhotoPointX,
            this.PhotoPointY,
            this.GroundPointX,
            this.GroundPointY,
            this.GroundPointZ});
            this.InputDataGridView.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InputDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.InputDataGridView.EnableHeadersVisualStyles = false;
            this.InputDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InputDataGridView.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputDataGridView.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.InputDataGridView.Location = new System.Drawing.Point(7, 31);
            this.InputDataGridView.MultiSelect = false;
            this.InputDataGridView.Name = "InputDataGridView";
            this.InputDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InputDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.InputDataGridView.RowHeadersVisible = false;
            this.InputDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.InputDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.InputDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InputDataGridView.RowTemplate.Height = 23;
            this.InputDataGridView.Size = new System.Drawing.Size(686, 181);
            this.InputDataGridView.TabIndex = 1;
            this.InputDataGridView.TitleBack = null;
            this.InputDataGridView.TitleBackColorBegin = System.Drawing.Color.White;
            this.InputDataGridView.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.InputDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InputDataGridView_CellEndEdit);
            // 
            // PointNo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PointNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.PointNo.Frozen = true;
            this.PointNo.HeaderText = "点号";
            this.PointNo.MaxInputLength = 2;
            this.PointNo.MinimumWidth = 10;
            this.PointNo.Name = "PointNo";
            this.PointNo.ReadOnly = true;
            this.PointNo.Width = 40;
            // 
            // PhotoPointX
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhotoPointX.DefaultCellStyle = dataGridViewCellStyle4;
            this.PhotoPointX.FillWeight = 50F;
            this.PhotoPointX.HeaderText = "像点X（mm）";
            this.PhotoPointX.MaxInputLength = 10;
            this.PhotoPointX.MinimumWidth = 10;
            this.PhotoPointX.Name = "PhotoPointX";
            // 
            // PhotoPointY
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhotoPointY.DefaultCellStyle = dataGridViewCellStyle5;
            this.PhotoPointY.FillWeight = 50F;
            this.PhotoPointY.HeaderText = "像点Y（mm）";
            this.PhotoPointY.MaxInputLength = 10;
            this.PhotoPointY.MinimumWidth = 10;
            this.PhotoPointY.Name = "PhotoPointY";
            // 
            // GroundPointX
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GroundPointX.DefaultCellStyle = dataGridViewCellStyle6;
            this.GroundPointX.FillWeight = 50F;
            this.GroundPointX.HeaderText = "地面点X（m）";
            this.GroundPointX.MaxInputLength = 15;
            this.GroundPointX.MinimumWidth = 50;
            this.GroundPointX.Name = "GroundPointX";
            this.GroundPointX.Width = 140;
            // 
            // GroundPointY
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GroundPointY.DefaultCellStyle = dataGridViewCellStyle7;
            this.GroundPointY.FillWeight = 50F;
            this.GroundPointY.HeaderText = "地面点Y（m）";
            this.GroundPointY.MaxInputLength = 15;
            this.GroundPointY.MinimumWidth = 50;
            this.GroundPointY.Name = "GroundPointY";
            this.GroundPointY.Width = 140;
            // 
            // GroundPointZ
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GroundPointZ.DefaultCellStyle = dataGridViewCellStyle8;
            this.GroundPointZ.FillWeight = 50F;
            this.GroundPointZ.HeaderText = "地面点Z（m）";
            this.GroundPointZ.MaxInputLength = 15;
            this.GroundPointZ.MinimumWidth = 50;
            this.GroundPointZ.Name = "GroundPointZ";
            this.GroundPointZ.Width = 140;
            // 
            // RatioTextBox
            // 
            this.RatioTextBox.BackColor = System.Drawing.Color.Transparent;
            this.RatioTextBox.DownBack = null;
            this.RatioTextBox.Icon = null;
            this.RatioTextBox.IconIsButton = false;
            this.RatioTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.RatioTextBox.IsPasswordChat = '\0';
            this.RatioTextBox.IsSystemPasswordChar = false;
            this.RatioTextBox.Lines = new string[] {
        "40000"};
            this.RatioTextBox.Location = new System.Drawing.Point(100, 19);
            this.RatioTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.RatioTextBox.MaxLength = 10;
            this.RatioTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.RatioTextBox.MouseBack = null;
            this.RatioTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.RatioTextBox.Multiline = false;
            this.RatioTextBox.Name = "RatioTextBox";
            this.RatioTextBox.NormlBack = null;
            this.RatioTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.RatioTextBox.ReadOnly = false;
            this.RatioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RatioTextBox.Size = new System.Drawing.Size(76, 28);
            // 
            // 
            // 
            this.RatioTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RatioTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatioTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.RatioTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.RatioTextBox.SkinTxt.MaxLength = 10;
            this.RatioTextBox.SkinTxt.Name = "BaseText";
            this.RatioTextBox.SkinTxt.Size = new System.Drawing.Size(66, 18);
            this.RatioTextBox.SkinTxt.TabIndex = 0;
            this.RatioTextBox.SkinTxt.Text = "40000";
            this.RatioTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.RatioTextBox.SkinTxt.WaterText = "";
            this.RatioTextBox.TabIndex = 0;
            this.RatioTextBox.TabStop = true;
            this.RatioTextBox.Text = "40000";
            this.RatioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RatioTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.RatioTextBox.WaterText = "";
            this.RatioTextBox.WordWrap = true;
            // 
            // RatioLabel
            // 
            this.RatioLabel.AutoSize = true;
            this.RatioLabel.BackColor = System.Drawing.Color.Transparent;
            this.RatioLabel.BorderColor = System.Drawing.Color.White;
            this.RatioLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RatioLabel.Location = new System.Drawing.Point(31, 26);
            this.RatioLabel.Name = "RatioLabel";
            this.RatioLabel.Size = new System.Drawing.Size(62, 17);
            this.RatioLabel.TabIndex = 0;
            this.RatioLabel.Text = "比例尺  1:";
            this.RatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementGroupBox
            // 
            this.ElementGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ElementGroupBox.BorderColor = System.Drawing.Color.Tomato;
            this.ElementGroupBox.Controls.Add(this.skinButton2);
            this.ElementGroupBox.Controls.Add(this.ReTimeLimitTextBox);
            this.ElementGroupBox.Controls.Add(this.LimitTextBox);
            this.ElementGroupBox.Controls.Add(this.ReTimeLimitLabel);
            this.ElementGroupBox.Controls.Add(this.skinGroupBox2);
            this.ElementGroupBox.Controls.Add(this.LimitLabel);
            this.ElementGroupBox.Controls.Add(this.RatioLabel);
            this.ElementGroupBox.Controls.Add(this.RatioTextBox);
            this.ElementGroupBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.ElementGroupBox.Location = new System.Drawing.Point(170, 218);
            this.ElementGroupBox.Name = "ElementGroupBox";
            this.ElementGroupBox.Radius = 10;
            this.ElementGroupBox.RectBackColor = System.Drawing.Color.White;
            this.ElementGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ElementGroupBox.Size = new System.Drawing.Size(204, 255);
            this.ElementGroupBox.TabIndex = 3;
            this.ElementGroupBox.TabStop = false;
            this.ElementGroupBox.Text = "已知条件";
            this.ElementGroupBox.TitleBorderColor = System.Drawing.Color.Tomato;
            this.ElementGroupBox.TitleRadius = 5;
            this.ElementGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.ElementGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.Cursor = System.Windows.Forms.Cursors.Help;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(178, 229);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Radius = 10;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(20, 20);
            this.skinButton2.TabIndex = 0;
            this.skinButton2.TabStop = false;
            this.skinButton2.Text = "!";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.Author);
            // 
            // ReTimeLimitTextBox
            // 
            this.ReTimeLimitTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ReTimeLimitTextBox.DownBack = null;
            this.ReTimeLimitTextBox.Icon = null;
            this.ReTimeLimitTextBox.IconIsButton = false;
            this.ReTimeLimitTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ReTimeLimitTextBox.IsPasswordChat = '\0';
            this.ReTimeLimitTextBox.IsSystemPasswordChar = false;
            this.ReTimeLimitTextBox.Lines = new string[] {
        "1000"};
            this.ReTimeLimitTextBox.Location = new System.Drawing.Point(104, 220);
            this.ReTimeLimitTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ReTimeLimitTextBox.MaxLength = 5;
            this.ReTimeLimitTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.ReTimeLimitTextBox.MouseBack = null;
            this.ReTimeLimitTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ReTimeLimitTextBox.Multiline = false;
            this.ReTimeLimitTextBox.Name = "ReTimeLimitTextBox";
            this.ReTimeLimitTextBox.NormlBack = null;
            this.ReTimeLimitTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.ReTimeLimitTextBox.ReadOnly = false;
            this.ReTimeLimitTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReTimeLimitTextBox.Size = new System.Drawing.Size(71, 28);
            // 
            // 
            // 
            this.ReTimeLimitTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReTimeLimitTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReTimeLimitTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ReTimeLimitTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ReTimeLimitTextBox.SkinTxt.MaxLength = 5;
            this.ReTimeLimitTextBox.SkinTxt.Name = "BaseText";
            this.ReTimeLimitTextBox.SkinTxt.Size = new System.Drawing.Size(61, 18);
            this.ReTimeLimitTextBox.SkinTxt.TabIndex = 0;
            this.ReTimeLimitTextBox.SkinTxt.Text = "1000";
            this.ReTimeLimitTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ReTimeLimitTextBox.SkinTxt.WaterText = "";
            this.ReTimeLimitTextBox.TabIndex = 3;
            this.ReTimeLimitTextBox.TabStop = true;
            this.ReTimeLimitTextBox.Text = "1000";
            this.ReTimeLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReTimeLimitTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ReTimeLimitTextBox.WaterText = "";
            this.ReTimeLimitTextBox.WordWrap = true;
            // 
            // LimitTextBox
            // 
            this.LimitTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LimitTextBox.DownBack = null;
            this.LimitTextBox.Icon = null;
            this.LimitTextBox.IconIsButton = false;
            this.LimitTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.LimitTextBox.IsPasswordChat = '\0';
            this.LimitTextBox.IsSystemPasswordChar = false;
            this.LimitTextBox.Lines = new string[] {
        "6"};
            this.LimitTextBox.Location = new System.Drawing.Point(79, 187);
            this.LimitTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.LimitTextBox.MaxLength = 5;
            this.LimitTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.LimitTextBox.MouseBack = null;
            this.LimitTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.LimitTextBox.Multiline = false;
            this.LimitTextBox.Name = "LimitTextBox";
            this.LimitTextBox.NormlBack = null;
            this.LimitTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.LimitTextBox.ReadOnly = false;
            this.LimitTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LimitTextBox.Size = new System.Drawing.Size(50, 28);
            // 
            // 
            // 
            this.LimitTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LimitTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LimitTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.LimitTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.LimitTextBox.SkinTxt.MaxLength = 5;
            this.LimitTextBox.SkinTxt.Name = "BaseText";
            this.LimitTextBox.SkinTxt.Size = new System.Drawing.Size(40, 18);
            this.LimitTextBox.SkinTxt.TabIndex = 0;
            this.LimitTextBox.SkinTxt.Text = "6";
            this.LimitTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.LimitTextBox.SkinTxt.WaterText = "";
            this.LimitTextBox.TabIndex = 2;
            this.LimitTextBox.TabStop = true;
            this.LimitTextBox.Text = "6";
            this.LimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LimitTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.LimitTextBox.WaterText = "";
            this.LimitTextBox.WordWrap = true;
            // 
            // ReTimeLimitLabel
            // 
            this.ReTimeLimitLabel.AutoSize = true;
            this.ReTimeLimitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReTimeLimitLabel.BorderColor = System.Drawing.Color.White;
            this.ReTimeLimitLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReTimeLimitLabel.Location = new System.Drawing.Point(23, 227);
            this.ReTimeLimitLabel.Name = "ReTimeLimitLabel";
            this.ReTimeLimitLabel.Size = new System.Drawing.Size(80, 17);
            this.ReTimeLimitLabel.TabIndex = 0;
            this.ReTimeLimitLabel.Text = "迭代次数上限";
            this.ReTimeLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Tomato;
            this.skinGroupBox2.Controls.Add(this.InnerFTextBox);
            this.skinGroupBox2.Controls.Add(this.InnerYTextBox);
            this.skinGroupBox2.Controls.Add(this.InnerXTextBox);
            this.skinGroupBox2.Controls.Add(this.InnerFLabel);
            this.skinGroupBox2.Controls.Add(this.InnerYLabel);
            this.skinGroupBox2.Controls.Add(this.InnerXLabel);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(6, 50);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.Radius = 10;
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(192, 133);
            this.skinGroupBox2.TabIndex = 1;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "内方位元素";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Tomato;
            this.skinGroupBox2.TitleRadius = 5;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // InnerFTextBox
            // 
            this.InnerFTextBox.BackColor = System.Drawing.Color.Transparent;
            this.InnerFTextBox.DownBack = null;
            this.InnerFTextBox.Icon = null;
            this.InnerFTextBox.IconIsButton = false;
            this.InnerFTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.InnerFTextBox.IsPasswordChat = '\0';
            this.InnerFTextBox.IsSystemPasswordChar = false;
            this.InnerFTextBox.Lines = new string[] {
        "153.24"};
            this.InnerFTextBox.Location = new System.Drawing.Point(63, 95);
            this.InnerFTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.InnerFTextBox.MaxLength = 8;
            this.InnerFTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.InnerFTextBox.MouseBack = null;
            this.InnerFTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.InnerFTextBox.Multiline = false;
            this.InnerFTextBox.Name = "InnerFTextBox";
            this.InnerFTextBox.NormlBack = null;
            this.InnerFTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.InnerFTextBox.ReadOnly = false;
            this.InnerFTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InnerFTextBox.Size = new System.Drawing.Size(67, 28);
            // 
            // 
            // 
            this.InnerFTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InnerFTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerFTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.InnerFTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.InnerFTextBox.SkinTxt.MaxLength = 8;
            this.InnerFTextBox.SkinTxt.Name = "BaseText";
            this.InnerFTextBox.SkinTxt.Size = new System.Drawing.Size(57, 18);
            this.InnerFTextBox.SkinTxt.TabIndex = 0;
            this.InnerFTextBox.SkinTxt.Text = "153.24";
            this.InnerFTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.InnerFTextBox.SkinTxt.WaterText = "";
            this.InnerFTextBox.TabIndex = 3;
            this.InnerFTextBox.TabStop = true;
            this.InnerFTextBox.Text = "153.24";
            this.InnerFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InnerFTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.InnerFTextBox.WaterText = "";
            this.InnerFTextBox.WordWrap = true;
            // 
            // InnerYTextBox
            // 
            this.InnerYTextBox.BackColor = System.Drawing.Color.Transparent;
            this.InnerYTextBox.DownBack = null;
            this.InnerYTextBox.Icon = null;
            this.InnerYTextBox.IconIsButton = false;
            this.InnerYTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.InnerYTextBox.IsPasswordChat = '\0';
            this.InnerYTextBox.IsSystemPasswordChar = false;
            this.InnerYTextBox.Lines = new string[] {
        "-0.02"};
            this.InnerYTextBox.Location = new System.Drawing.Point(63, 57);
            this.InnerYTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.InnerYTextBox.MaxLength = 8;
            this.InnerYTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.InnerYTextBox.MouseBack = null;
            this.InnerYTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.InnerYTextBox.Multiline = false;
            this.InnerYTextBox.Name = "InnerYTextBox";
            this.InnerYTextBox.NormlBack = null;
            this.InnerYTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.InnerYTextBox.ReadOnly = false;
            this.InnerYTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InnerYTextBox.Size = new System.Drawing.Size(67, 28);
            // 
            // 
            // 
            this.InnerYTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InnerYTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerYTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.InnerYTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.InnerYTextBox.SkinTxt.MaxLength = 8;
            this.InnerYTextBox.SkinTxt.Name = "BaseText";
            this.InnerYTextBox.SkinTxt.Size = new System.Drawing.Size(57, 18);
            this.InnerYTextBox.SkinTxt.TabIndex = 0;
            this.InnerYTextBox.SkinTxt.Text = "-0.02";
            this.InnerYTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.InnerYTextBox.SkinTxt.WaterText = "";
            this.InnerYTextBox.TabIndex = 2;
            this.InnerYTextBox.TabStop = true;
            this.InnerYTextBox.Text = "-0.02";
            this.InnerYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InnerYTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.InnerYTextBox.WaterText = "";
            this.InnerYTextBox.WordWrap = true;
            // 
            // InnerXTextBox
            // 
            this.InnerXTextBox.BackColor = System.Drawing.Color.Transparent;
            this.InnerXTextBox.DownBack = null;
            this.InnerXTextBox.Icon = null;
            this.InnerXTextBox.IconIsButton = false;
            this.InnerXTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.InnerXTextBox.IsPasswordChat = '\0';
            this.InnerXTextBox.IsSystemPasswordChar = false;
            this.InnerXTextBox.Lines = new string[] {
        "0.01"};
            this.InnerXTextBox.Location = new System.Drawing.Point(63, 20);
            this.InnerXTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.InnerXTextBox.MaxLength = 8;
            this.InnerXTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.InnerXTextBox.MouseBack = null;
            this.InnerXTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.InnerXTextBox.Multiline = false;
            this.InnerXTextBox.Name = "InnerXTextBox";
            this.InnerXTextBox.NormlBack = null;
            this.InnerXTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.InnerXTextBox.ReadOnly = false;
            this.InnerXTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InnerXTextBox.Size = new System.Drawing.Size(67, 28);
            // 
            // 
            // 
            this.InnerXTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InnerXTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerXTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.InnerXTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.InnerXTextBox.SkinTxt.MaxLength = 8;
            this.InnerXTextBox.SkinTxt.Name = "BaseText";
            this.InnerXTextBox.SkinTxt.Size = new System.Drawing.Size(57, 18);
            this.InnerXTextBox.SkinTxt.TabIndex = 0;
            this.InnerXTextBox.SkinTxt.Text = "0.01";
            this.InnerXTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.InnerXTextBox.SkinTxt.WaterText = "";
            this.InnerXTextBox.TabIndex = 1;
            this.InnerXTextBox.TabStop = true;
            this.InnerXTextBox.Text = "0.01";
            this.InnerXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InnerXTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.InnerXTextBox.WaterText = "";
            this.InnerXTextBox.WordWrap = true;
            // 
            // InnerFLabel
            // 
            this.InnerFLabel.AutoSize = true;
            this.InnerFLabel.BackColor = System.Drawing.Color.Transparent;
            this.InnerFLabel.BorderColor = System.Drawing.Color.White;
            this.InnerFLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InnerFLabel.Location = new System.Drawing.Point(36, 101);
            this.InnerFLabel.Name = "InnerFLabel";
            this.InnerFLabel.Size = new System.Drawing.Size(142, 17);
            this.InnerFLabel.TabIndex = 0;
            this.InnerFLabel.Text = "f                         (mm)";
            this.InnerFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InnerYLabel
            // 
            this.InnerYLabel.AutoSize = true;
            this.InnerYLabel.BackColor = System.Drawing.Color.Transparent;
            this.InnerYLabel.BorderColor = System.Drawing.Color.White;
            this.InnerYLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InnerYLabel.Location = new System.Drawing.Point(32, 63);
            this.InnerYLabel.Name = "InnerYLabel";
            this.InnerYLabel.Size = new System.Drawing.Size(144, 17);
            this.InnerYLabel.TabIndex = 0;
            this.InnerYLabel.Text = "Y0                       (mm)";
            this.InnerYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InnerXLabel
            // 
            this.InnerXLabel.AutoSize = true;
            this.InnerXLabel.BackColor = System.Drawing.Color.Transparent;
            this.InnerXLabel.BorderColor = System.Drawing.Color.White;
            this.InnerXLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InnerXLabel.Location = new System.Drawing.Point(32, 26);
            this.InnerXLabel.Name = "InnerXLabel";
            this.InnerXLabel.Size = new System.Drawing.Size(145, 17);
            this.InnerXLabel.TabIndex = 0;
            this.InnerXLabel.Text = "X0                       (mm)";
            this.InnerXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LimitLabel
            // 
            this.LimitLabel.AutoSize = true;
            this.LimitLabel.BackColor = System.Drawing.Color.Transparent;
            this.LimitLabel.BorderColor = System.Drawing.Color.White;
            this.LimitLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LimitLabel.Location = new System.Drawing.Point(44, 194);
            this.LimitLabel.Name = "LimitLabel";
            this.LimitLabel.Size = new System.Drawing.Size(113, 17);
            this.LimitLabel.TabIndex = 0;
            this.LimitLabel.Text = "限差                 (″)";
            this.LimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadFromFileButton
            // 
            this.ReadFromFileButton.BackColor = System.Drawing.Color.Transparent;
            this.ReadFromFileButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ReadFromFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadFromFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReadFromFileButton.DownBack = null;
            this.ReadFromFileButton.Location = new System.Drawing.Point(10, 134);
            this.ReadFromFileButton.MouseBack = null;
            this.ReadFromFileButton.Name = "ReadFromFileButton";
            this.ReadFromFileButton.NormlBack = null;
            this.ReadFromFileButton.Radius = 6;
            this.ReadFromFileButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ReadFromFileButton.Size = new System.Drawing.Size(137, 23);
            this.ReadFromFileButton.TabIndex = 4;
            this.ReadFromFileButton.Text = "读取点位数据";
            this.ReadFromFileButton.UseVisualStyleBackColor = false;
            this.ReadFromFileButton.Click += new System.EventHandler(this.FileManagement);
            // 
            // ChangeFilePathButton
            // 
            this.ChangeFilePathButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangeFilePathButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ChangeFilePathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeFilePathButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeFilePathButton.DownBack = null;
            this.ChangeFilePathButton.Location = new System.Drawing.Point(10, 74);
            this.ChangeFilePathButton.MouseBack = null;
            this.ChangeFilePathButton.Name = "ChangeFilePathButton";
            this.ChangeFilePathButton.NormlBack = null;
            this.ChangeFilePathButton.Radius = 6;
            this.ChangeFilePathButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ChangeFilePathButton.Size = new System.Drawing.Size(137, 23);
            this.ChangeFilePathButton.TabIndex = 2;
            this.ChangeFilePathButton.Text = "更改文件夹...";
            this.ChangeFilePathButton.UseVisualStyleBackColor = false;
            this.ChangeFilePathButton.Click += new System.EventHandler(this.FileManagement);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FilePathTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilePathTextBox.DownBack = null;
            this.FilePathTextBox.Icon = null;
            this.FilePathTextBox.IconIsButton = false;
            this.FilePathTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.FilePathTextBox.IsPasswordChat = '\0';
            this.FilePathTextBox.IsSystemPasswordChar = false;
            this.FilePathTextBox.Lines = new string[0];
            this.FilePathTextBox.Location = new System.Drawing.Point(10, 46);
            this.FilePathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FilePathTextBox.MaxLength = 256;
            this.FilePathTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.FilePathTextBox.MouseBack = null;
            this.FilePathTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.FilePathTextBox.Multiline = false;
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.NormlBack = null;
            this.FilePathTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.FilePathTextBox.ReadOnly = false;
            this.FilePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilePathTextBox.Size = new System.Drawing.Size(137, 28);
            // 
            // 
            // 
            this.FilePathTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilePathTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilePathTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.FilePathTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.FilePathTextBox.SkinTxt.MaxLength = 256;
            this.FilePathTextBox.SkinTxt.Name = "BaseText";
            this.FilePathTextBox.SkinTxt.Size = new System.Drawing.Size(127, 18);
            this.FilePathTextBox.SkinTxt.TabIndex = 0;
            this.FilePathTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.FilePathTextBox.SkinTxt.WaterText = "";
            this.FilePathTextBox.TabIndex = 1;
            this.FilePathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FilePathTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.FilePathTextBox.WaterText = "";
            this.FilePathTextBox.WordWrap = true;
            // 
            // FileManagementGroupBox
            // 
            this.FileManagementGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.FileManagementGroupBox.BorderColor = System.Drawing.Color.Firebrick;
            this.FileManagementGroupBox.Controls.Add(this.OpenFileLocationButton);
            this.FileManagementGroupBox.Controls.Add(this.SaveToFileButton);
            this.FileManagementGroupBox.Controls.Add(this.ReadFromFileButton);
            this.FileManagementGroupBox.Controls.Add(this.FileTypeGroupBox);
            this.FileManagementGroupBox.Controls.Add(this.ChangeFilePathButton);
            this.FileManagementGroupBox.Controls.Add(this.FilePathTextBox);
            this.FileManagementGroupBox.Controls.Add(this.skinButton1);
            this.FileManagementGroupBox.Controls.Add(this.ClearDataGridViewButton);
            this.FileManagementGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.FileManagementGroupBox.Location = new System.Drawing.Point(7, 218);
            this.FileManagementGroupBox.Name = "FileManagementGroupBox";
            this.FileManagementGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.FileManagementGroupBox.Radius = 10;
            this.FileManagementGroupBox.RectBackColor = System.Drawing.Color.White;
            this.FileManagementGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.FileManagementGroupBox.Size = new System.Drawing.Size(157, 255);
            this.FileManagementGroupBox.TabIndex = 2;
            this.FileManagementGroupBox.TabStop = false;
            this.FileManagementGroupBox.Text = "文件及数据操作";
            this.FileManagementGroupBox.TitleBorderColor = System.Drawing.Color.Firebrick;
            this.FileManagementGroupBox.TitleRadius = 5;
            this.FileManagementGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.FileManagementGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // OpenFileLocationButton
            // 
            this.OpenFileLocationButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFileLocationButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.OpenFileLocationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileLocationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileLocationButton.DownBack = null;
            this.OpenFileLocationButton.Location = new System.Drawing.Point(10, 180);
            this.OpenFileLocationButton.MouseBack = null;
            this.OpenFileLocationButton.Name = "OpenFileLocationButton";
            this.OpenFileLocationButton.NormlBack = null;
            this.OpenFileLocationButton.Radius = 6;
            this.OpenFileLocationButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.OpenFileLocationButton.Size = new System.Drawing.Size(137, 23);
            this.OpenFileLocationButton.TabIndex = 6;
            this.OpenFileLocationButton.Text = "打开结果文件夹";
            this.OpenFileLocationButton.UseVisualStyleBackColor = false;
            this.OpenFileLocationButton.Click += new System.EventHandler(this.FileManagement);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveToFileButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SaveToFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveToFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveToFileButton.DownBack = null;
            this.SaveToFileButton.Location = new System.Drawing.Point(10, 157);
            this.SaveToFileButton.MouseBack = null;
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.NormlBack = null;
            this.SaveToFileButton.Radius = 6;
            this.SaveToFileButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.SaveToFileButton.Size = new System.Drawing.Size(137, 23);
            this.SaveToFileButton.TabIndex = 5;
            this.SaveToFileButton.Text = "保存结果到文件";
            this.SaveToFileButton.UseVisualStyleBackColor = false;
            this.SaveToFileButton.Click += new System.EventHandler(this.FileManagement);
            // 
            // FileTypeGroupBox
            // 
            this.FileTypeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.FileTypeGroupBox.BorderColor = System.Drawing.Color.Tomato;
            this.FileTypeGroupBox.Controls.Add(this.XMLRadioButton);
            this.FileTypeGroupBox.Controls.Add(this.CSVRadioButton);
            this.FileTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileTypeGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.FileTypeGroupBox.Location = new System.Drawing.Point(10, 97);
            this.FileTypeGroupBox.Name = "FileTypeGroupBox";
            this.FileTypeGroupBox.Radius = 6;
            this.FileTypeGroupBox.RectBackColor = System.Drawing.Color.White;
            this.FileTypeGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.FileTypeGroupBox.Size = new System.Drawing.Size(137, 37);
            this.FileTypeGroupBox.TabIndex = 3;
            this.FileTypeGroupBox.TabStop = false;
            this.FileTypeGroupBox.Text = "数据文件类型";
            this.FileTypeGroupBox.TitleBorderColor = System.Drawing.Color.Tomato;
            this.FileTypeGroupBox.TitleRadius = 6;
            this.FileTypeGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.FileTypeGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // XMLRadioButton
            // 
            this.XMLRadioButton.AutoSize = true;
            this.XMLRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.XMLRadioButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.XMLRadioButton.DownBack = null;
            this.XMLRadioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XMLRadioButton.Location = new System.Drawing.Point(73, 15);
            this.XMLRadioButton.MouseBack = null;
            this.XMLRadioButton.Name = "XMLRadioButton";
            this.XMLRadioButton.NormlBack = null;
            this.XMLRadioButton.SelectedDownBack = null;
            this.XMLRadioButton.SelectedMouseBack = null;
            this.XMLRadioButton.SelectedNormlBack = null;
            this.XMLRadioButton.Size = new System.Drawing.Size(52, 21);
            this.XMLRadioButton.TabIndex = 2;
            this.XMLRadioButton.Text = "XML";
            this.XMLRadioButton.UseVisualStyleBackColor = false;
            // 
            // CSVRadioButton
            // 
            this.CSVRadioButton.AutoSize = true;
            this.CSVRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.CSVRadioButton.Checked = true;
            this.CSVRadioButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CSVRadioButton.DownBack = null;
            this.CSVRadioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CSVRadioButton.Location = new System.Drawing.Point(13, 15);
            this.CSVRadioButton.MouseBack = null;
            this.CSVRadioButton.Name = "CSVRadioButton";
            this.CSVRadioButton.NormlBack = null;
            this.CSVRadioButton.SelectedDownBack = null;
            this.CSVRadioButton.SelectedMouseBack = null;
            this.CSVRadioButton.SelectedNormlBack = null;
            this.CSVRadioButton.Size = new System.Drawing.Size(49, 21);
            this.CSVRadioButton.TabIndex = 1;
            this.CSVRadioButton.TabStop = true;
            this.CSVRadioButton.Text = "CSV";
            this.CSVRadioButton.UseVisualStyleBackColor = false;
            // 
            // ClearDataGridViewButton
            // 
            this.ClearDataGridViewButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearDataGridViewButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ClearDataGridViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearDataGridViewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearDataGridViewButton.DownBack = null;
            this.ClearDataGridViewButton.Location = new System.Drawing.Point(10, 23);
            this.ClearDataGridViewButton.MouseBack = null;
            this.ClearDataGridViewButton.Name = "ClearDataGridViewButton";
            this.ClearDataGridViewButton.NormlBack = null;
            this.ClearDataGridViewButton.Radius = 6;
            this.ClearDataGridViewButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ClearDataGridViewButton.Size = new System.Drawing.Size(137, 23);
            this.ClearDataGridViewButton.TabIndex = 0;
            this.ClearDataGridViewButton.Text = "清空数据框";
            this.ClearDataGridViewButton.UseVisualStyleBackColor = false;
            this.ClearDataGridViewButton.Click += new System.EventHandler(this.ClearDataGridView);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ResultGroupBox.BorderColor = System.Drawing.Color.DarkRed;
            this.ResultGroupBox.Controls.Add(this.ResultGifBox);
            this.ResultGroupBox.Controls.Add(this.ResultTextBox);
            this.ResultGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.ResultGroupBox.Location = new System.Drawing.Point(380, 218);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.ResultGroupBox.Radius = 10;
            this.ResultGroupBox.RectBackColor = System.Drawing.Color.White;
            this.ResultGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ResultGroupBox.Size = new System.Drawing.Size(313, 255);
            this.ResultGroupBox.TabIndex = 2;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "计算结果";
            this.ResultGroupBox.TitleBorderColor = System.Drawing.Color.DarkRed;
            this.ResultGroupBox.TitleRadius = 5;
            this.ResultGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.ResultGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // ResultGifBox
            // 
            this.ResultGifBox.BackColor = System.Drawing.Color.White;
            this.ResultGifBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResultGifBox.BorderColor = System.Drawing.Color.Transparent;
            this.ResultGifBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ResultGifBox.Image = ((System.Drawing.Image)(resources.GetObject("ResultGifBox.Image")));
            this.ResultGifBox.Location = new System.Drawing.Point(1, -28);
            this.ResultGifBox.Name = "ResultGifBox";
            this.ResultGifBox.Size = new System.Drawing.Size(313, 286);
            this.ResultGifBox.TabIndex = 0;
            this.ResultGifBox.TabStop = false;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ResultTextBox.Controls.Add(this.gifBox1);
            this.ResultTextBox.DownBack = null;
            this.ResultTextBox.Icon = null;
            this.ResultTextBox.IconIsButton = false;
            this.ResultTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ResultTextBox.IsPasswordChat = '\0';
            this.ResultTextBox.IsSystemPasswordChar = false;
            this.ResultTextBox.Lines = new string[] {
        "这里什么都没有，好冷清啊。快点击“计算”吧！"};
            this.ResultTextBox.Location = new System.Drawing.Point(10, 28);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResultTextBox.MaxLength = 1000;
            this.ResultTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.ResultTextBox.MouseBack = null;
            this.ResultTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.NormlBack = null;
            this.ResultTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(293, 217);
            // 
            // 
            // 
            this.ResultTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ResultTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ResultTextBox.SkinTxt.MaxLength = 1000;
            this.ResultTextBox.SkinTxt.Multiline = true;
            this.ResultTextBox.SkinTxt.Name = "BaseText";
            this.ResultTextBox.SkinTxt.ReadOnly = true;
            this.ResultTextBox.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.SkinTxt.Size = new System.Drawing.Size(283, 207);
            this.ResultTextBox.SkinTxt.TabIndex = 0;
            this.ResultTextBox.SkinTxt.Text = "这里什么都没有，好冷清啊。快点击“计算”吧！";
            this.ResultTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ResultTextBox.SkinTxt.WaterText = "";
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "这里什么都没有，好冷清啊。快点击“计算”吧！";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ResultTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ResultTextBox.WaterText = "";
            this.ResultTextBox.WordWrap = true;
            // 
            // gifBox1
            // 
            this.gifBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox1.Image = null;
            this.gifBox1.Location = new System.Drawing.Point(3, 8);
            this.gifBox1.Name = "gifBox1";
            this.gifBox1.Size = new System.Drawing.Size(260, 98);
            this.gifBox1.TabIndex = 1;
            this.gifBox1.Text = "gifBox1";
            // 
            // SpaceResectionForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.InputDataGridView);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.FileManagementGroupBox);
            this.Controls.Add(this.ElementGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "SpaceResectionForm";
            this.Text = "单像空间后方交会，由Rikakoist制作";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitApp);
            this.Load += new System.EventHandler(this.SpaceResectionForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragToOpenFile);
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGridView)).EndInit();
            this.ElementGroupBox.ResumeLayout(false);
            this.ElementGroupBox.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.FileManagementGroupBox.ResumeLayout(false);
            this.FileTypeGroupBox.ResumeLayout(false);
            this.FileTypeGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultTextBox.ResumeLayout(false);
            this.ResultTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinDataGridView InputDataGridView;
        private CCWin.SkinControl.SkinTextBox RatioTextBox;
        private CCWin.SkinControl.SkinLabel RatioLabel;
        private CCWin.SkinControl.SkinGroupBox ElementGroupBox;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinLabel InnerFLabel;
        private CCWin.SkinControl.SkinLabel InnerYLabel;
        private CCWin.SkinControl.SkinLabel InnerXLabel;
        private CCWin.SkinControl.SkinTextBox InnerXTextBox;
        private CCWin.SkinControl.SkinTextBox InnerFTextBox;
        private CCWin.SkinControl.SkinTextBox InnerYTextBox;
        private CCWin.SkinControl.SkinButton ReadFromFileButton;
        private CCWin.SkinControl.SkinButton ChangeFilePathButton;
        private CCWin.SkinControl.SkinTextBox FilePathTextBox;
        private CCWin.SkinControl.SkinGroupBox FileManagementGroupBox;
        private CCWin.SkinControl.SkinLabel LimitLabel;
        private CCWin.SkinControl.SkinTextBox LimitTextBox;
        private CCWin.SkinControl.SkinGroupBox ResultGroupBox;
        private CCWin.SkinControl.SkinTextBox ResultTextBox;
        private CCWin.SkinControl.SkinButton SaveToFileButton;
        private CCWin.SkinControl.SkinButton OpenFileLocationButton;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinTextBox ReTimeLimitTextBox;
        private CCWin.SkinControl.SkinLabel ReTimeLimitLabel;
        private CCWin.SkinControl.GifBox gifBox1;
        private CCWin.SkinControl.GifBox ResultGifBox;
        private CCWin.SkinControl.SkinGroupBox FileTypeGroupBox;
        private CCWin.SkinControl.SkinRadioButton XMLRadioButton;
        private CCWin.SkinControl.SkinRadioButton CSVRadioButton;
        private CCWin.SkinControl.SkinButton ClearDataGridViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoPointX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoPointY;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroundPointX;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroundPointY;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroundPointZ;
    }
}

