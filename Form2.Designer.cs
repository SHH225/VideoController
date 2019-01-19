namespace ZDWindowsFormsTest
{
    partial class Form2
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
            this.ChoosedPropertise = new System.Windows.Forms.TextBox();
            this.PropertiseName = new System.Windows.Forms.Label();
            this.ConfirmEdit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.LocationX = new System.Windows.Forms.TextBox();
            this.LocationY = new System.Windows.Forms.TextBox();
            this.LocationZ = new System.Windows.Forms.TextBox();
            this.RotationRoll = new System.Windows.Forms.TextBox();
            this.RotationYaw = new System.Windows.Forms.TextBox();
            this.RotationPitch = new System.Windows.Forms.TextBox();
            this.ScaleX = new System.Windows.Forms.TextBox();
            this.ScaleY = new System.Windows.Forms.TextBox();
            this.ScaleZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BooleanStatus = new System.Windows.Forms.Button();
            this.ReSet = new System.Windows.Forms.Button();
            this.Color_button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // ChoosedPropertise
            // 
            this.ChoosedPropertise.Location = new System.Drawing.Point(290, 179);
            this.ChoosedPropertise.Name = "ChoosedPropertise";
            this.ChoosedPropertise.Size = new System.Drawing.Size(100, 21);
            this.ChoosedPropertise.TabIndex = 0;
            // 
            // PropertiseName
            // 
            this.PropertiseName.AutoSize = true;
            this.PropertiseName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PropertiseName.Location = new System.Drawing.Point(286, 32);
            this.PropertiseName.Name = "PropertiseName";
            this.PropertiseName.Size = new System.Drawing.Size(49, 20);
            this.PropertiseName.TabIndex = 2;
            this.PropertiseName.Text = "Null";
            this.PropertiseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfirmEdit
            // 
            this.ConfirmEdit.Location = new System.Drawing.Point(205, 360);
            this.ConfirmEdit.Name = "ConfirmEdit";
            this.ConfirmEdit.Size = new System.Drawing.Size(75, 23);
            this.ConfirmEdit.TabIndex = 3;
            this.ConfirmEdit.Text = "确定";
            this.ConfirmEdit.UseVisualStyleBackColor = true;
            this.ConfirmEdit.Click += new System.EventHandler(this.Confirm_Edit);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(390, 360);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "关闭";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.CancelEdit);
            // 
            // LocationX
            // 
            this.LocationX.Location = new System.Drawing.Point(100, 111);
            this.LocationX.Name = "LocationX";
            this.LocationX.Size = new System.Drawing.Size(100, 21);
            this.LocationX.TabIndex = 6;
            this.LocationX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocationX_MouseDown);
            this.LocationX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LocationX_MouseMove);
            this.LocationX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LocationX_MouseUp);
            // 
            // LocationY
            // 
            this.LocationY.Location = new System.Drawing.Point(290, 111);
            this.LocationY.Name = "LocationY";
            this.LocationY.Size = new System.Drawing.Size(100, 21);
            this.LocationY.TabIndex = 7;
            this.LocationY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocationY_MouseDown);
            this.LocationY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LocationY_MouseMove);
            this.LocationY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LocationY_MouseUp);
            // 
            // LocationZ
            // 
            this.LocationZ.Location = new System.Drawing.Point(502, 111);
            this.LocationZ.Name = "LocationZ";
            this.LocationZ.Size = new System.Drawing.Size(100, 21);
            this.LocationZ.TabIndex = 8;
            this.LocationZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocationZ_MouseDown);
            this.LocationZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LocationZ_MouseMove);
            this.LocationZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LocationZ_MouseUp);
            // 
            // RotationRoll
            // 
            this.RotationRoll.Location = new System.Drawing.Point(100, 172);
            this.RotationRoll.Name = "RotationRoll";
            this.RotationRoll.Size = new System.Drawing.Size(100, 21);
            this.RotationRoll.TabIndex = 9;
            this.RotationRoll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotationRoll_MouseDown);
            this.RotationRoll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RotationRoll_MouseMove);
            this.RotationRoll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotationRoll_MouseUp);
            // 
            // RotationYaw
            // 
            this.RotationYaw.Location = new System.Drawing.Point(290, 172);
            this.RotationYaw.Name = "RotationYaw";
            this.RotationYaw.Size = new System.Drawing.Size(100, 21);
            this.RotationYaw.TabIndex = 10;
            this.RotationYaw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotationYaw_MouseDown);
            this.RotationYaw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RotationYaw_MouseMove);
            this.RotationYaw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotationYaw_MouseUp);
            // 
            // RotationPitch
            // 
            this.RotationPitch.Location = new System.Drawing.Point(502, 172);
            this.RotationPitch.Name = "RotationPitch";
            this.RotationPitch.Size = new System.Drawing.Size(100, 21);
            this.RotationPitch.TabIndex = 11;
            this.RotationPitch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotationPitch_MouseDown);
            this.RotationPitch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RotationPitch_MouseMove);
            this.RotationPitch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotationPitch_MouseUp);
            // 
            // ScaleX
            // 
            this.ScaleX.Location = new System.Drawing.Point(100, 234);
            this.ScaleX.Name = "ScaleX";
            this.ScaleX.Size = new System.Drawing.Size(100, 21);
            this.ScaleX.TabIndex = 12;
            this.ScaleX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScaleX_MouseDown);
            this.ScaleX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScaleX_MouseMove);
            this.ScaleX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScaleX_MouseUp);
            // 
            // ScaleY
            // 
            this.ScaleY.Location = new System.Drawing.Point(290, 234);
            this.ScaleY.Name = "ScaleY";
            this.ScaleY.Size = new System.Drawing.Size(100, 21);
            this.ScaleY.TabIndex = 13;
            this.ScaleY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScaleY_MouseDown);
            this.ScaleY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScaleY_MouseMove);
            this.ScaleY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScaleY_MouseUp);
            // 
            // ScaleZ
            // 
            this.ScaleZ.Location = new System.Drawing.Point(502, 234);
            this.ScaleZ.Name = "ScaleZ";
            this.ScaleZ.Size = new System.Drawing.Size(100, 21);
            this.ScaleZ.TabIndex = 14;
            this.ScaleZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScaleZ_MouseDown);
            this.ScaleZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScaleZ_MouseMove);
            this.ScaleZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScaleZ_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Location.X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Location.Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Location.Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "RotationRoll";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "RotationYaw";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "RotationPitch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "ScaleX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "ScaleY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "ScaleZ";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(131, 138);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(100, 21);
            this.R.TabIndex = 24;
            this.R.MouseDown += new System.Windows.Forms.MouseEventHandler(this.R_MouseDown);
            this.R.MouseMove += new System.Windows.Forms.MouseEventHandler(this.R_MouseMove);
            this.R.MouseUp += new System.Windows.Forms.MouseEventHandler(this.R_MouseUp);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(290, 138);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(100, 21);
            this.G.TabIndex = 25;
            this.G.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G_MouseDown);
            this.G.MouseMove += new System.Windows.Forms.MouseEventHandler(this.G_MouseMove);
            this.G.MouseUp += new System.Windows.Forms.MouseEventHandler(this.G_MouseUp);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(456, 138);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 21);
            this.B.TabIndex = 26;
            this.B.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B_MouseDown);
            this.B.MouseMove += new System.Windows.Forms.MouseEventHandler(this.B_MouseMove);
            this.B.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B_MouseUp);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(290, 179);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 21);
            this.A.TabIndex = 27;
            this.A.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A_MouseDown);
            this.A.MouseMove += new System.Windows.Forms.MouseEventHandler(this.A_MouseMove);
            this.A.MouseUp += new System.Windows.Forms.MouseEventHandler(this.A_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "R";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "G";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "A";
            // 
            // BooleanStatus
            // 
            this.BooleanStatus.Location = new System.Drawing.Point(290, 206);
            this.BooleanStatus.Name = "BooleanStatus";
            this.BooleanStatus.Size = new System.Drawing.Size(75, 23);
            this.BooleanStatus.TabIndex = 34;
            this.BooleanStatus.UseVisualStyleBackColor = true;
            this.BooleanStatus.Click += new System.EventHandler(this.BooleanChange);
            // 
            // ReSet
            // 
            this.ReSet.Location = new System.Drawing.Point(586, 29);
            this.ReSet.Name = "ReSet";
            this.ReSet.Size = new System.Drawing.Size(75, 23);
            this.ReSet.TabIndex = 35;
            this.ReSet.Text = "重置";
            this.ReSet.UseVisualStyleBackColor = true;
            this.ReSet.Click += new System.EventHandler(this.ReSet_Click);
            // 
            // Color_button
            // 
            this.Color_button.Location = new System.Drawing.Point(290, 206);
            this.Color_button.Name = "Color_button";
            this.Color_button.Size = new System.Drawing.Size(75, 27);
            this.Color_button.TabIndex = 36;
            this.Color_button.Text = "Color";
            this.Color_button.UseVisualStyleBackColor = true;
            this.Color_button.Click += new System.EventHandler(this.Color_button1_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(696, 416);
            this.Controls.Add(this.Color_button);
            this.Controls.Add(this.ReSet);
            this.Controls.Add(this.BooleanStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.A);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScaleZ);
            this.Controls.Add(this.ScaleY);
            this.Controls.Add(this.ScaleX);
            this.Controls.Add(this.RotationPitch);
            this.Controls.Add(this.RotationYaw);
            this.Controls.Add(this.RotationRoll);
            this.Controls.Add(this.LocationZ);
            this.Controls.Add(this.LocationY);
            this.Controls.Add(this.LocationX);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ConfirmEdit);
            this.Controls.Add(this.PropertiseName);
            this.Controls.Add(this.ChoosedPropertise);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChoosedPropertise;
        private System.Windows.Forms.Label PropertiseName;
        private System.Windows.Forms.Button ConfirmEdit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox LocationX;
        private System.Windows.Forms.TextBox LocationY;
        private System.Windows.Forms.TextBox LocationZ;
        private System.Windows.Forms.TextBox RotationRoll;
        private System.Windows.Forms.TextBox RotationYaw;
        private System.Windows.Forms.TextBox RotationPitch;
        private System.Windows.Forms.TextBox ScaleX;
        private System.Windows.Forms.TextBox ScaleY;
        private System.Windows.Forms.TextBox ScaleZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BooleanStatus;
        private System.Windows.Forms.Button ReSet;
        private System.Windows.Forms.Button Color_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

