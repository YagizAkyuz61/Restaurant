
namespace Kasa.Pages
{
    partial class HomePage
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
            this.tableCB = new System.Windows.Forms.ComboBox();
            this.oDGV = new System.Windows.Forms.DataGridView();
            this.priceLBL = new System.Windows.Forms.Label();
            this.finishBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.insertBTN = new System.Windows.Forms.Button();
            this.rDGV = new System.Windows.Forms.DataGridView();
            this.dateTXT = new System.Windows.Forms.MaskedTextBox();
            this.cNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ykmBTN = new System.Windows.Forms.Button();
            this.toBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtableCB = new System.Windows.Forms.ComboBox();
            this.timeCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showBTN = new System.Windows.Forms.Button();
            this.waiterBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableCB
            // 
            this.tableCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableCB.FormattingEnabled = true;
            this.tableCB.Location = new System.Drawing.Point(15, 47);
            this.tableCB.Name = "tableCB";
            this.tableCB.Size = new System.Drawing.Size(382, 24);
            this.tableCB.TabIndex = 1;
            // 
            // oDGV
            // 
            this.oDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oDGV.Location = new System.Drawing.Point(15, 79);
            this.oDGV.Name = "oDGV";
            this.oDGV.Size = new System.Drawing.Size(512, 287);
            this.oDGV.TabIndex = 2;
            // 
            // priceLBL
            // 
            this.priceLBL.AutoSize = true;
            this.priceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLBL.ForeColor = System.Drawing.Color.White;
            this.priceLBL.Location = new System.Drawing.Point(12, 395);
            this.priceLBL.Name = "priceLBL";
            this.priceLBL.Size = new System.Drawing.Size(88, 25);
            this.priceLBL.TabIndex = 0;
            this.priceLBL.Text = "Ücret: 0";
            // 
            // finishBTN
            // 
            this.finishBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finishBTN.Location = new System.Drawing.Point(133, 395);
            this.finishBTN.Name = "finishBTN";
            this.finishBTN.Size = new System.Drawing.Size(223, 41);
            this.finishBTN.TabIndex = 3;
            this.finishBTN.Text = "Hesabı Kapat";
            this.finishBTN.UseVisualStyleBackColor = true;
            this.finishBTN.Click += new System.EventHandler(this.finishBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(537, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 35);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rezervasyonlar";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(1154, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(183, 25);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "8.01.2021 - 23:41";
            // 
            // insertBTN
            // 
            this.insertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.insertBTN.Location = new System.Drawing.Point(670, 162);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(183, 32);
            this.insertBTN.TabIndex = 22;
            this.insertBTN.Text = "Onayla";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // rDGV
            // 
            this.rDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rDGV.Location = new System.Drawing.Point(859, 50);
            this.rDGV.Name = "rDGV";
            this.rDGV.Size = new System.Drawing.Size(479, 382);
            this.rDGV.TabIndex = 21;
            // 
            // dateTXT
            // 
            this.dateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTXT.Location = new System.Drawing.Point(670, 106);
            this.dateTXT.Mask = "00/00/0000";
            this.dateTXT.Name = "dateTXT";
            this.dateTXT.Size = new System.Drawing.Size(182, 23);
            this.dateTXT.TabIndex = 20;
            this.dateTXT.ValidatingType = typeof(System.DateTime);
            // 
            // cNameTXT
            // 
            this.cNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cNameTXT.Location = new System.Drawing.Point(670, 50);
            this.cNameTXT.Name = "cNameTXT";
            this.cNameTXT.Size = new System.Drawing.Size(182, 23);
            this.cNameTXT.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(540, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(540, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Masa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(539, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Müşteri Adı";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ykmBTN
            // 
            this.ykmBTN.BackColor = System.Drawing.Color.White;
            this.ykmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ykmBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ykmBTN.Location = new System.Drawing.Point(12, 442);
            this.ykmBTN.Name = "ykmBTN";
            this.ykmBTN.Size = new System.Drawing.Size(842, 65);
            this.ykmBTN.TabIndex = 26;
            this.ykmBTN.Text = "Yemek - Kategori - Masa Düzenleme";
            this.ykmBTN.UseVisualStyleBackColor = false;
            this.ykmBTN.Click += new System.EventHandler(this.ykmBTN_Click);
            // 
            // toBTN
            // 
            this.toBTN.BackColor = System.Drawing.Color.White;
            this.toBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toBTN.Location = new System.Drawing.Point(12, 513);
            this.toBTN.Name = "toBTN";
            this.toBTN.Size = new System.Drawing.Size(841, 65);
            this.toBTN.TabIndex = 27;
            this.toBTN.Text = "Bugünkü Siparişler";
            this.toBTN.UseVisualStyleBackColor = false;
            this.toBTN.Click += new System.EventHandler(this.toBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(529, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 443);
            this.panel1.TabIndex = 28;
            // 
            // rtableCB
            // 
            this.rtableCB.FormattingEnabled = true;
            this.rtableCB.Location = new System.Drawing.Point(670, 79);
            this.rtableCB.Name = "rtableCB";
            this.rtableCB.Size = new System.Drawing.Size(183, 21);
            this.rtableCB.TabIndex = 29;
            this.rtableCB.Text = "Masa seçin...";
            // 
            // timeCB
            // 
            this.timeCB.FormattingEnabled = true;
            this.timeCB.Location = new System.Drawing.Point(670, 135);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(182, 21);
            this.timeCB.TabIndex = 30;
            this.timeCB.Text = "Saat seçin...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(540, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Saat";
            // 
            // showBTN
            // 
            this.showBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showBTN.Location = new System.Drawing.Point(403, 46);
            this.showBTN.Name = "showBTN";
            this.showBTN.Size = new System.Drawing.Size(120, 24);
            this.showBTN.TabIndex = 31;
            this.showBTN.Text = "Göster";
            this.showBTN.UseVisualStyleBackColor = true;
            this.showBTN.Click += new System.EventHandler(this.showBTN_Click);
            // 
            // waiterBTN
            // 
            this.waiterBTN.BackColor = System.Drawing.Color.White;
            this.waiterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.waiterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.waiterBTN.Location = new System.Drawing.Point(859, 442);
            this.waiterBTN.Name = "waiterBTN";
            this.waiterBTN.Size = new System.Drawing.Size(477, 136);
            this.waiterBTN.TabIndex = 32;
            this.waiterBTN.Text = "Garson Ekle";
            this.waiterBTN.UseVisualStyleBackColor = false;
            this.waiterBTN.Click += new System.EventHandler(this.waiterBTN_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1348, 586);
            this.Controls.Add(this.waiterBTN);
            this.Controls.Add(this.showBTN);
            this.Controls.Add(this.timeCB);
            this.Controls.Add(this.rtableCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toBTN);
            this.Controls.Add(this.ykmBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.rDGV);
            this.Controls.Add(this.dateTXT);
            this.Controls.Add(this.cNameTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.finishBTN);
            this.Controls.Add(this.oDGV);
            this.Controls.Add(this.tableCB);
            this.Controls.Add(this.priceLBL);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox tableCB;
        private System.Windows.Forms.DataGridView oDGV;
        private System.Windows.Forms.Label priceLBL;
        private System.Windows.Forms.Button finishBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.DataGridView rDGV;
        private System.Windows.Forms.MaskedTextBox dateTXT;
        private System.Windows.Forms.TextBox cNameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ykmBTN;
        private System.Windows.Forms.Button toBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox rtableCB;
        private System.Windows.Forms.ComboBox timeCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showBTN;
        private System.Windows.Forms.Button waiterBTN;
    }
}