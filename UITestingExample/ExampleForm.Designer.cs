namespace UITestingExample
{
    partial class ExampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._addButton = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._colorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _addButton
            // 
            this._addButton.AccessibleName = "addButton";
            this._addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addButton.Location = new System.Drawing.Point(316, 3);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(94, 24);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.ClickAddButton);
            // 
            // _dataGridView
            // 
            this._dataGridView.AccessibleName = "dataGridView";
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this._dataGridView, 3);
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(3, 33);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.RowTemplate.Height = 24;
            this._dataGridView.Size = new System.Drawing.Size(407, 211);
            this._dataGridView.TabIndex = 1;
            this._dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.FormatDataGridViewCell);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // _colorLabel
            // 
            this._colorLabel.AccessibleName = "colorLabel";
            this._colorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._colorLabel.AutoSize = true;
            this._colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._colorLabel.Location = new System.Drawing.Point(103, 8);
            this._colorLabel.Name = "_colorLabel";
            this._colorLabel.Size = new System.Drawing.Size(207, 14);
            this._colorLabel.TabIndex = 3;
            this._colorLabel.Text = "Click me...";
            this._colorLabel.Click += new System.EventHandler(this.ClickColorLabel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this._addButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._colorLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 247);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._showMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _showMenuItem
            // 
            this._showMenuItem.AccessibleName = "showMenuItem";
            this._showMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._windowMenuItem});
            this._showMenuItem.Name = "_showMenuItem";
            this._showMenuItem.Size = new System.Drawing.Size(50, 20);
            this._showMenuItem.Text = "Show";
            // 
            // _windowMenuItem
            // 
            this._windowMenuItem.AccessibleName = "windowMenuItem";
            this._windowMenuItem.Name = "_windowMenuItem";
            this._windowMenuItem.Size = new System.Drawing.Size(152, 22);
            this._windowMenuItem.Text = "Window";
            this._windowMenuItem.Click += new System.EventHandler(this.ClickShowWindowMenu);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ExampleForm";
            this.Text = "UITestingExample";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _colorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _showMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _windowMenuItem;
    }
}

