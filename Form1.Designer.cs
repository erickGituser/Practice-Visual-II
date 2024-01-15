namespace PracticeOne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelCode = new Label();
            labelName = new Label();
            labelPrice = new Label();
            labelQuantity = new Label();
            textBoxCode = new TextBox();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            menuStrip2 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            orderExit = new ToolStripMenuItem();
            menuOperations = new ToolStripMenuItem();
            orderNew = new ToolStripMenuItem();
            orderSave = new ToolStripMenuItem();
            orderCancel = new ToolStripMenuItem();
            orderTotal = new ToolStripMenuItem();
            menuShow = new ToolStripMenuItem();
            orderShowToolBar = new ToolStripMenuItem();
            orderShowStatusBar = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            orderShowAbout = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            buttonFirst = new Button();
            buttonBack = new Button();
            buttonNext = new Button();
            buttonLast = new Button();
            toolTip1 = new ToolTip(components);
            toolStrip1 = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonCancel = new ToolStripButton();
            toolStripTextBoxSearch = new ToolStripTextBox();
            toolStripButtonSearch = new ToolStripButton();
            toolStripButtonAbout = new ToolStripButton();
            menuStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.ForeColor = SystemColors.ActiveCaptionText;
            labelCode.Location = new Point(131, 162);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(41, 19);
            labelCode.TabIndex = 0;
            labelCode.Text = "Code";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(131, 200);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 19);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.ForeColor = SystemColors.ActiveCaptionText;
            labelPrice.Location = new Point(131, 237);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 19);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.ForeColor = SystemColors.ActiveCaptionText;
            labelQuantity.Location = new Point(131, 272);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(62, 19);
            labelQuantity.TabIndex = 3;
            labelQuantity.Text = "Quantity";
            // 
            // textBoxCode
            // 
            textBoxCode.BackColor = SystemColors.ScrollBar;
            textBoxCode.ForeColor = SystemColors.MenuBar;
            textBoxCode.Location = new Point(199, 162);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(151, 26);
            textBoxCode.TabIndex = 4;
            textBoxCode.TextChanged += textBoxCode_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ScrollBar;
            textBoxName.ForeColor = SystemColors.MenuBar;
            textBoxName.Location = new Point(199, 200);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(279, 26);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.ScrollBar;
            textBoxPrice.ForeColor = SystemColors.MenuBar;
            textBoxPrice.Location = new Point(199, 237);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(74, 26);
            textBoxPrice.TabIndex = 6;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.BackColor = SystemColors.ScrollBar;
            textBoxQuantity.ForeColor = SystemColors.MenuBar;
            textBoxQuantity.Location = new Point(199, 272);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(74, 26);
            textBoxQuantity.TabIndex = 7;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuFile, menuOperations, menuShow, menuHelp });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(678, 24);
            menuStrip2.TabIndex = 9;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { orderExit });
            menuFile.Name = "menuFile";
            menuFile.ShortcutKeys = Keys.Control | Keys.X;
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "File";
            // 
            // orderExit
            // 
            orderExit.Name = "orderExit";
            orderExit.ShortcutKeys = Keys.Control | Keys.X;
            orderExit.Size = new Size(134, 22);
            orderExit.Text = "Exit";
            orderExit.Click += orderExit_Click;
            // 
            // menuOperations
            // 
            menuOperations.DropDownItems.AddRange(new ToolStripItem[] { orderNew, orderSave, orderCancel, orderTotal });
            menuOperations.Name = "menuOperations";
            menuOperations.Size = new Size(77, 20);
            menuOperations.Text = "Operations";
            // 
            // orderNew
            // 
            orderNew.Name = "orderNew";
            orderNew.ShortcutKeys = Keys.Control | Keys.N;
            orderNew.Size = new Size(191, 22);
            orderNew.Text = "New products";
            orderNew.Click += orderNew_Click;
            // 
            // orderSave
            // 
            orderSave.Name = "orderSave";
            orderSave.ShortcutKeys = Keys.Control | Keys.S;
            orderSave.Size = new Size(191, 22);
            orderSave.Text = "Save";
            // 
            // orderCancel
            // 
            orderCancel.Name = "orderCancel";
            orderCancel.ShortcutKeys = Keys.Control | Keys.C;
            orderCancel.Size = new Size(191, 22);
            orderCancel.Text = "Cancel";
            // 
            // orderTotal
            // 
            orderTotal.Name = "orderTotal";
            orderTotal.ShortcutKeys = Keys.Control | Keys.T;
            orderTotal.Size = new Size(191, 22);
            orderTotal.Text = "Total ";
            // 
            // menuShow
            // 
            menuShow.DropDownItems.AddRange(new ToolStripItem[] { orderShowToolBar, orderShowStatusBar });
            menuShow.Name = "menuShow";
            menuShow.Size = new Size(48, 20);
            menuShow.Text = "Show";
            // 
            // orderShowToolBar
            // 
            orderShowToolBar.CheckOnClick = true;
            orderShowToolBar.Name = "orderShowToolBar";
            orderShowToolBar.ShortcutKeys = Keys.Control | Keys.B;
            orderShowToolBar.Size = new Size(166, 22);
            orderShowToolBar.Text = "Tool Bar";
            // 
            // orderShowStatusBar
            // 
            orderShowStatusBar.CheckOnClick = true;
            orderShowStatusBar.Name = "orderShowStatusBar";
            orderShowStatusBar.ShortcutKeys = Keys.Control | Keys.E;
            orderShowStatusBar.Size = new Size(166, 22);
            orderShowStatusBar.Text = "Status Bar";
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { orderShowAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(44, 20);
            menuHelp.Text = "Help";
            // 
            // orderShowAbout
            // 
            orderShowAbout.Name = "orderShowAbout";
            orderShowAbout.ShortcutKeys = Keys.Control | Keys.A;
            orderShowAbout.Size = new Size(158, 22);
            orderShowAbout.Text = "About...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(678, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // buttonFirst
            // 
            buttonFirst.Enabled = false;
            buttonFirst.ForeColor = SystemColors.ControlDark;
            buttonFirst.Image = (Image)resources.GetObject("buttonFirst.Image");
            buttonFirst.Location = new Point(118, 336);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(75, 23);
            buttonFirst.TabIndex = 11;
            buttonFirst.Text = "First";
            buttonFirst.UseVisualStyleBackColor = true;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // buttonBack
            // 
            buttonBack.Enabled = false;
            buttonBack.ForeColor = SystemColors.ActiveBorder;
            buttonBack.Location = new Point(221, 336);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.ForeColor = SystemColors.ActiveBorder;
            buttonNext.Location = new Point(328, 336);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 13;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonLast
            // 
            buttonLast.Enabled = false;
            buttonLast.ForeColor = SystemColors.ActiveBorder;
            buttonLast.Location = new Point(444, 336);
            buttonLast.Name = "buttonLast";
            buttonLast.Size = new Size(75, 23);
            buttonLast.TabIndex = 14;
            buttonLast.Text = "Last";
            buttonLast.UseVisualStyleBackColor = true;
            buttonLast.Click += buttonLast_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ButtonHighlight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripButtonSave, toolStripButtonCancel, toolStripTextBoxSearch, toolStripButtonSearch, toolStripButtonAbout });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(678, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(23, 22);
            toolStripButtonNew.Text = "New";
            toolStripButtonNew.Click += toolStripButtonNew_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "Save";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripButtonCancel
            // 
            toolStripButtonCancel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCancel.Image = (Image)resources.GetObject("toolStripButtonCancel.Image");
            toolStripButtonCancel.ImageTransparentColor = Color.Magenta;
            toolStripButtonCancel.Name = "toolStripButtonCancel";
            toolStripButtonCancel.Size = new Size(23, 22);
            toolStripButtonCancel.Text = "Cancel";
            toolStripButtonCancel.Click += toolStripButtonCancel_Click;
            // 
            // toolStripTextBoxSearch
            // 
            toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            toolStripTextBoxSearch.Size = new Size(100, 25);
            toolStripTextBoxSearch.Text = "Search...";
            toolStripTextBoxSearch.Click += toolStripTextBoxSearch_Click;
            // 
            // toolStripButtonSearch
            // 
            toolStripButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSearch.Image = (Image)resources.GetObject("toolStripButtonSearch.Image");
            toolStripButtonSearch.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearch.Name = "toolStripButtonSearch";
            toolStripButtonSearch.Size = new Size(23, 22);
            toolStripButtonSearch.Text = "Search";
            toolStripButtonSearch.Click += toolStripButtonSearch_Click;
            // 
            // toolStripButtonAbout
            // 
            toolStripButtonAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAbout.Image = (Image)resources.GetObject("toolStripButtonAbout.Image");
            toolStripButtonAbout.ImageTransparentColor = Color.Magenta;
            toolStripButtonAbout.Name = "toolStripButtonAbout";
            toolStripButtonAbout.Size = new Size(23, 22);
            toolStripButtonAbout.Text = "About...";
            toolStripButtonAbout.Click += toolStripButtonAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(678, 447);
            Controls.Add(toolStrip1);
            Controls.Add(buttonLast);
            Controls.Add(buttonNext);
            Controls.Add(buttonBack);
            Controls.Add(buttonFirst);
            Controls.Add(statusStrip1);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(textBoxCode);
            Controls.Add(labelQuantity);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Controls.Add(labelCode);
            Controls.Add(menuStrip2);
            Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCode;
        private Label labelName;
        private Label labelPrice;
        private Label labelQuantity;
        private TextBox textBoxCode;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem orderExit;
        private ToolStripMenuItem menuOperations;
        private ToolStripMenuItem orderNew;
        private ToolStripMenuItem orderSave;
        private ToolStripMenuItem orderCancel;
        private ToolStripMenuItem orderTotal;
        private ToolStripMenuItem menuShow;
        private ToolStripMenuItem orderShowToolBar;
        private ToolStripMenuItem orderShowStatusBar;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem orderShowAbout;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private Button buttonFirst;
        private Button buttonBack;
        private Button buttonNext;
        private Button buttonLast;
        private ToolTip toolTip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonCancel;
        private ToolStripTextBox toolStripTextBoxSearch;
        private ToolStripButton toolStripButtonSearch;
        private ToolStripButton toolStripButtonAbout;
    }
}
