
namespace Inlämingsuppgift_1__Databaser
{
    partial class FormUpdate
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
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUpdateConfirm = new System.Windows.Forms.Button();
            this.textBoxUpdateConfirm = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Please confirm your password to update this advert";
            // 
            // buttonUpdateConfirm
            // 
            this.buttonUpdateConfirm.Location = new System.Drawing.Point(808, 503);
            this.buttonUpdateConfirm.Name = "buttonUpdateConfirm";
            this.buttonUpdateConfirm.Size = new System.Drawing.Size(129, 23);
            this.buttonUpdateConfirm.TabIndex = 22;
            this.buttonUpdateConfirm.Text = "Confirm password";
            this.buttonUpdateConfirm.UseVisualStyleBackColor = true;
            this.buttonUpdateConfirm.Click += new System.EventHandler(this.buttonDeleteConfirm_Click);
            // 
            // textBoxUpdateConfirm
            // 
            this.textBoxUpdateConfirm.Location = new System.Drawing.Point(750, 474);
            this.textBoxUpdateConfirm.Name = "textBoxUpdateConfirm";
            this.textBoxUpdateConfirm.Size = new System.Drawing.Size(187, 23);
            this.textBoxUpdateConfirm.TabIndex = 21;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 351);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(139, 43);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(232, 1);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowTemplate.Height = 25;
            this.dataGridViewShow.Size = new System.Drawing.Size(705, 320);
            this.dataGridViewShow.TabIndex = 24;
            this.dataGridViewShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShow_CellContentClick);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(95, 12);
            this.textBoxTitel.Multiline = true;
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(131, 27);
            this.textBoxTitel.TabIndex = 26;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(95, 174);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(131, 26);
            this.textBoxPrice.TabIndex = 29;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(95, 93);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(131, 27);
            this.textBoxDesc.TabIndex = 30;
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(95, 250);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(131, 23);
            this.comboBoxCat.TabIndex = 31;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Categori";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 495);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 30);
            this.buttonBack.TabIndex = 36;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 533);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonUpdateConfirm);
            this.Controls.Add(this.textBoxUpdateConfirm);
            this.Name = "FormUpdate";
            this.Text = "Update advert";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUpdateConfirm;
        private System.Windows.Forms.TextBox textBoxUpdateConfirm;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
    }
}