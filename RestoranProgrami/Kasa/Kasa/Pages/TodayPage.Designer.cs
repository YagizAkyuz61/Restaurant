
namespace Kasa.Pages
{
    partial class TodayPage
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
            this.menuBTN = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBTN
            // 
            this.menuBTN.BackColor = System.Drawing.Color.White;
            this.menuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBTN.Location = new System.Drawing.Point(4, 382);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(851, 62);
            this.menuBTN.TabIndex = 3;
            this.menuBTN.Text = "Ana Menü";
            this.menuBTN.UseVisualStyleBackColor = false;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(4, 8);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(851, 367);
            this.dgv.TabIndex = 2;
            // 
            // TodayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(859, 455);
            this.Controls.Add(this.menuBTN);
            this.Controls.Add(this.dgv);
            this.Name = "TodayPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bugün Satılanlar";
            this.Load += new System.EventHandler(this.TodayPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBTN;
        private System.Windows.Forms.DataGridView dgv;
    }
}