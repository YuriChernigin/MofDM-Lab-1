namespace lab1MPR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlotSockets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlotMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlotsForCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numUpDPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numUpDSlotCard = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numUpDMaxMem = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numUpDSlotMem = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUpDSocket = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSolution = new System.Windows.Forms.Button();
            this.txtBoxOutPut = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPrice)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSlotCard)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMaxMem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSlotMem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSocket)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // MenuFile
            // 
            this.MenuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileOpen});
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(52, 22);
            this.MenuFile.Text = "Файл";
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(121, 22);
            this.MenuFileOpen.Text = "Открыть";
            this.MenuFileOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStrip
            // 
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(23, 23);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.14713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.85287F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 391);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableData
            // 
            this.tableData.AllowUserToAddRows = false;
            this.tableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSlotSockets,
            this.ColumnSlotMemory,
            this.ColumnMaxMemory,
            this.ColumnSlotsForCard,
            this.ColumnPrice});
            this.tableData.Location = new System.Drawing.Point(3, 3);
            this.tableData.MultiSelect = false;
            this.tableData.Name = "tableData";
            this.tableData.ReadOnly = true;
            this.tableData.RowHeadersWidth = 43;
            this.tableData.Size = new System.Drawing.Size(804, 154);
            this.tableData.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 182.7411F;
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSlotSockets
            // 
            this.ColumnSlotSockets.FillWeight = 83.4518F;
            this.ColumnSlotSockets.HeaderText = "Количество сокетов";
            this.ColumnSlotSockets.Name = "ColumnSlotSockets";
            this.ColumnSlotSockets.ReadOnly = true;
            // 
            // ColumnSlotMemory
            // 
            this.ColumnSlotMemory.FillWeight = 83.4518F;
            this.ColumnSlotMemory.HeaderText = "Кол-во слотов для расширения памяти";
            this.ColumnSlotMemory.Name = "ColumnSlotMemory";
            this.ColumnSlotMemory.ReadOnly = true;
            // 
            // ColumnMaxMemory
            // 
            this.ColumnMaxMemory.FillWeight = 83.4518F;
            this.ColumnMaxMemory.HeaderText = "Максимальная память";
            this.ColumnMaxMemory.Name = "ColumnMaxMemory";
            this.ColumnMaxMemory.ReadOnly = true;
            // 
            // ColumnSlotsForCard
            // 
            this.ColumnSlotsForCard.FillWeight = 83.4518F;
            this.ColumnSlotsForCard.HeaderText = "Кол-во слотов для карт расширения";
            this.ColumnSlotsForCard.Name = "ColumnSlotsForCard";
            this.ColumnSlotsForCard.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.FillWeight = 83.4518F;
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.07353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.92647F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 225);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(302, 205);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.numUpDPrice);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(3, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 29);
            this.panel5.TabIndex = 5;
            // 
            // numUpDPrice
            // 
            this.numUpDPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDPrice.Location = new System.Drawing.Point(214, 2);
            this.numUpDPrice.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDPrice.Name = "numUpDPrice";
            this.numUpDPrice.Size = new System.Drawing.Size(75, 20);
            this.numUpDPrice.TabIndex = 1;
            this.numUpDPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Цена:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.numUpDSlotCard);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 33);
            this.panel4.TabIndex = 4;
            // 
            // numUpDSlotCard
            // 
            this.numUpDSlotCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDSlotCard.Location = new System.Drawing.Point(214, 4);
            this.numUpDSlotCard.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDSlotCard.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDSlotCard.Name = "numUpDSlotCard";
            this.numUpDSlotCard.Size = new System.Drawing.Size(75, 20);
            this.numUpDSlotCard.TabIndex = 1;
            this.numUpDSlotCard.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Кол-во слотов для карт расширения:\r\n";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.numUpDMaxMem);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 31);
            this.panel3.TabIndex = 3;
            // 
            // numUpDMaxMem
            // 
            this.numUpDMaxMem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDMaxMem.Location = new System.Drawing.Point(214, 3);
            this.numUpDMaxMem.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDMaxMem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDMaxMem.Name = "numUpDMaxMem";
            this.numUpDMaxMem.Size = new System.Drawing.Size(75, 20);
            this.numUpDMaxMem.TabIndex = 1;
            this.numUpDMaxMem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Максимальная память:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.numUpDSlotMem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 28);
            this.panel2.TabIndex = 2;
            // 
            // numUpDSlotMem
            // 
            this.numUpDSlotMem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDSlotMem.Location = new System.Drawing.Point(214, 2);
            this.numUpDSlotMem.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDSlotMem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDSlotMem.Name = "numUpDSlotMem";
            this.numUpDSlotMem.Size = new System.Drawing.Size(75, 20);
            this.numUpDSlotMem.TabIndex = 1;
            this.numUpDSlotMem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Кол-во слотов для расширения памяти:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оцените важность каждого критерия по девятибальной шкале";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.numUpDSocket);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 28);
            this.panel1.TabIndex = 1;
            // 
            // numUpDSocket
            // 
            this.numUpDSocket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDSocket.Location = new System.Drawing.Point(214, 2);
            this.numUpDSocket.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDSocket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDSocket.Name = "numUpDSocket";
            this.numUpDSocket.Size = new System.Drawing.Size(75, 20);
            this.numUpDSocket.TabIndex = 1;
            this.numUpDSocket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кол-во сокетов:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(325, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnSolution, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBoxOutPut, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.60976F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.39024F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(464, 205);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnSolution
            // 
            this.btnSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolution.Location = new System.Drawing.Point(3, 3);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(458, 26);
            this.btnSolution.TabIndex = 0;
            this.btnSolution.Text = "Решать";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.SolutionClick);
            // 
            // txtBoxOutPut
            // 
            this.txtBoxOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutPut.Location = new System.Drawing.Point(3, 35);
            this.txtBoxOutPut.Name = "txtBoxOutPut";
            this.txtBoxOutPut.ReadOnly = true;
            this.txtBoxOutPut.Size = new System.Drawing.Size(458, 167);
            this.txtBoxOutPut.TabIndex = 1;
            this.txtBoxOutPut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSlotCard)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMaxMem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSlotMem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSocket)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView tableData;
        private System.Windows.Forms.ToolStripSplitButton MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSlotSockets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSlotMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSlotsForCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numUpDPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numUpDSlotCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numUpDMaxMem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numUpDSlotMem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numUpDSocket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.RichTextBox txtBoxOutPut;
    }
}

