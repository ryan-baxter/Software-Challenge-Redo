namespace RoomRedo
{
    partial class Windows
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAreaOfWalls = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWindowWidth = new System.Windows.Forms.TextBox();
            this.txtWindowLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstWindows = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAreaOfWalls);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtWindowWidth);
            this.groupBox1.Controls.Add(this.txtWindowLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.lstWindows);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Window Measurements";
            // 
            // lblAreaOfWalls
            // 
            this.lblAreaOfWalls.AutoSize = true;
            this.lblAreaOfWalls.Location = new System.Drawing.Point(6, 113);
            this.lblAreaOfWalls.Name = "lblAreaOfWalls";
            this.lblAreaOfWalls.Size = new System.Drawing.Size(10, 13);
            this.lblAreaOfWalls.TabIndex = 9;
            this.lblAreaOfWalls.Text = ".";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWindowWidth
            // 
            this.txtWindowWidth.Location = new System.Drawing.Point(136, 48);
            this.txtWindowWidth.Name = "txtWindowWidth";
            this.txtWindowWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWindowWidth.TabIndex = 7;
            // 
            // txtWindowLength
            // 
            this.txtWindowLength.Location = new System.Drawing.Point(136, 23);
            this.txtWindowLength.Name = "txtWindowLength";
            this.txtWindowLength.Size = new System.Drawing.Size(100, 20);
            this.txtWindowLength.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Window Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Window Width:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(62, 78);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(66, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(203, 78);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(5, 78);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstWindows
            // 
            this.lstWindows.FormattingEnabled = true;
            this.lstWindows.Location = new System.Drawing.Point(5, 133);
            this.lstWindows.Name = "lstWindows";
            this.lstWindows.Size = new System.Drawing.Size(248, 69);
            this.lstWindows.TabIndex = 0;
            // 
            // Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.groupBox1);
            this.Name = "Windows";
            this.Text = "Add Windows";
            this.Load += new System.EventHandler(this.Windows_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstWindows;
        private System.Windows.Forms.TextBox txtWindowWidth;
        private System.Windows.Forms.TextBox txtWindowLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAreaOfWalls;
    }
}