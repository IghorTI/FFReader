namespace LeitorDeArquivoPasta
{
    partial class FormCopyTo
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
            this.lbFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.txtFileNames = new System.Windows.Forms.TextBox();
            this.lbFileNames = new System.Windows.Forms.Label();
            this.btCopyTo = new System.Windows.Forms.Button();
            this.btVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFrom
            // 
            this.lbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(35, 29);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(24, 13);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "De:";
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Location = new System.Drawing.Point(37, 45);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(426, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Location = new System.Drawing.Point(37, 87);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(426, 20);
            this.txtTo.TabIndex = 3;
            // 
            // lbTo
            // 
            this.lbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(35, 69);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(32, 13);
            this.lbTo.TabIndex = 2;
            this.lbTo.Text = "Para:";
            // 
            // txtFileNames
            // 
            this.txtFileNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNames.Location = new System.Drawing.Point(37, 154);
            this.txtFileNames.Multiline = true;
            this.txtFileNames.Name = "txtFileNames";
            this.txtFileNames.Size = new System.Drawing.Size(426, 159);
            this.txtFileNames.TabIndex = 4;
            // 
            // lbFileNames
            // 
            this.lbFileNames.AutoSize = true;
            this.lbFileNames.Location = new System.Drawing.Point(34, 121);
            this.lbFileNames.Name = "lbFileNames";
            this.lbFileNames.Size = new System.Drawing.Size(101, 13);
            this.lbFileNames.TabIndex = 5;
            this.lbFileNames.Text = "Nome dos arquivos:";
            // 
            // btCopyTo
            // 
            this.btCopyTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopyTo.Location = new System.Drawing.Point(388, 347);
            this.btCopyTo.Name = "btCopyTo";
            this.btCopyTo.Size = new System.Drawing.Size(75, 23);
            this.btCopyTo.TabIndex = 6;
            this.btCopyTo.Text = "Copiar";
            this.btCopyTo.UseVisualStyleBackColor = true;
            this.btCopyTo.Click += new System.EventHandler(this.btCopyTo_Click);
            // 
            // btVerify
            // 
            this.btVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btVerify.Location = new System.Drawing.Point(307, 347);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(75, 23);
            this.btVerify.TabIndex = 7;
            this.btVerify.Text = "Verificar";
            this.btVerify.UseVisualStyleBackColor = true;
            this.btVerify.Click += new System.EventHandler(this.btVerify_Click);
            // 
            // FormCopyTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 418);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbFileNames);
            this.Controls.Add(this.btVerify);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.btCopyTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFileNames);
            this.Name = "FormCopyTo";
            this.Text = "FormCopyTo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txtFileNames;
        private System.Windows.Forms.Label lbFileNames;
        private System.Windows.Forms.Button btCopyTo;
        private System.Windows.Forms.Button btVerify;
    }
}