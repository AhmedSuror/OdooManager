﻿namespace OdooManager.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            btnExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            btnNew = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtServer = new TextBox();
            label2 = new Label();
            txtDb = new TextBox();
            label3 = new Label();
            txtUser = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
            btnConnect = new Button();
            tabPage2 = new TabPage();
            dgSessions = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnLoadAllSessions = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txtSessionId = new ToolStripTextBox();
            btnFindSession = new ToolStripButton();
            lblSessionCount = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            btnDelSession = new ToolStripButton();
            tabPage3 = new TabPage();
            dgOrders = new DataGridView();
            toolStrip2 = new ToolStrip();
            btnAllOrders = new ToolStripButton();
            toolStripLabel3 = new ToolStripLabel();
            txtOrderId = new ToolStripTextBox();
            btnFindOrderById = new ToolStripButton();
            btnFindOrderBySID = new ToolStripButton();
            lblOrderCount = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel5 = new ToolStripLabel();
            btnDeleteOrder = new ToolStripButton();
            tabPage4 = new TabPage();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSessions).BeginInit();
            toolStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrders).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // btnExit
            // 
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 22);
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnNew });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // btnNew
            // 
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(190, 22);
            btnNew.Text = "Clear all search results";
            btnNew.Click += btnNew_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 426);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Database";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtServer, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDb, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtUser, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPass, 1, 3);
            tableLayoutPanel1.Controls.Add(btnConnect, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(786, 392);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Server (IP or FQDN):";
            // 
            // txtServer
            // 
            txtServer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtServer, 2);
            txtServer.Location = new Point(130, 3);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(653, 23);
            txtServer.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Database:";
            // 
            // txtDb
            // 
            txtDb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtDb, 2);
            txtDb.Location = new Point(130, 32);
            txtDb.Name = "txtDb";
            txtDb.Size = new Size(653, 23);
            txtDb.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(3, 65);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Username:";
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtUser, 2);
            txtUser.Location = new Point(130, 61);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(653, 23);
            txtUser.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtPass, 2);
            txtPass.Location = new Point(130, 90);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(653, 23);
            txtPass.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(659, 119);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(124, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Test connection";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgSessions);
            tabPage2.Controls.Add(toolStrip1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sessions";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgSessions
            // 
            dgSessions.AllowUserToAddRows = false;
            dgSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSessions.Dock = DockStyle.Fill;
            dgSessions.Location = new Point(3, 28);
            dgSessions.Name = "dgSessions";
            dgSessions.ReadOnly = true;
            dgSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSessions.Size = new Size(786, 367);
            dgSessions.TabIndex = 1;
            dgSessions.CellContentDoubleClick += dgSessions_CellContentDoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLoadAllSessions, toolStripLabel1, txtSessionId, btnFindSession, lblSessionCount, toolStripSeparator1, toolStripLabel2, btnDelSession });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Margin = new Padding(3, 0, 3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(786, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadAllSessions
            // 
            btnLoadAllSessions.BackColor = Color.Lime;
            btnLoadAllSessions.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnLoadAllSessions.Image = (Image)resources.GetObject("btnLoadAllSessions.Image");
            btnLoadAllSessions.ImageTransparentColor = Color.Magenta;
            btnLoadAllSessions.Margin = new Padding(3, 1, 3, 2);
            btnLoadAllSessions.Name = "btnLoadAllSessions";
            btnLoadAllSessions.Size = new Size(98, 22);
            btnLoadAllSessions.Text = "Load all sessions";
            btnLoadAllSessions.Click += btnLoadAllSessions_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripLabel1.Margin = new Padding(3, 1, 3, 2);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(72, 22);
            toolStripLabel1.Text = "Find session";
            // 
            // txtSessionId
            // 
            txtSessionId.BorderStyle = BorderStyle.FixedSingle;
            txtSessionId.Margin = new Padding(3, 0, 3, 0);
            txtSessionId.Name = "txtSessionId";
            txtSessionId.Size = new Size(100, 25);
            // 
            // btnFindSession
            // 
            btnFindSession.BackColor = Color.Green;
            btnFindSession.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFindSession.ForeColor = Color.White;
            btnFindSession.Image = (Image)resources.GetObject("btnFindSession.Image");
            btnFindSession.ImageTransparentColor = Color.Magenta;
            btnFindSession.Margin = new Padding(3, 1, 3, 2);
            btnFindSession.Name = "btnFindSession";
            btnFindSession.Size = new Size(34, 22);
            btnFindSession.Text = "Find";
            btnFindSession.Click += btnFindSession_Click;
            // 
            // lblSessionCount
            // 
            lblSessionCount.Alignment = ToolStripItemAlignment.Right;
            lblSessionCount.Name = "lblSessionCount";
            lblSessionCount.Size = new Size(13, 22);
            lblSessionCount.Text = "0";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(43, 22);
            toolStripLabel2.Text = "Count:";
            // 
            // btnDelSession
            // 
            btnDelSession.BackColor = Color.Red;
            btnDelSession.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelSession.ForeColor = Color.White;
            btnDelSession.Image = (Image)resources.GetObject("btnDelSession.Image");
            btnDelSession.ImageTransparentColor = Color.Magenta;
            btnDelSession.Margin = new Padding(3, 1, 3, 2);
            btnDelSession.Name = "btnDelSession";
            btnDelSession.Size = new Size(44, 22);
            btnDelSession.Text = "Delete";
            btnDelSession.Click += btnDelSession_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgOrders);
            tabPage3.Controls.Add(toolStrip2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgOrders
            // 
            dgOrders.AllowUserToAddRows = false;
            dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrders.Dock = DockStyle.Fill;
            dgOrders.Location = new Point(3, 28);
            dgOrders.Name = "dgOrders";
            dgOrders.ReadOnly = true;
            dgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrders.Size = new Size(786, 367);
            dgOrders.TabIndex = 3;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnAllOrders, toolStripLabel3, txtOrderId, btnFindOrderById, btnFindOrderBySID, lblOrderCount, toolStripSeparator2, toolStripLabel5, btnDeleteOrder });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(786, 25);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnAllOrders
            // 
            btnAllOrders.BackColor = Color.Lime;
            btnAllOrders.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAllOrders.Image = (Image)resources.GetObject("btnAllOrders.Image");
            btnAllOrders.ImageTransparentColor = Color.Magenta;
            btnAllOrders.Margin = new Padding(3, 1, 3, 2);
            btnAllOrders.Name = "btnAllOrders";
            btnAllOrders.Size = new Size(88, 22);
            btnAllOrders.Text = "Load all orders";
            btnAllOrders.Click += btnAllOrders_Click;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripLabel3.Margin = new Padding(3, 1, 3, 2);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(64, 22);
            toolStripLabel3.Text = "Find order";
            // 
            // txtOrderId
            // 
            txtOrderId.BorderStyle = BorderStyle.FixedSingle;
            txtOrderId.Margin = new Padding(3, 0, 3, 0);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(100, 25);
            // 
            // btnFindOrderById
            // 
            btnFindOrderById.BackColor = Color.Green;
            btnFindOrderById.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFindOrderById.ForeColor = Color.White;
            btnFindOrderById.Image = (Image)resources.GetObject("btnFindOrderById.Image");
            btnFindOrderById.ImageTransparentColor = Color.Magenta;
            btnFindOrderById.Margin = new Padding(3, 1, 3, 2);
            btnFindOrderById.Name = "btnFindOrderById";
            btnFindOrderById.Size = new Size(64, 22);
            btnFindOrderById.Text = "Find by ID";
            btnFindOrderById.Click += btnFindOrderById_Click;
            // 
            // btnFindOrderBySID
            // 
            btnFindOrderBySID.BackColor = Color.MediumSeaGreen;
            btnFindOrderBySID.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFindOrderBySID.ForeColor = Color.White;
            btnFindOrderBySID.Image = (Image)resources.GetObject("btnFindOrderBySID.Image");
            btnFindOrderBySID.ImageTransparentColor = Color.Magenta;
            btnFindOrderBySID.Margin = new Padding(3, 1, 3, 2);
            btnFindOrderBySID.Name = "btnFindOrderBySID";
            btnFindOrderBySID.Size = new Size(70, 22);
            btnFindOrderBySID.Text = "Find by SID";
            btnFindOrderBySID.Click += btnFindOrderBySID_Click;
            // 
            // lblOrderCount
            // 
            lblOrderCount.Alignment = ToolStripItemAlignment.Right;
            lblOrderCount.Name = "lblOrderCount";
            lblOrderCount.Size = new Size(13, 22);
            lblOrderCount.Text = "0";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(43, 22);
            toolStripLabel5.Text = "Count:";
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.Red;
            btnDeleteOrder.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDeleteOrder.ForeColor = Color.White;
            btnDeleteOrder.Image = (Image)resources.GetObject("btnDeleteOrder.Image");
            btnDeleteOrder.ImageTransparentColor = Color.Magenta;
            btnDeleteOrder.Margin = new Padding(3, 1, 3, 2);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(44, 22);
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Payments";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdooManager";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSessions).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrders).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem btnExit;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtServer;
        private Label label2;
        private TextBox txtDb;
        private Label label3;
        private TextBox txtUser;
        private Label label4;
        private TextBox txtPass;
        private Button btnConnect;
        private ToolStrip toolStrip1;
        private DataGridView dgSessions;
        private ToolStripButton btnLoadAllSessions;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtSessionId;
        private ToolStripButton btnFindSession;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel lblSessionCount;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelSession;
        private DataGridView dgOrders;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAllOrders;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox txtOrderId;
        private ToolStripButton btnFindOrderBySID;
        private ToolStripLabel lblOrderCount;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel5;
        private ToolStripButton btnDeleteOrder;
        private ToolStripButton btnFindOrderById;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem btnNew;
    }
}
