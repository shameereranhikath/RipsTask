namespace RipsASTTask
{
    partial class Form1
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
            this.txtSqlQuery = new System.Windows.Forms.TextBox();
            this.grpSqlQuery = new System.Windows.Forms.GroupBox();
            this.grpParse = new System.Windows.Forms.GroupBox();
            this.btnParseQuery = new System.Windows.Forms.Button();
            this.grpParseStringTree = new System.Windows.Forms.GroupBox();
            this.txtParseStringTree = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSqlQuery.SuspendLayout();
            this.grpParse.SuspendLayout();
            this.grpParseStringTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSqlQuery
            // 
            this.txtSqlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSqlQuery.Location = new System.Drawing.Point(3, 16);
            this.txtSqlQuery.Multiline = true;
            this.txtSqlQuery.Name = "txtSqlQuery";
            this.txtSqlQuery.Size = new System.Drawing.Size(1264, 75);
            this.txtSqlQuery.TabIndex = 0;
            // 
            // grpSqlQuery
            // 
            this.grpSqlQuery.Controls.Add(this.txtSqlQuery);
            this.grpSqlQuery.Location = new System.Drawing.Point(3, 7);
            this.grpSqlQuery.Name = "grpSqlQuery";
            this.grpSqlQuery.Size = new System.Drawing.Size(1270, 94);
            this.grpSqlQuery.TabIndex = 2;
            this.grpSqlQuery.TabStop = false;
            this.grpSqlQuery.Text = "Sql Query";
            // 
            // grpParse
            // 
            this.grpParse.Controls.Add(this.btnParseQuery);
            this.grpParse.Location = new System.Drawing.Point(3, 107);
            this.grpParse.Name = "grpParse";
            this.grpParse.Size = new System.Drawing.Size(1267, 47);
            this.grpParse.TabIndex = 3;
            this.grpParse.TabStop = false;
            this.grpParse.Text = "Parse";
            // 
            // btnParseQuery
            // 
            this.btnParseQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParseQuery.Location = new System.Drawing.Point(23, 17);
            this.btnParseQuery.Name = "btnParseQuery";
            this.btnParseQuery.Size = new System.Drawing.Size(113, 23);
            this.btnParseQuery.TabIndex = 0;
            this.btnParseQuery.Text = "Parse the Quey";
            this.btnParseQuery.UseVisualStyleBackColor = true;
            this.btnParseQuery.Click += new System.EventHandler(this.btnParseQuery_Click);
            // 
            // grpParseStringTree
            // 
            this.grpParseStringTree.Controls.Add(this.txtParseStringTree);
            this.grpParseStringTree.Location = new System.Drawing.Point(3, 160);
            this.grpParseStringTree.Name = "grpParseStringTree";
            this.grpParseStringTree.Size = new System.Drawing.Size(1267, 100);
            this.grpParseStringTree.TabIndex = 4;
            this.grpParseStringTree.TabStop = false;
            this.grpParseStringTree.Text = "Parsed String Tree";
            // 
            // txtParseStringTree
            // 
            this.txtParseStringTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParseStringTree.Location = new System.Drawing.Point(3, 16);
            this.txtParseStringTree.Multiline = true;
            this.txtParseStringTree.Name = "txtParseStringTree";
            this.txtParseStringTree.Size = new System.Drawing.Size(1261, 81);
            this.txtParseStringTree.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpParseStringTree);
            this.Controls.Add(this.grpParse);
            this.Controls.Add(this.grpSqlQuery);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abstarct Syntax Tree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSqlQuery.ResumeLayout(false);
            this.grpSqlQuery.PerformLayout();
            this.grpParse.ResumeLayout(false);
            this.grpParseStringTree.ResumeLayout(false);
            this.grpParseStringTree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSqlQuery;
        private System.Windows.Forms.GroupBox grpSqlQuery;
        private System.Windows.Forms.GroupBox grpParse;
        private System.Windows.Forms.Button btnParseQuery;
        private System.Windows.Forms.GroupBox grpParseStringTree;
        private System.Windows.Forms.TextBox txtParseStringTree;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

