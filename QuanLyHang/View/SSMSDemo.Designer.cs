namespace QuanLyHang.View
{
    partial class form_SSMSDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SSMSDemo));
            this.dataGridView_View = new System.Windows.Forms.DataGridView();
            this.treeView_Databases = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_View)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_View
            // 
            this.dataGridView_View.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_View.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_View.Location = new System.Drawing.Point(219, 0);
            this.dataGridView_View.Name = "dataGridView_View";
            this.dataGridView_View.Size = new System.Drawing.Size(581, 450);
            this.dataGridView_View.TabIndex = 0;
            // 
            // treeView_Databases
            // 
            this.treeView_Databases.BackColor = System.Drawing.SystemColors.Control;
            this.treeView_Databases.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_Databases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_Databases.ImageIndex = 0;
            this.treeView_Databases.ImageList = this.imageList1;
            this.treeView_Databases.Location = new System.Drawing.Point(0, 0);
            this.treeView_Databases.Name = "treeView_Databases";
            this.treeView_Databases.SelectedImageIndex = 2;
            this.treeView_Databases.Size = new System.Drawing.Size(213, 450);
            this.treeView_Databases.TabIndex = 1;
            this.treeView_Databases.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Databases_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "server.png");
            this.imageList1.Images.SetKeyName(1, "database.png");
            this.imageList1.Images.SetKeyName(2, "table.png");
            // 
            // form_SSMSDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView_Databases);
            this.Controls.Add(this.dataGridView_View);
            this.Name = "form_SSMSDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSMSDemo";
            this.Load += new System.EventHandler(this.form_SSMSDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_View;
        private System.Windows.Forms.TreeView treeView_Databases;
        private System.Windows.Forms.ImageList imageList1;
    }
}