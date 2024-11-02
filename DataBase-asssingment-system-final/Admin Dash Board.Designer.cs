namespace DataBase_asssingment
{
    partial class Admin_Dash_Board
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
            this.bttn_Back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_Back
            // 
            this.bttn_Back.Location = new System.Drawing.Point(12, 12);
            this.bttn_Back.Name = "bttn_Back";
            this.bttn_Back.Size = new System.Drawing.Size(75, 39);
            this.bttn_Back.TabIndex = 0;
            this.bttn_Back.Text = "Back";
            this.bttn_Back.UseVisualStyleBackColor = true;
            this.bttn_Back.Click += new System.EventHandler(this.bttn_Back_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Properties";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "Locations";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 81);
            this.button5.TabIndex = 4;
            this.button5.Text = "Productions";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(276, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 81);
            this.button6.TabIndex = 5;
            this.button6.Text = "Clients";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(433, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 81);
            this.button7.TabIndex = 6;
            this.button7.Text = "Staff";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(499, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 81);
            this.button8.TabIndex = 7;
            this.button8.Text = "User Accounts";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "Staff Type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Dash_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttn_Back);
            this.Name = "Admin_Dash_Board";
            this.Text = "Admin_Dash_Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_Back;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
    }
}