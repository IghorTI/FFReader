namespace LeitorDeArquivoPasta
{
    partial class FFReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFReaderForm));
            this.btList = new System.Windows.Forms.Button();
            this.txtBoxFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAllFiles = new System.Windows.Forms.ListBox();
            this.btClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoDaPastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbLabelCount = new System.Windows.Forms.Label();
            this.btClearFields = new System.Windows.Forms.Button();
            this.btClearSearchField = new System.Windows.Forms.Button();
            this.GroupBoxCampos = new System.Windows.Forms.GroupBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            this.listAllDiretories = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.groupBoxDirectories = new System.Windows.Forms.GroupBox();
            this.lbFolderCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btClearListDirectories = new System.Windows.Forms.Button();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarParaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxCampos.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.groupBoxDirectories.SuspendLayout();
            this.SuspendLayout();
            // 
            // btList
            // 
            this.btList.Location = new System.Drawing.Point(543, 29);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(75, 23);
            this.btList.TabIndex = 0;
            this.btList.Text = "Listar";
            this.btList.UseVisualStyleBackColor = true;
            this.btList.Click += new System.EventHandler(this.btList_Click);
            // 
            // txtBoxFolderPath
            // 
            this.txtBoxFolderPath.Location = new System.Drawing.Point(146, 30);
            this.txtBoxFolderPath.Name = "txtBoxFolderPath";
            this.txtBoxFolderPath.Size = new System.Drawing.Size(350, 20);
            this.txtBoxFolderPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho da Pasta:";
            // 
            // listBoxAllFiles
            // 
            this.listBoxAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAllFiles.FormattingEnabled = true;
            this.listBoxAllFiles.Location = new System.Drawing.Point(22, 35);
            this.listBoxAllFiles.Name = "listBoxAllFiles";
            this.listBoxAllFiles.Size = new System.Drawing.Size(416, 342);
            this.listBoxAllFiles.TabIndex = 3;
            this.listBoxAllFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxAllFiles_KeyDown);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.Red;
            this.btClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClear.Location = new System.Drawing.Point(405, 11);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(31, 23);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "X";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(146, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar:";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(543, 58);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Buscar";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caminhoDaPastaToolStripMenuItem,
            this.buscarToolStripMenuItem1,
            this.listaToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // caminhoDaPastaToolStripMenuItem
            // 
            this.caminhoDaPastaToolStripMenuItem.Name = "caminhoDaPastaToolStripMenuItem";
            this.caminhoDaPastaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.caminhoDaPastaToolStripMenuItem.Text = "Caminho da pasta";
            this.caminhoDaPastaToolStripMenuItem.Click += new System.EventHandler(this.caminhoDaPastaToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listaToolStripMenuItem.Text = "Listas";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // lbLabelCount
            // 
            this.lbLabelCount.AutoSize = true;
            this.lbLabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelCount.Location = new System.Drawing.Point(286, 383);
            this.lbLabelCount.Name = "lbLabelCount";
            this.lbLabelCount.Size = new System.Drawing.Size(74, 20);
            this.lbLabelCount.TabIndex = 9;
            this.lbLabelCount.Text = "Arquivos:";
            // 
            // btClearFields
            // 
            this.btClearFields.BackColor = System.Drawing.Color.Red;
            this.btClearFields.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClearFields.Location = new System.Drawing.Point(502, 29);
            this.btClearFields.Name = "btClearFields";
            this.btClearFields.Size = new System.Drawing.Size(21, 23);
            this.btClearFields.TabIndex = 10;
            this.btClearFields.Text = "X";
            this.btClearFields.UseVisualStyleBackColor = false;
            this.btClearFields.Click += new System.EventHandler(this.btClearFields_Click);
            // 
            // btClearSearchField
            // 
            this.btClearSearchField.BackColor = System.Drawing.Color.Red;
            this.btClearSearchField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClearSearchField.Location = new System.Drawing.Point(502, 60);
            this.btClearSearchField.Name = "btClearSearchField";
            this.btClearSearchField.Size = new System.Drawing.Size(21, 23);
            this.btClearSearchField.TabIndex = 11;
            this.btClearSearchField.Text = "X";
            this.btClearSearchField.UseVisualStyleBackColor = false;
            this.btClearSearchField.Click += new System.EventHandler(this.btClearSearchField_Click);
            // 
            // GroupBoxCampos
            // 
            this.GroupBoxCampos.Controls.Add(this.txtSearch);
            this.GroupBoxCampos.Controls.Add(this.btClearSearchField);
            this.GroupBoxCampos.Controls.Add(this.btList);
            this.GroupBoxCampos.Controls.Add(this.btClearFields);
            this.GroupBoxCampos.Controls.Add(this.txtBoxFolderPath);
            this.GroupBoxCampos.Controls.Add(this.label1);
            this.GroupBoxCampos.Controls.Add(this.btSearch);
            this.GroupBoxCampos.Controls.Add(this.label2);
            this.GroupBoxCampos.Location = new System.Drawing.Point(143, 37);
            this.GroupBoxCampos.Name = "GroupBoxCampos";
            this.GroupBoxCampos.Size = new System.Drawing.Size(681, 115);
            this.GroupBoxCampos.TabIndex = 12;
            this.GroupBoxCampos.TabStop = false;
            this.GroupBoxCampos.Text = "Campos";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(166, 383);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btOpenFile.TabIndex = 12;
            this.btOpenFile.Text = "Abrir";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(360, 383);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(18, 20);
            this.lbCount.TabIndex = 13;
            this.lbCount.Text = "0";
            // 
            // listAllDiretories
            // 
            this.listAllDiretories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAllDiretories.FormattingEnabled = true;
            this.listAllDiretories.Location = new System.Drawing.Point(6, 32);
            this.listAllDiretories.Name = "listAllDiretories";
            this.listAllDiretories.Size = new System.Drawing.Size(404, 342);
            this.listAllDiretories.TabIndex = 14;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.btOpenFile);
            this.groupBoxFiles.Controls.Add(this.listBoxAllFiles);
            this.groupBoxFiles.Controls.Add(this.lbCount);
            this.groupBoxFiles.Controls.Add(this.btClear);
            this.groupBoxFiles.Controls.Add(this.lbLabelCount);
            this.groupBoxFiles.Location = new System.Drawing.Point(36, 158);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(453, 416);
            this.groupBoxFiles.TabIndex = 15;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Arquivos";
            // 
            // groupBoxDirectories
            // 
            this.groupBoxDirectories.Controls.Add(this.lbFolderCount);
            this.groupBoxDirectories.Controls.Add(this.label3);
            this.groupBoxDirectories.Controls.Add(this.btClearListDirectories);
            this.groupBoxDirectories.Controls.Add(this.listAllDiretories);
            this.groupBoxDirectories.Location = new System.Drawing.Point(521, 164);
            this.groupBoxDirectories.Name = "groupBoxDirectories";
            this.groupBoxDirectories.Size = new System.Drawing.Size(425, 410);
            this.groupBoxDirectories.TabIndex = 16;
            this.groupBoxDirectories.TabStop = false;
            this.groupBoxDirectories.Text = "Pastas";
            // 
            // lbFolderCount
            // 
            this.lbFolderCount.AutoSize = true;
            this.lbFolderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolderCount.Location = new System.Drawing.Point(349, 377);
            this.lbFolderCount.Name = "lbFolderCount";
            this.lbFolderCount.Size = new System.Drawing.Size(18, 20);
            this.lbFolderCount.TabIndex = 14;
            this.lbFolderCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pastas: ";
            // 
            // btClearListDirectories
            // 
            this.btClearListDirectories.BackColor = System.Drawing.Color.Red;
            this.btClearListDirectories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClearListDirectories.Location = new System.Drawing.Point(379, 7);
            this.btClearListDirectories.Name = "btClearListDirectories";
            this.btClearListDirectories.Size = new System.Drawing.Size(31, 23);
            this.btClearListDirectories.TabIndex = 14;
            this.btClearListDirectories.Text = "X";
            this.btClearListDirectories.UseVisualStyleBackColor = false;
            this.btClearListDirectories.Click += new System.EventHandler(this.btClearListDirectories_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarParaToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // copiarParaToolStripMenuItem
            // 
            this.copiarParaToolStripMenuItem.Name = "copiarParaToolStripMenuItem";
            this.copiarParaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarParaToolStripMenuItem.Text = "Copiar para";
            this.copiarParaToolStripMenuItem.Click += new System.EventHandler(this.copiarParaToolStripMenuItem_Click);
            // 
            // FFReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 614);
            this.Controls.Add(this.groupBoxDirectories);
            this.Controls.Add(this.GroupBoxCampos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FFReaderForm";
            this.Text = "FFReader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxCampos.ResumeLayout(false);
            this.GroupBoxCampos.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.groupBoxDirectories.ResumeLayout(false);
            this.groupBoxDirectories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btList;
        private System.Windows.Forms.TextBox txtBoxFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAllFiles;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Label lbLabelCount;
        private System.Windows.Forms.Button btClearFields;
        private System.Windows.Forms.Button btClearSearchField;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminhoDaPastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBoxCampos;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.ListBox listAllDiretories;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.GroupBox groupBoxDirectories;
        private System.Windows.Forms.Button btClearListDirectories;
        private System.Windows.Forms.Label lbFolderCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarParaToolStripMenuItem;
    }
}

