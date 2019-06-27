namespace RoomRedo
{
    partial class Doors
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
            this.lstDoors = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDoorWidth = new System.Windows.Forms.TextBox();
            this.txtDoorLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAreaOfWalls);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lstDoors);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.txtDoorWidth);
            this.groupBox1.Controls.Add(this.txtDoorLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Door Measurements";
            // 
            // lblAreaOfWalls
            // 
            this.lblAreaOfWalls.AutoSize = true;
            this.lblAreaOfWalls.Location = new System.Drawing.Point(6, 119);
            this.lblAreaOfWalls.Name = "lblAreaOfWalls";
            this.lblAreaOfWalls.Size = new System.Drawing.Size(10, 13);
            this.lblAreaOfWalls.TabIndex = 10;
            this.lblAreaOfWalls.Text = ".";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstDoors
            // 
            this.lstDoors.FormattingEnabled = true;
            this.lstDoors.Location = new System.Drawing.Point(6, 135);
            this.lstDoors.Name = "lstDoors";
            this.lstDoors.Size = new System.Drawing.Size(248, 69);
            this.lstDoors.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(208, 80);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(58, 80);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 80);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDoorWidth
            // 
            this.txtDoorWidth.Location = new System.Drawing.Point(125, 51);
            this.txtDoorWidth.Name = "txtDoorWidth";
            this.txtDoorWidth.Size = new System.Drawing.Size(100, 20);
            this.txtDoorWidth.TabIndex = 3;
            // 
            // txtDoorLength
            // 
            this.txtDoorLength.Location = new System.Drawing.Point(125, 26);
            this.txtDoorLength.Name = "txtDoorLength";
            this.txtDoorLength.Size = new System.Drawing.Size(100, 20);
            this.txtDoorLength.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Door Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Door Length:";
            // 
            // Doors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doors";
            this.Text = "Add Doors";
            this.Load += new System.EventHandler(this.Doors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDoors;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDoorWidth;
        private System.Windows.Forms.TextBox txtDoorLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAreaOfWalls;
    }
}