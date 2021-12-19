
namespace Inlämingsuppgift_1__Databaser
{
    partial class FormDeleteAd
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
            this.buttonDeleteConfirm = new System.Windows.Forms.Button();
            this.textBoxDeleteConfirm = new System.Windows.Forms.TextBox();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Please confirm your password to delete this advert";
            // 
            // buttonDeleteConfirm
            // 
            this.buttonDeleteConfirm.Location = new System.Drawing.Point(659, 417);
            this.buttonDeleteConfirm.Name = "buttonDeleteConfirm";
            this.buttonDeleteConfirm.Size = new System.Drawing.Size(129, 23);
            this.buttonDeleteConfirm.TabIndex = 19;
            this.buttonDeleteConfirm.Text = "Confirm password";
            this.buttonDeleteConfirm.UseVisualStyleBackColor = true;
            this.buttonDeleteConfirm.Click += new System.EventHandler(this.buttonDeleteConfirm_Click);
            // 
            // textBoxDeleteConfirm
            // 
            this.textBoxDeleteConfirm.Location = new System.Drawing.Point(601, 388);
            this.textBoxDeleteConfirm.Name = "textBoxDeleteConfirm";
            this.textBoxDeleteConfirm.Size = new System.Drawing.Size(187, 23);
            this.textBoxDeleteConfirm.TabIndex = 18;
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowTemplate.Height = 25;
            this.dataGridViewShow.Size = new System.Drawing.Size(776, 320);
            this.dataGridViewShow.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 354);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 43);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 417);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 25);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormDeleteAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDeleteConfirm);
            this.Controls.Add(this.textBoxDeleteConfirm);
            this.Name = "FormDeleteAd";
            this.Text = "Delete advert";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDeleteConfirm;
        private System.Windows.Forms.TextBox textBoxDeleteConfirm;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
    }
}