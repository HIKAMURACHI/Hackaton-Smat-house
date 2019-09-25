namespace Smart_floor
{
    partial class UHome
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BRoom = new System.Windows.Forms.Button();
            this.BRestroom = new System.Windows.Forms.Button();
            this.BBath = new System.Windows.Forms.Button();
            this.BToilet = new System.Windows.Forms.Button();
            this.BKitchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BRoom
            // 
            this.BRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BRoom.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRoom.ForeColor = System.Drawing.Color.White;
            this.BRoom.Location = new System.Drawing.Point(1183, 3);
            this.BRoom.Name = "BRoom";
            this.BRoom.Size = new System.Drawing.Size(50, 50);
            this.BRoom.TabIndex = 0;
            this.BRoom.Text = "Room";
            this.BRoom.UseVisualStyleBackColor = true;
            this.BRoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.BRoom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            this.BRoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // BRestroom
            // 
            this.BRestroom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BRestroom.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BRestroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRestroom.ForeColor = System.Drawing.Color.White;
            this.BRestroom.Location = new System.Drawing.Point(1183, 115);
            this.BRestroom.Name = "BRestroom";
            this.BRestroom.Size = new System.Drawing.Size(50, 50);
            this.BRestroom.TabIndex = 1;
            this.BRestroom.Text = "Restroom";
            this.BRestroom.UseVisualStyleBackColor = true;
            this.BRestroom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.BRestroom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            this.BRestroom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // BBath
            // 
            this.BBath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BBath.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BBath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBath.ForeColor = System.Drawing.Color.White;
            this.BBath.Location = new System.Drawing.Point(1183, 171);
            this.BBath.Name = "BBath";
            this.BBath.Size = new System.Drawing.Size(50, 50);
            this.BBath.TabIndex = 2;
            this.BBath.Text = "Bath";
            this.BBath.UseVisualStyleBackColor = true;
            this.BBath.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.BBath.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            this.BBath.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // BToilet
            // 
            this.BToilet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BToilet.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BToilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BToilet.ForeColor = System.Drawing.Color.White;
            this.BToilet.Location = new System.Drawing.Point(1183, 227);
            this.BToilet.Name = "BToilet";
            this.BToilet.Size = new System.Drawing.Size(50, 50);
            this.BToilet.TabIndex = 3;
            this.BToilet.Text = "Toilet";
            this.BToilet.UseVisualStyleBackColor = true;
            this.BToilet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.BToilet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            this.BToilet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // BKitchen
            // 
            this.BKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BKitchen.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BKitchen.ForeColor = System.Drawing.Color.White;
            this.BKitchen.Location = new System.Drawing.Point(1183, 59);
            this.BKitchen.Name = "BKitchen";
            this.BKitchen.Size = new System.Drawing.Size(50, 50);
            this.BKitchen.TabIndex = 4;
            this.BKitchen.Text = "Kitchen";
            this.BKitchen.UseVisualStyleBackColor = true;
            this.BKitchen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.BKitchen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            this.BKitchen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // UHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.Controls.Add(this.BKitchen);
            this.Controls.Add(this.BToilet);
            this.Controls.Add(this.BBath);
            this.Controls.Add(this.BRestroom);
            this.Controls.Add(this.BRoom);
            this.Name = "UHome";
            this.Size = new System.Drawing.Size(1236, 696);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BRoom;
        private System.Windows.Forms.Button BRestroom;
        private System.Windows.Forms.Button BBath;
        private System.Windows.Forms.Button BToilet;
        private System.Windows.Forms.Button BKitchen;
    }
}
