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
            this.toolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuFile = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlotSockets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlotMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlotsForCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.54181F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.45819F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 320);
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
            this.tableData.Size = new System.Drawing.Size(598, 194);
            this.tableData.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(598, 114);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.MenuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.MenuFileOpen.Text = "Открыть";
            this.MenuFileOpen.Click += new System.EventHandler(this.OpenFile);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
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
    }
}

