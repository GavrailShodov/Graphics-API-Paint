namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.BorderPalete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.widthLabel = new System.Windows.Forms.ToolStripLabel();
            this.widthBox = new System.Windows.Forms.ToolStripTextBox();
            this.heightLabel = new System.Windows.Forms.ToolStripLabel();
            this.heightBox = new System.Windows.Forms.ToolStripTextBox();
            this.BorderSize = new System.Windows.Forms.ToolStripLabel();
            this.BorderText = new System.Windows.Forms.ToolStripTextBox();
            this.MoveUpButton = new System.Windows.Forms.ToolStripButton();
            this.MoveDownButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.GroupButton = new System.Windows.Forms.ToolStripButton();
            this.UngroupButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.FigureButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1304, 30);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel,
            this.toolStripStatusLabel2});
            this.statusBar.Location = new System.Drawing.Point(0, 495);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1304, 26);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectButton,
            this.Line,
            this.drawRectangleSpeedButton,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.BorderPalete,
            this.toolStripButton4,
            this.deleteButton,
            this.editButton,
            this.widthLabel,
            this.widthBox,
            this.heightLabel,
            this.heightBox,
            this.BorderSize,
            this.BorderText,
            this.MoveUpButton,
            this.MoveDownButton,
            this.toolStripButton5,
            this.GroupButton,
            this.UngroupButton,
            this.FigureButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 30);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(1304, 31);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // selectButton
            // 
            this.selectButton.CheckOnClick = true;
            this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectButton.Image = ((System.Drawing.Image)(resources.GetObject("selectButton.Image")));
            this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(29, 28);
            this.selectButton.Text = "selectButton";
            this.selectButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // Line
            // 
            this.Line.CheckOnClick = true;
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(29, 28);
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "DrawElipseButton";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "drawEllipseButton";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "FillPalete";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // BorderPalete
            // 
            this.BorderPalete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorderPalete.Image = ((System.Drawing.Image)(resources.GetObject("BorderPalete.Image")));
            this.BorderPalete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorderPalete.Name = "BorderPalete";
            this.BorderPalete.Size = new System.Drawing.Size(29, 28);
            this.BorderPalete.Text = "BorderPalete";
            this.BorderPalete.Click += new System.EventHandler(this.BorderPalete_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.CheckOnClick = true;
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(29, 28);
            this.deleteButton.Text = "deleteButton";
            this.deleteButton.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // editButton
            // 
            this.editButton.CheckOnClick = true;
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(29, 28);
            this.editButton.Text = "editButton";
            this.editButton.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // widthLabel
            // 
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(49, 28);
            this.widthLabel.Text = "Width";
            this.widthLabel.Visible = false;
            this.widthLabel.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // widthBox
            // 
            this.widthBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(132, 31);
            this.widthBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.widthBox.Visible = false;
            this.widthBox.Click += new System.EventHandler(this.widthBox_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(54, 28);
            this.heightLabel.Text = "Height";
            this.heightLabel.Visible = false;
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(132, 31);
            this.heightBox.Visible = false;
            // 
            // BorderSize
            // 
            this.BorderSize.Name = "BorderSize";
            this.BorderSize.Size = new System.Drawing.Size(81, 28);
            this.BorderSize.Text = "BorderSize";
            this.BorderSize.Visible = false;
            this.BorderSize.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
            // 
            // BorderText
            // 
            this.BorderText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BorderText.Name = "BorderText";
            this.BorderText.Size = new System.Drawing.Size(100, 31);
            this.BorderText.Visible = false;
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveUpButton.Image = ((System.Drawing.Image)(resources.GetObject("MoveUpButton.Image")));
            this.MoveUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(29, 28);
            this.MoveUpButton.Text = "MoveUpButton";
            this.MoveUpButton.Visible = false;
            this.MoveUpButton.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveDownButton.Image = ((System.Drawing.Image)(resources.GetObject("MoveDownButton.Image")));
            this.MoveDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(29, 28);
            this.MoveDownButton.Text = "MoveDownButton";
            this.MoveDownButton.Visible = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Visible = false;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_2);
            // 
            // GroupButton
            // 
            this.GroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupButton.Image = ((System.Drawing.Image)(resources.GetObject("GroupButton.Image")));
            this.GroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupButton.Name = "GroupButton";
            this.GroupButton.Size = new System.Drawing.Size(29, 28);
            this.GroupButton.Text = "GroupButton";
            this.GroupButton.Click += new System.EventHandler(this.GroupButton_Click);
            // 
            // UngroupButton
            // 
            this.UngroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UngroupButton.Image = ((System.Drawing.Image)(resources.GetObject("UngroupButton.Image")));
            this.UngroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupButton.Name = "UngroupButton";
            this.UngroupButton.Size = new System.Drawing.Size(29, 28);
            this.UngroupButton.Text = "UngroupButton";
            this.UngroupButton.Click += new System.EventHandler(this.UngroupButton_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 61);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1304, 434);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // FigureButton
            // 
            this.FigureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FigureButton.Image = ((System.Drawing.Image)(resources.GetObject("FigureButton.Image")));
            this.FigureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FigureButton.Name = "FigureButton";
            this.FigureButton.Size = new System.Drawing.Size(29, 28);
            this.FigureButton.Text = "FigureButton";
            this.FigureButton.Click += new System.EventHandler(this.toolStripButton6_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 521);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton selectButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripTextBox widthBox;
        private System.Windows.Forms.ToolStripLabel widthLabel;
        private System.Windows.Forms.ToolStripLabel heightLabel;
        private System.Windows.Forms.ToolStripTextBox heightBox;
        private System.Windows.Forms.ToolStripLabel BorderSize;
        private System.Windows.Forms.ToolStripTextBox BorderText;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton BorderPalete;
        private System.Windows.Forms.ToolStripButton MoveUpButton;
        private System.Windows.Forms.ToolStripButton MoveDownButton;
        private System.Windows.Forms.ToolStripButton GroupButton;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton UngroupButton;
        private System.Windows.Forms.ToolStripButton FigureButton;
    }
}
