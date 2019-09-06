namespace DemoSpline
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxVertex = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewVertex = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxVertex = new System.Windows.Forms.CheckBox();
            this.buttonVertexAll = new System.Windows.Forms.Button();
            this.buttonVertexSingle = new System.Windows.Forms.Button();
            this.groupBoxNavi = new System.Windows.Forms.GroupBox();
            this.buttonNaviUp = new System.Windows.Forms.Button();
            this.buttonNaviDown = new System.Windows.Forms.Button();
            this.buttonNaviLeft = new System.Windows.Forms.Button();
            this.buttonNaviRight = new System.Windows.Forms.Button();
            this.buttonNaviReset = new System.Windows.Forms.Button();
            this.buttonNavi21 = new System.Windows.Forms.Button();
            this.buttonNavi12 = new System.Windows.Forms.Button();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.labelPoint = new System.Windows.Forms.Label();
            this.numericUpDownPoint = new System.Windows.Forms.NumericUpDown();
            this.groupBoxGraph = new System.Windows.Forms.GroupBox();
            this.labelGraph = new System.Windows.Forms.Label();
            this.numericUpDownGraph = new System.Windows.Forms.NumericUpDown();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.groupBoxSmooth = new System.Windows.Forms.GroupBox();
            this.radioButtonSmoothOn1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSmoothOff = new System.Windows.Forms.RadioButton();
            this.radioButtonSmoothOn2 = new System.Windows.Forms.RadioButton();
            this.groupBoxLine = new System.Windows.Forms.GroupBox();
            this.comboBoxLine = new System.Windows.Forms.ComboBox();
            this.checkBoxLine = new System.Windows.Forms.CheckBox();
            this.buttonLine = new System.Windows.Forms.Button();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.labelGridSize = new System.Windows.Forms.Label();
            this.comboBoxGrid = new System.Windows.Forms.ComboBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPosXn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPosXv = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPosYn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPosYv = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBreak1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelScaleXYn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelScaleXYv = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBreak2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelShiftXn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelShiftXv = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelShiftYn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelShiftYv = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBreak3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAbout = new System.Windows.Forms.ToolStripStatusLabel();
            this.GL = new SharpGL.OpenGLControl();
            this.toolStripStatusLabelVerSharpgl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVerOpengl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxVertex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertex)).BeginInit();
            this.groupBoxNavi.SuspendLayout();
            this.groupBoxPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).BeginInit();
            this.groupBoxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph)).BeginInit();
            this.groupBoxSmooth.SuspendLayout();
            this.groupBoxLine.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVertex
            // 
            this.groupBoxVertex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVertex.Controls.Add(this.checkBox1);
            this.groupBoxVertex.Controls.Add(this.dataGridViewVertex);
            this.groupBoxVertex.Controls.Add(this.checkBoxVertex);
            this.groupBoxVertex.Controls.Add(this.buttonVertexAll);
            this.groupBoxVertex.Controls.Add(this.buttonVertexSingle);
            this.groupBoxVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVertex.Location = new System.Drawing.Point(571, 9);
            this.groupBoxVertex.Name = "groupBoxVertex";
            this.groupBoxVertex.Size = new System.Drawing.Size(173, 473);
            this.groupBoxVertex.TabIndex = 1;
            this.groupBoxVertex.TabStop = false;
            this.groupBoxVertex.Text = "Vertices";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(22, 449);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Differentiate";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewVertex
            // 
            this.dataGridViewVertex.AllowUserToAddRows = false;
            this.dataGridViewVertex.AllowUserToDeleteRows = false;
            this.dataGridViewVertex.AllowUserToResizeRows = false;
            this.dataGridViewVertex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVertex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewVertex.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewVertex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVertex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVertex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVertex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2});
            this.dataGridViewVertex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewVertex.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewVertex.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewVertex.MultiSelect = false;
            this.dataGridViewVertex.Name = "dataGridViewVertex";
            this.dataGridViewVertex.ReadOnly = true;
            this.dataGridViewVertex.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewVertex.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVertex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewVertex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVertex.Size = new System.Drawing.Size(161, 345);
            this.dataGridViewVertex.StandardTab = true;
            this.dataGridViewVertex.TabIndex = 10;
            this.dataGridViewVertex.CurrentCellChanged += new System.EventHandler(this.dataGridViewVertex_CurrentCellChanged);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "№";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column0.Width = 24;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "OX";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "OY";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkBoxVertex
            // 
            this.checkBoxVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxVertex.AutoSize = true;
            this.checkBoxVertex.Checked = true;
            this.checkBoxVertex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVertex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVertex.Location = new System.Drawing.Point(16, 373);
            this.checkBoxVertex.Name = "checkBoxVertex";
            this.checkBoxVertex.Size = new System.Drawing.Size(141, 19);
            this.checkBoxVertex.TabIndex = 2;
            this.checkBoxVertex.Text = "Sort by x";
            this.checkBoxVertex.UseVisualStyleBackColor = true;
            this.checkBoxVertex.CheckedChanged += new System.EventHandler(this.checkBoxVertex_CheckedChanged);
            // 
            // buttonVertexAll
            // 
            this.buttonVertexAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVertexAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVertexAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonVertexAll.Image")));
            this.buttonVertexAll.Location = new System.Drawing.Point(87, 403);
            this.buttonVertexAll.Name = "buttonVertexAll";
            this.buttonVertexAll.Size = new System.Drawing.Size(71, 42);
            this.buttonVertexAll.TabIndex = 4;
            this.buttonVertexAll.Text = "All vertices";
            this.buttonVertexAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVertexAll.UseVisualStyleBackColor = true;
            this.buttonVertexAll.Click += new System.EventHandler(this.buttonVertexAll_Click);
            // 
            // buttonVertexSingle
            // 
            this.buttonVertexSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVertexSingle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVertexSingle.Image = ((System.Drawing.Image)(resources.GetObject("buttonVertexSingle.Image")));
            this.buttonVertexSingle.Location = new System.Drawing.Point(12, 403);
            this.buttonVertexSingle.Name = "buttonVertexSingle";
            this.buttonVertexSingle.Size = new System.Drawing.Size(69, 42);
            this.buttonVertexSingle.TabIndex = 3;
            this.buttonVertexSingle.Text = "1";
            this.buttonVertexSingle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVertexSingle.UseVisualStyleBackColor = true;
            this.buttonVertexSingle.Click += new System.EventHandler(this.buttonVertexSingle_Click);
            // 
            // groupBoxNavi
            // 
            this.groupBoxNavi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNavi.Controls.Add(this.buttonNaviUp);
            this.groupBoxNavi.Controls.Add(this.buttonNaviDown);
            this.groupBoxNavi.Controls.Add(this.buttonNaviLeft);
            this.groupBoxNavi.Controls.Add(this.buttonNaviRight);
            this.groupBoxNavi.Controls.Add(this.buttonNaviReset);
            this.groupBoxNavi.Controls.Add(this.buttonNavi21);
            this.groupBoxNavi.Controls.Add(this.buttonNavi12);
            this.groupBoxNavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxNavi.Location = new System.Drawing.Point(749, 5);
            this.groupBoxNavi.Name = "groupBoxNavi";
            this.groupBoxNavi.Size = new System.Drawing.Size(174, 188);
            this.groupBoxNavi.TabIndex = 2;
            this.groupBoxNavi.TabStop = false;
            this.groupBoxNavi.Text = "Scene view";
            // 
            // buttonNaviUp
            // 
            this.buttonNaviUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNaviUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonNaviUp.Image")));
            this.buttonNaviUp.Location = new System.Drawing.Point(72, 82);
            this.buttonNaviUp.Name = "buttonNaviUp";
            this.buttonNaviUp.Size = new System.Drawing.Size(32, 34);
            this.buttonNaviUp.TabIndex = 3;
            this.buttonNaviUp.UseVisualStyleBackColor = true;
            this.buttonNaviUp.Click += new System.EventHandler(this.buttonNaviUp_Click);
            // 
            // buttonNaviDown
            // 
            this.buttonNaviDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNaviDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonNaviDown.Image")));
            this.buttonNaviDown.Location = new System.Drawing.Point(73, 151);
            this.buttonNaviDown.Name = "buttonNaviDown";
            this.buttonNaviDown.Size = new System.Drawing.Size(31, 32);
            this.buttonNaviDown.TabIndex = 7;
            this.buttonNaviDown.UseVisualStyleBackColor = true;
            this.buttonNaviDown.Click += new System.EventHandler(this.buttonNaviDown_Click);
            // 
            // buttonNaviLeft
            // 
            this.buttonNaviLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNaviLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonNaviLeft.Image")));
            this.buttonNaviLeft.Location = new System.Drawing.Point(40, 117);
            this.buttonNaviLeft.Name = "buttonNaviLeft";
            this.buttonNaviLeft.Size = new System.Drawing.Size(32, 33);
            this.buttonNaviLeft.TabIndex = 4;
            this.buttonNaviLeft.UseVisualStyleBackColor = true;
            this.buttonNaviLeft.Click += new System.EventHandler(this.buttonNaviLeft_Click);
            // 
            // buttonNaviRight
            // 
            this.buttonNaviRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNaviRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonNaviRight.Image")));
            this.buttonNaviRight.Location = new System.Drawing.Point(105, 117);
            this.buttonNaviRight.Name = "buttonNaviRight";
            this.buttonNaviRight.Size = new System.Drawing.Size(32, 33);
            this.buttonNaviRight.TabIndex = 6;
            this.buttonNaviRight.UseVisualStyleBackColor = true;
            this.buttonNaviRight.Click += new System.EventHandler(this.buttonNaviRight_Click);
            // 
            // buttonNaviReset
            // 
            this.buttonNaviReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNaviReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonNaviReset.Image")));
            this.buttonNaviReset.Location = new System.Drawing.Point(73, 117);
            this.buttonNaviReset.Name = "buttonNaviReset";
            this.buttonNaviReset.Size = new System.Drawing.Size(31, 33);
            this.buttonNaviReset.TabIndex = 5;
            this.buttonNaviReset.UseVisualStyleBackColor = true;
            this.buttonNaviReset.Click += new System.EventHandler(this.buttonNaviReset_Click);
            // 
            // buttonNavi21
            // 
            this.buttonNavi21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNavi21.Location = new System.Drawing.Point(91, 26);
            this.buttonNavi21.Name = "buttonNavi21";
            this.buttonNavi21.Size = new System.Drawing.Size(65, 50);
            this.buttonNavi21.TabIndex = 2;
            this.buttonNavi21.Text = "Scale 2:1";
            this.buttonNavi21.UseVisualStyleBackColor = true;
            this.buttonNavi21.Click += new System.EventHandler(this.buttonNavi21_Click);
            // 
            // buttonNavi12
            // 
            this.buttonNavi12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNavi12.Location = new System.Drawing.Point(20, 26);
            this.buttonNavi12.Name = "buttonNavi12";
            this.buttonNavi12.Size = new System.Drawing.Size(65, 50);
            this.buttonNavi12.TabIndex = 1;
            this.buttonNavi12.Text = "Scale 1:2";
            this.buttonNavi12.UseVisualStyleBackColor = true;
            this.buttonNavi12.Click += new System.EventHandler(this.buttonNavi12_Click);
            // 
            // groupBoxPoint
            // 
            this.groupBoxPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPoint.Controls.Add(this.buttonPoint);
            this.groupBoxPoint.Controls.Add(this.labelPoint);
            this.groupBoxPoint.Controls.Add(this.numericUpDownPoint);
            this.groupBoxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPoint.Location = new System.Drawing.Point(749, 364);
            this.groupBoxPoint.Name = "groupBoxPoint";
            this.groupBoxPoint.Size = new System.Drawing.Size(174, 94);
            this.groupBoxPoint.TabIndex = 5;
            this.groupBoxPoint.TabStop = false;
            this.groupBoxPoint.Text = "Breakpoint mode";
            // 
            // buttonPoint
            // 
            this.buttonPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonPoint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPoint.Image")));
            this.buttonPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPoint.Location = new System.Drawing.Point(15, 57);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(143, 26);
            this.buttonPoint.TabIndex = 2;
            this.buttonPoint.Text = "  Choose color";
            this.buttonPoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // labelPoint
            // 
            this.labelPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint.Location = new System.Drawing.Point(29, 25);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(87, 15);
            this.labelPoint.TabIndex = 22;
            this.labelPoint.Text = "Point size";
            // 
            // numericUpDownPoint
            // 
            this.numericUpDownPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownPoint.Location = new System.Drawing.Point(121, 22);
            this.numericUpDownPoint.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPoint.Name = "numericUpDownPoint";
            this.numericUpDownPoint.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownPoint.TabIndex = 1;
            this.numericUpDownPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPoint.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPoint.ValueChanged += new System.EventHandler(this.numericUpDownPoint_ValueChanged);
            // 
            // groupBoxGraph
            // 
            this.groupBoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGraph.Controls.Add(this.labelGraph);
            this.groupBoxGraph.Controls.Add(this.numericUpDownGraph);
            this.groupBoxGraph.Controls.Add(this.buttonGraph);
            this.groupBoxGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGraph.Location = new System.Drawing.Point(749, 269);
            this.groupBoxGraph.Name = "groupBoxGraph";
            this.groupBoxGraph.Size = new System.Drawing.Size(174, 95);
            this.groupBoxGraph.TabIndex = 4;
            this.groupBoxGraph.TabStop = false;
            this.groupBoxGraph.Text = "Graph mode";
            // 
            // labelGraph
            // 
            this.labelGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGraph.AutoSize = true;
            this.labelGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraph.Location = new System.Drawing.Point(17, 26);
            this.labelGraph.Name = "labelGraph";
            this.labelGraph.Size = new System.Drawing.Size(96, 15);
            this.labelGraph.TabIndex = 22;
            this.labelGraph.Text = "Line size";
            // 
            // numericUpDownGraph
            // 
            this.numericUpDownGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownGraph.Location = new System.Drawing.Point(121, 23);
            this.numericUpDownGraph.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGraph.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGraph.Name = "numericUpDownGraph";
            this.numericUpDownGraph.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownGraph.TabIndex = 1;
            this.numericUpDownGraph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownGraph.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownGraph.ValueChanged += new System.EventHandler(this.numericUpDownGraph_ValueChanged);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonGraph.Image = ((System.Drawing.Image)(resources.GetObject("buttonGraph.Image")));
            this.buttonGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGraph.Location = new System.Drawing.Point(17, 55);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(143, 26);
            this.buttonGraph.TabIndex = 2;
            this.buttonGraph.Text = "   Choose color";
            this.buttonGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // groupBoxSmooth
            // 
            this.groupBoxSmooth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSmooth.Controls.Add(this.radioButtonSmoothOn1);
            this.groupBoxSmooth.Controls.Add(this.radioButtonSmoothOff);
            this.groupBoxSmooth.Controls.Add(this.radioButtonSmoothOn2);
            this.groupBoxSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSmooth.Location = new System.Drawing.Point(749, 193);
            this.groupBoxSmooth.Name = "groupBoxSmooth";
            this.groupBoxSmooth.Size = new System.Drawing.Size(174, 76);
            this.groupBoxSmooth.TabIndex = 6;
            this.groupBoxSmooth.TabStop = false;
            this.groupBoxSmooth.Text = "Smooth mode";
            // 
            // radioButtonSmoothOn1
            // 
            this.radioButtonSmoothOn1.AutoSize = true;
            this.radioButtonSmoothOn1.Checked = true;
            this.radioButtonSmoothOn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSmoothOn1.Location = new System.Drawing.Point(28, 36);
            this.radioButtonSmoothOn1.Name = "radioButtonSmoothOn1";
            this.radioButtonSmoothOn1.Size = new System.Drawing.Size(80, 17);
            this.radioButtonSmoothOn1.TabIndex = 2;
            this.radioButtonSmoothOn1.TabStop = true;
            this.radioButtonSmoothOn1.Text = "On (points)";
            this.radioButtonSmoothOn1.UseVisualStyleBackColor = true;
            this.radioButtonSmoothOn1.CheckedChanged += new System.EventHandler(this.radioButtonSmoothOn1_CheckedChanged);
            // 
            // radioButtonSmoothOff
            // 
            this.radioButtonSmoothOff.AutoSize = true;
            this.radioButtonSmoothOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSmoothOff.Location = new System.Drawing.Point(28, 19);
            this.radioButtonSmoothOff.Name = "radioButtonSmoothOff";
            this.radioButtonSmoothOff.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSmoothOff.TabIndex = 1;
            this.radioButtonSmoothOff.Text = "Off";
            this.radioButtonSmoothOff.UseVisualStyleBackColor = true;
            this.radioButtonSmoothOff.CheckedChanged += new System.EventHandler(this.radioButtonSmoothOff_CheckedChanged);
            // 
            // radioButtonSmoothOn2
            // 
            this.radioButtonSmoothOn2.AutoSize = true;
            this.radioButtonSmoothOn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSmoothOn2.Location = new System.Drawing.Point(28, 53);
            this.radioButtonSmoothOn2.Name = "radioButtonSmoothOn2";
            this.radioButtonSmoothOn2.Size = new System.Drawing.Size(122, 17);
            this.radioButtonSmoothOn2.TabIndex = 0;
            this.radioButtonSmoothOn2.Text = "On (points and lines)";
            this.radioButtonSmoothOn2.UseVisualStyleBackColor = true;
            this.radioButtonSmoothOn2.CheckedChanged += new System.EventHandler(this.radioButtonSmoothOn2_CheckedChanged);
            // 
            // groupBoxLine
            // 
            this.groupBoxLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLine.Controls.Add(this.comboBoxLine);
            this.groupBoxLine.Controls.Add(this.checkBoxLine);
            this.groupBoxLine.Controls.Add(this.buttonLine);
            this.groupBoxLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxLine.Location = new System.Drawing.Point(749, 458);
            this.groupBoxLine.Name = "groupBoxLine";
            this.groupBoxLine.Size = new System.Drawing.Size(174, 109);
            this.groupBoxLine.TabIndex = 7;
            this.groupBoxLine.TabStop = false;
            this.groupBoxLine.Text = "Guide line mode";
            // 
            // comboBoxLine
            // 
            this.comboBoxLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLine.FormattingEnabled = true;
            this.comboBoxLine.Items.AddRange(new object[] {
            "Solid",
            "Dotted",
            "Dashed",
            "Dash-doted"});
            this.comboBoxLine.Location = new System.Drawing.Point(15, 21);
            this.comboBoxLine.Name = "comboBoxLine";
            this.comboBoxLine.Size = new System.Drawing.Size(143, 21);
            this.comboBoxLine.TabIndex = 24;
            this.comboBoxLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxLine_SelectedIndexChanged);
            // 
            // checkBoxLine
            // 
            this.checkBoxLine.AutoSize = true;
            this.checkBoxLine.Checked = true;
            this.checkBoxLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLine.Location = new System.Drawing.Point(19, 50);
            this.checkBoxLine.Name = "checkBoxLine";
            this.checkBoxLine.Size = new System.Drawing.Size(136, 19);
            this.checkBoxLine.TabIndex = 23;
            this.checkBoxLine.Text = "Show broken line";
            this.checkBoxLine.UseVisualStyleBackColor = true;
            this.checkBoxLine.CheckedChanged += new System.EventHandler(this.checkBoxLine_CheckedChanged);
            // 
            // buttonLine
            // 
            this.buttonLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLine.Location = new System.Drawing.Point(15, 76);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(143, 26);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "  Choose color";
            this.buttonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGrid.Controls.Add(this.labelGridSize);
            this.groupBoxGrid.Controls.Add(this.comboBoxGrid);
            this.groupBoxGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGrid.Location = new System.Drawing.Point(571, 508);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(173, 59);
            this.groupBoxGrid.TabIndex = 6;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Grid view";
            // 
            // labelGridSize
            // 
            this.labelGridSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGridSize.AutoSize = true;
            this.labelGridSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGridSize.Location = new System.Drawing.Point(9, 30);
            this.labelGridSize.Name = "labelGridSize";
            this.labelGridSize.Size = new System.Drawing.Size(78, 13);
            this.labelGridSize.TabIndex = 28;
            this.labelGridSize.Text = "Grid size";
            // 
            // comboBoxGrid
            // 
            this.comboBoxGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrid.FormattingEnabled = true;
            this.comboBoxGrid.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "200"});
            this.comboBoxGrid.Location = new System.Drawing.Point(95, 26);
            this.comboBoxGrid.Name = "comboBoxGrid";
            this.comboBoxGrid.Size = new System.Drawing.Size(72, 21);
            this.comboBoxGrid.TabIndex = 27;
            this.comboBoxGrid.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrid_SelectedIndexChanged);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPosXn,
            this.toolStripStatusLabelPosXv,
            this.toolStripStatusLabelPosYn,
            this.toolStripStatusLabelPosYv,
            this.toolStripStatusLabelBreak1,
            this.toolStripStatusLabelScaleXYn,
            this.toolStripStatusLabelScaleXYv,
            this.toolStripStatusLabelBreak2,
            this.toolStripStatusLabelShiftXn,
            this.toolStripStatusLabelShiftXv,
            this.toolStripStatusLabelShiftYn,
            this.toolStripStatusLabelShiftYv,
            this.toolStripStatusLabelBreak3,
            this.toolStripStatusLabelVerOpengl,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelVerSharpgl,
            this.toolStripStatusLabelAbout});
            this.statusStripMain.Location = new System.Drawing.Point(0, 568);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(929, 24);
            this.statusStripMain.TabIndex = 8;
            this.statusStripMain.Text = "Status";
            // 
            // toolStripStatusLabelPosXn
            // 
            this.toolStripStatusLabelPosXn.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabelPosXn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelPosXn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabelPosXn.Name = "toolStripStatusLabelPosXn";
            this.toolStripStatusLabelPosXn.Size = new System.Drawing.Size(25, 19);
            this.toolStripStatusLabelPosXn.Text = "X =";
            this.toolStripStatusLabelPosXn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelPosXv
            // 
            this.toolStripStatusLabelPosXv.AutoSize = false;
            this.toolStripStatusLabelPosXv.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPosXv.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabelPosXv.Name = "toolStripStatusLabelPosXv";
            this.toolStripStatusLabelPosXv.Size = new System.Drawing.Size(35, 19);
            this.toolStripStatusLabelPosXv.Text = "0000";
            this.toolStripStatusLabelPosXv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelPosYn
            // 
            this.toolStripStatusLabelPosYn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelPosYn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelPosYn.Image")));
            this.toolStripStatusLabelPosYn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStatusLabelPosYn.Name = "toolStripStatusLabelPosYn";
            this.toolStripStatusLabelPosYn.Size = new System.Drawing.Size(31, 19);
            this.toolStripStatusLabelPosYn.Text = "  Y =";
            this.toolStripStatusLabelPosYn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelPosYv
            // 
            this.toolStripStatusLabelPosYv.AutoSize = false;
            this.toolStripStatusLabelPosYv.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPosYv.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabelPosYv.Name = "toolStripStatusLabelPosYv";
            this.toolStripStatusLabelPosYv.Size = new System.Drawing.Size(35, 19);
            this.toolStripStatusLabelPosYv.Text = "0000";
            this.toolStripStatusLabelPosYv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelBreak1
            // 
            this.toolStripStatusLabelBreak1.Name = "toolStripStatusLabelBreak1";
            this.toolStripStatusLabelBreak1.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabelBreak1.Spring = true;
            // 
            // toolStripStatusLabelScaleXYn
            // 
            this.toolStripStatusLabelScaleXYn.Name = "toolStripStatusLabelScaleXYn";
            this.toolStripStatusLabelScaleXYn.Size = new System.Drawing.Size(70, 19);
            this.toolStripStatusLabelScaleXYn.Text = "Scale =";
            this.toolStripStatusLabelScaleXYn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelScaleXYv
            // 
            this.toolStripStatusLabelScaleXYv.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelScaleXYv.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabelScaleXYv.Name = "toolStripStatusLabelScaleXYv";
            this.toolStripStatusLabelScaleXYv.Size = new System.Drawing.Size(32, 19);
            this.toolStripStatusLabelScaleXYv.Text = "1 : 1";
            // 
            // toolStripStatusLabelBreak2
            // 
            this.toolStripStatusLabelBreak2.Name = "toolStripStatusLabelBreak2";
            this.toolStripStatusLabelBreak2.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabelBreak2.Spring = true;
            // 
            // toolStripStatusLabelShiftXn
            // 
            this.toolStripStatusLabelShiftXn.Name = "toolStripStatusLabelShiftXn";
            this.toolStripStatusLabelShiftXn.Size = new System.Drawing.Size(83, 19);
            this.toolStripStatusLabelShiftXn.Text = "x shift=";
            this.toolStripStatusLabelShiftXn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabelShiftXv
            // 
            this.toolStripStatusLabelShiftXv.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelShiftXv.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabelShiftXv.Name = "toolStripStatusLabelShiftXv";
            this.toolStripStatusLabelShiftXv.Size = new System.Drawing.Size(17, 19);
            this.toolStripStatusLabelShiftXv.Text = "0";
            // 
            // toolStripStatusLabelShiftYn
            // 
            this.toolStripStatusLabelShiftYn.Name = "toolStripStatusLabelShiftYn";
            this.toolStripStatusLabelShiftYn.Size = new System.Drawing.Size(89, 19);
            this.toolStripStatusLabelShiftYn.Text = "  y shift=";
            // 
            // toolStripStatusLabelShiftYv
            // 
            this.toolStripStatusLabelShiftYv.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelShiftYv.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabelShiftYv.Name = "toolStripStatusLabelShiftYv";
            this.toolStripStatusLabelShiftYv.Size = new System.Drawing.Size(17, 19);
            this.toolStripStatusLabelShiftYv.Text = "0";
            // 
            // toolStripStatusLabelBreak3
            // 
            this.toolStripStatusLabelBreak3.Name = "toolStripStatusLabelBreak3";
            this.toolStripStatusLabelBreak3.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabelBreak3.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusLabel2.LinkColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabelAbout
            // 
            this.toolStripStatusLabelAbout.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelAbout.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabelAbout.IsLink = true;
            this.toolStripStatusLabelAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusLabelAbout.LinkColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabelAbout.Name = "toolStripStatusLabelAbout";
            this.toolStripStatusLabelAbout.Size = new System.Drawing.Size(50, 19);
            this.toolStripStatusLabelAbout.Text = " About ";
            this.toolStripStatusLabelAbout.Click += new System.EventHandler(this.toolStripStatusLabelAbout_Click);
            // 
            // GL
            // 
            this.GL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GL.BackColor = System.Drawing.SystemColors.Info;
            this.GL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GL.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GL.DrawFPS = false;
            this.GL.Location = new System.Drawing.Point(0, 2);
            this.GL.Name = "GL";
            this.GL.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL1_4;
            this.GL.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.GL.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.GL.Size = new System.Drawing.Size(565, 565);
            this.GL.TabIndex = 0;
            this.GL.OpenGLInitialized += new System.EventHandler(this.GL_OpenGLInitialized);
            this.GL.OpenGLDraw += new SharpGL.RenderEventHandler(this.GL_OpenGLDraw);
            this.GL.Resized += new System.EventHandler(this.GL_Resized);
            this.GL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GL_MouseClick);
            this.GL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GL_MouseMove);
            // 
            // toolStripStatusLabelVerSharpgl
            // 
            this.toolStripStatusLabelVerSharpgl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelVerSharpgl.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabelVerSharpgl.IsLink = true;
            this.toolStripStatusLabelVerSharpgl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusLabelVerSharpgl.LinkColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabelVerSharpgl.Name = "toolStripStatusLabelVerSharpgl";
            this.toolStripStatusLabelVerSharpgl.Size = new System.Drawing.Size(97, 19);
            this.toolStripStatusLabelVerSharpgl.Text = "SharpGL version";
            this.toolStripStatusLabelVerSharpgl.Click += new System.EventHandler(this.toolStripStatusLabelVerSharpgl_Click);
            // 
            // toolStripStatusLabelVerOpengl
            // 
            this.toolStripStatusLabelVerOpengl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelVerOpengl.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabelVerOpengl.IsLink = true;
            this.toolStripStatusLabelVerOpengl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusLabelVerOpengl.LinkColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabelVerOpengl.Name = "toolStripStatusLabelVerOpengl";
            this.toolStripStatusLabelVerOpengl.Size = new System.Drawing.Size(96, 19);
            this.toolStripStatusLabelVerOpengl.Text = "OpenGL version";
            this.toolStripStatusLabelVerOpengl.Click += new System.EventHandler(this.toolStripStatusLabelVerOpengl_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 592);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBoxGrid);
            this.Controls.Add(this.groupBoxLine);
            this.Controls.Add(this.groupBoxSmooth);
            this.Controls.Add(this.groupBoxGraph);
            this.Controls.Add(this.groupBoxPoint);
            this.Controls.Add(this.groupBoxNavi);
            this.Controls.Add(this.groupBoxVertex);
            this.Controls.Add(this.GL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(937, 619);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bézier curve creation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxVertex.ResumeLayout(false);
            this.groupBoxVertex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVertex)).EndInit();
            this.groupBoxNavi.ResumeLayout(false);
            this.groupBoxPoint.ResumeLayout(false);
            this.groupBoxPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).EndInit();
            this.groupBoxGraph.ResumeLayout(false);
            this.groupBoxGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph)).EndInit();
            this.groupBoxSmooth.ResumeLayout(false);
            this.groupBoxSmooth.PerformLayout();
            this.groupBoxLine.ResumeLayout(false);
            this.groupBoxLine.PerformLayout();
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxVertex;
        private System.Windows.Forms.Button buttonVertexSingle;
        private System.Windows.Forms.Button buttonVertexAll;
        private System.Windows.Forms.CheckBox checkBoxVertex;
        private System.Windows.Forms.GroupBox groupBoxNavi;
        private System.Windows.Forms.Button buttonNavi21;
        private System.Windows.Forms.Button buttonNavi12;
        private System.Windows.Forms.Button buttonNaviReset;
        private System.Windows.Forms.Button buttonNaviRight;
        private System.Windows.Forms.Button buttonNaviUp;
        private System.Windows.Forms.Button buttonNaviDown;
        private System.Windows.Forms.Button buttonNaviLeft;
        private System.Windows.Forms.GroupBox groupBoxPoint;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownPoint;
        private System.Windows.Forms.GroupBox groupBoxGraph;
        private System.Windows.Forms.Label labelGraph;
        private System.Windows.Forms.NumericUpDown numericUpDownGraph;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.GroupBox groupBoxSmooth;
        private System.Windows.Forms.RadioButton radioButtonSmoothOff;
        private System.Windows.Forms.RadioButton radioButtonSmoothOn1;
        private System.Windows.Forms.RadioButton radioButtonSmoothOn2;
        private System.Windows.Forms.GroupBox groupBoxLine;
        private System.Windows.Forms.ComboBox comboBoxLine;
        private System.Windows.Forms.CheckBox checkBoxLine;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.ColorDialog colorDialogMain;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.ComboBox comboBoxGrid;
        private System.Windows.Forms.Label labelGridSize;
        private System.Windows.Forms.DataGridView dataGridViewVertex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPosXn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPosXv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPosYn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPosYv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelScaleXYn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelScaleXYv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShiftXn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShiftXv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShiftYn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShiftYv;
        private SharpGL.OpenGLControl GL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAbout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBreak1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBreak2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBreak3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVerOpengl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVerSharpgl;
    }
}

