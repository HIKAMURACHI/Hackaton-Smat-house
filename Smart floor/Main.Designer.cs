namespace Smart_floor
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BRestart = new System.Windows.Forms.Button();
            this.PMenu = new System.Windows.Forms.Panel();
            this.BAdd = new System.Windows.Forms.Button();
            this.BFloor = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.BMenu = new System.Windows.Forms.Button();
            this.BSetting = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uHome1 = new Smart_floor.UHome();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BRestart
            // 
            this.BRestart.FlatAppearance.BorderSize = 0;
            this.BRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRestart.ForeColor = System.Drawing.Color.Black;
            this.BRestart.Location = new System.Drawing.Point(1197, 0);
            this.BRestart.Name = "BRestart";
            this.BRestart.Size = new System.Drawing.Size(59, 24);
            this.BRestart.TabIndex = 0;
            this.BRestart.Text = "restart";
            this.BRestart.UseVisualStyleBackColor = true;
            this.BRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.PMenu.Controls.Add(this.BAdd);
            this.PMenu.Controls.Add(this.BFloor);
            this.PMenu.Controls.Add(this.BHome);
            this.PMenu.Controls.Add(this.BMenu);
            this.PMenu.Location = new System.Drawing.Point(0, 0);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(250, 720);
            this.PMenu.TabIndex = 1;
            // 
            // BAdd
            // 
            this.BAdd.FlatAppearance.BorderSize = 0;
            this.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.ForeColor = System.Drawing.Color.White;
            this.BAdd.Location = new System.Drawing.Point(3, 99);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(244, 47);
            this.BAdd.TabIndex = 3;
            this.BAdd.Text = "+";
            this.BAdd.UseVisualStyleBackColor = true;
            // 
            // BFloor
            // 
            this.BFloor.FlatAppearance.BorderSize = 0;
            this.BFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BFloor.ForeColor = System.Drawing.Color.White;
            this.BFloor.Location = new System.Drawing.Point(3, 56);
            this.BFloor.Name = "BFloor";
            this.BFloor.Size = new System.Drawing.Size(244, 47);
            this.BFloor.TabIndex = 2;
            this.BFloor.Text = "Floor";
            this.BFloor.UseVisualStyleBackColor = true;
            this.BFloor.Click += new System.EventHandler(this.BFloor_Click);
            // 
            // BHome
            // 
            this.BHome.FlatAppearance.BorderSize = 0;
            this.BHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BHome.ForeColor = System.Drawing.Color.White;
            this.BHome.Location = new System.Drawing.Point(3, 3);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(244, 47);
            this.BHome.TabIndex = 1;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            this.BHome.Click += new System.EventHandler(this.BHome_Click);
            // 
            // BMenu
            // 
            this.BMenu.FlatAppearance.BorderSize = 0;
            this.BMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMenu.ForeColor = System.Drawing.Color.White;
            this.BMenu.Location = new System.Drawing.Point(11, 687);
            this.BMenu.Name = "BMenu";
            this.BMenu.Size = new System.Drawing.Size(30, 30);
            this.BMenu.TabIndex = 0;
            this.BMenu.Text = "<";
            this.BMenu.UseVisualStyleBackColor = true;
            this.BMenu.Click += new System.EventHandler(this.v_Click);
            // 
            // BSetting
            // 
            this.BSetting.FlatAppearance.BorderSize = 0;
            this.BSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSetting.ForeColor = System.Drawing.Color.Black;
            this.BSetting.Location = new System.Drawing.Point(1141, 0);
            this.BSetting.Name = "BSetting";
            this.BSetting.Size = new System.Drawing.Size(50, 24);
            this.BSetting.TabIndex = 3;
            this.BSetting.Text = "Setting";
            this.BSetting.UseVisualStyleBackColor = true;
            // 
            // BClose
            // 
            this.BClose.FlatAppearance.BorderSize = 0;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.ForeColor = System.Drawing.Color.Black;
            this.BClose.Location = new System.Drawing.Point(1262, 0);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(17, 24);
            this.BClose.TabIndex = 4;
            this.BClose.Text = "X";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // uHome1
            // 
            this.uHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.uHome1.Location = new System.Drawing.Point(44, 24);
            this.uHome1.Name = "uHome1";
            this.uHome1.Size = new System.Drawing.Size(1236, 696);
            this.uHome1.TabIndex = 5;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.PMenu);
            this.Controls.Add(this.BSetting);
            this.Controls.Add(this.BRestart);
            this.Controls.Add(this.uHome1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "v";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.PMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BRestart;
        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button BMenu;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Button BFloor;
        private System.Windows.Forms.Button BSetting;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BAdd;
        private UHome uHome1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

