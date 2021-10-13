using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorDeArquivoPasta
{
    public partial class FFReaderForm : Form
    {
        public FFReaderForm()
        {
            InitializeComponent();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listBoxAllFiles.Items.Clear();
            lbCount.Text = Convert.ToString(0);
        }

        private void btList_Click(object sender, EventArgs e)
        {
           

            string folderPath = txtBoxFolderPath.Text;
           


            if (String.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Preencha o caminho da pasta com um caminho valido.");
                return;
            }
            try
            {
                string[] diretorios = Directory.GetDirectories(folderPath);
                string[] arquivos = Directory.GetFiles(folderPath);

                listBoxAllFiles.Items.Clear();
                listAllDiretories.Items.Clear();

                foreach (string dir in diretorios)
                {
                    string diretory = Path.GetFileName(dir);
                    listAllDiretories.Items.Add(diretory.ToString());

                }

                foreach (string arq in arquivos)
                {
                    string fileName = Path.GetFileName(arq);
                    listBoxAllFiles.Items.Add(fileName.ToString());
                }

                lbCount.Text = Convert.ToString(arquivos.Length);
                lbFolderCount.Text = Convert.ToString(diretorios.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var obj = txtSearch.Text;
            listBoxAllFiles.ClearSelected();

            if (listBoxAllFiles.Items.Count == 0) {
                MessageBox.Show("A lista está vazia.");
                return; 
            }

            int index = listBoxAllFiles.FindString(obj);

            if (index < 0)
            {
                MessageBox.Show("Item não encontrado.");
                txtSearch.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Item - "+ obj + " foi encontrado");
                listBoxAllFiles.SelectedIndex = index;
            }

       

        }

        private void listBoxAllFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
                foreach (object item in listBoxAllFiles.SelectedItems)
                    copy_buffer.AppendLine(item.ToString());
                if (copy_buffer.Length > 0)
                    Clipboard.SetText(copy_buffer.ToString());
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = txtBoxFolderPath.Text;

            if (String.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Preencha o caminho da pasta com caminho valido.");
            }
            try
            {
                string[] diretorios = Directory.GetDirectories(folderPath);
                string[] arquivos = Directory.GetFiles(folderPath);

                listBoxAllFiles.Items.Clear();

                foreach (string dir in diretorios)
                {
                    string diretory = Path.GetFileName(dir);
                    listBoxAllFiles.Items.Add(diretory.ToString());

                }

                foreach (string arq in arquivos)
                {
                    string fileName = Path.GetFileName(arq);
                    listBoxAllFiles.Items.Add(fileName.ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = txtSearch.Text;
            listBoxAllFiles.ClearSelected();
            int index = listBoxAllFiles.FindString(obj);

            if (index < 0)
            {
                MessageBox.Show("Item not found.");
                txtSearch.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Item - " + obj + " foi encontrado");
                listBoxAllFiles.SelectedIndex = index;
            }

        }

        private void btClearFields_Click(object sender, EventArgs e)
        {
            txtBoxFolderPath.ResetText();
           
        }

        private void btClearSearchField_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
        }

        private void caminhoDaPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxFolderPath.ResetText();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxAllFiles.Items.Clear();
            listAllDiretories.Items.Clear();
            lbFolderCount.Text = Convert.ToString(0);
            lbCount.Text = Convert.ToString(0);
        }


        private void btOpenFile_Click(object sender, EventArgs e)
        {
            if (listBoxAllFiles.Items.Count == 0) {
                MessageBox.Show("Busque por um diretório valido. A lista está vazia");
                return;
            }
            string itemSelected = listBoxAllFiles.SelectedItem.ToString();
            string folderPath = txtBoxFolderPath.Text;

            string[] arquivos = Directory.GetFiles(folderPath);

            foreach (string arq in arquivos)
            {
                string fileName = Path.GetFileName(arq);
                if (itemSelected == fileName)
                {
                    System.Diagnostics.Process.Start(arq);
                }

            }
        }

 

        private void btClearListDirectories_Click(object sender, EventArgs e)
        {
            listAllDiretories.Items.Clear();
            lbFolderCount.Text = Convert.ToString(0);
        }

        private void copiarParaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCopyTo frm = new FormCopyTo();

            frm.Show();

        }
    }
}
