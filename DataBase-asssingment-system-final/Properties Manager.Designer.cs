namespace DataBase_asssingment
{
    partial class Properties_Manager
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
            this.label3 = new System.Windows.Forms.Label();
            this.text_propertyid = new System.Windows.Forms.TextBox();
            this.text_propertyname = new System.Windows.Forms.TextBox();
            this.cbx_propertytype = new System.Windows.Forms.ComboBox();
            this.bttn_Search = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Clearall = new System.Windows.Forms.Button();
            this.dgvPropertiesManager = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertiesManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Property Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Property Type";
            // 
            // text_propertyid
            // 
            this.text_propertyid.Location = new System.Drawing.Point(162, 88);
            this.text_propertyid.Name = "text_propertyid";
            this.text_propertyid.Size = new System.Drawing.Size(199, 26);
            this.text_propertyid.TabIndex = 3;
            this.text_propertyid.TextChanged += new System.EventHandler(this.text_propertyid_TextChanged);
            // 
            // text_propertyname
            // 
            this.text_propertyname.Location = new System.Drawing.Point(162, 124);
            this.text_propertyname.Name = "text_propertyname";
            this.text_propertyname.Size = new System.Drawing.Size(199, 26);
            this.text_propertyname.TabIndex = 4;
            // 
            // cbx_propertytype
            // 
            this.cbx_propertytype.FormattingEnabled = true;
            this.cbx_propertytype.Items.AddRange(new object[] {
            "Vehicle",
            "Furniture",
            "Building"});
            this.cbx_propertytype.Location = new System.Drawing.Point(162, 162);
            this.cbx_propertytype.Name = "cbx_propertytype";
            this.cbx_propertytype.Size = new System.Drawing.Size(199, 28);
            this.cbx_propertytype.TabIndex = 5;
            // 
            // bttn_Search
            // 
            this.bttn_Search.Location = new System.Drawing.Point(422, 88);
            this.bttn_Search.Name = "bttn_Search";
            this.bttn_Search.Size = new System.Drawing.Size(71, 39);
            this.bttn_Search.TabIndex = 12;
            this.bttn_Search.Text = "Search";
            this.bttn_Search.UseVisualStyleBackColor = true;
            this.bttn_Search.Click += new System.EventHandler(this.bttn_Search_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(547, 88);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(63, 39);
            this.bttn_Add.TabIndex = 13;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // bttn_Update
            // 
            this.bttn_Update.Location = new System.Drawing.Point(659, 88);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(73, 39);
            this.bttn_Update.TabIndex = 14;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.Location = new System.Drawing.Point(472, 151);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(78, 39);
            this.bttn_Delete.TabIndex = 15;
            this.bttn_Delete.Text = "Delete";
            this.bttn_Delete.UseVisualStyleBackColor = true;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // bttn_Clearall
            // 
            this.bttn_Clearall.Location = new System.Drawing.Point(604, 151);
            this.bttn_Clearall.Name = "bttn_Clearall";
            this.bttn_Clearall.Size = new System.Drawing.Size(85, 39);
            this.bttn_Clearall.TabIndex = 16;
            this.bttn_Clearall.Text = "Clear all";
            this.bttn_Clearall.UseVisualStyleBackColor = true;
            this.bttn_Clearall.Click += new System.EventHandler(this.bttn_Clearall_Click);
            // 
            // dgvPropertiesManager
            // 
            this.dgvPropertiesManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertiesManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPropertiesManager.Location = new System.Drawing.Point(0, 243);
            this.dgvPropertiesManager.Name = "dgvPropertiesManager";
            this.dgvPropertiesManager.RowHeadersWidth = 62;
            this.dgvPropertiesManager.RowTemplate.Height = 28;
            this.dgvPropertiesManager.Size = new System.Drawing.Size(766, 290);
            this.dgvPropertiesManager.TabIndex = 17;
            this.dgvPropertiesManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Properties_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPropertiesManager);
            this.Controls.Add(this.bttn_Clearall);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Update);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.bttn_Search);
            this.Controls.Add(this.cbx_propertytype);
            this.Controls.Add(this.text_propertyname);
            this.Controls.Add(this.text_propertyid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Properties_Manager";
            this.Text = "Properties_Manager";
            this.Load += new System.EventHandler(this.Properties_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertiesManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_propertyid;
        private System.Windows.Forms.TextBox text_propertyname;
        private System.Windows.Forms.ComboBox cbx_propertytype;
        private System.Windows.Forms.Button bttn_Search;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Clearall;
        private System.Windows.Forms.DataGridView dgvPropertiesManager;
        private System.Windows.Forms.Button button1;
    }
}