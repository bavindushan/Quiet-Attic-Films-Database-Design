namespace DataBase_asssingment
{
    partial class Location_Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_locationid = new System.Windows.Forms.TextBox();
            this.text_locationname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttn_Clearall = new System.Windows.Forms.Button();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location Name";
            // 
            // text_locationid
            // 
            this.text_locationid.Location = new System.Drawing.Point(188, 94);
            this.text_locationid.Name = "text_locationid";
            this.text_locationid.Size = new System.Drawing.Size(165, 26);
            this.text_locationid.TabIndex = 2;
            // 
            // text_locationname
            // 
            this.text_locationname.Location = new System.Drawing.Point(188, 138);
            this.text_locationname.Name = "text_locationname";
            this.text_locationname.Size = new System.Drawing.Size(165, 26);
            this.text_locationname.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 263);
            this.dataGridView1.TabIndex = 4;
            // 
            // bttn_Clearall
            // 
            this.bttn_Clearall.Location = new System.Drawing.Point(637, 144);
            this.bttn_Clearall.Name = "bttn_Clearall";
            this.bttn_Clearall.Size = new System.Drawing.Size(85, 39);
            this.bttn_Clearall.TabIndex = 21;
            this.bttn_Clearall.Text = "Clear all";
            this.bttn_Clearall.UseVisualStyleBackColor = true;
            this.bttn_Clearall.Click += new System.EventHandler(this.bttn_Clearall_Click);
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.Location = new System.Drawing.Point(501, 144);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(78, 39);
            this.bttn_Delete.TabIndex = 20;
            this.bttn_Delete.Text = "Delete";
            this.bttn_Delete.UseVisualStyleBackColor = true;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Update
            // 
            this.bttn_Update.Location = new System.Drawing.Point(686, 85);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(73, 39);
            this.bttn_Update.TabIndex = 19;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(579, 85);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(63, 39);
            this.bttn_Add.TabIndex = 18;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(474, 85);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(71, 39);
            this.btnsearch.TabIndex = 17;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.bttn_Search_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(17, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 42);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Location_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.bttn_Clearall);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Update);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_locationname);
            this.Controls.Add(this.text_locationid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Location_Manager";
            this.Text = "Location_Manager";
            this.Load += new System.EventHandler(this.Location_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_locationid;
        private System.Windows.Forms.TextBox text_locationname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttn_Clearall;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btn_Back;
    }
}