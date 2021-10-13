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
    public partial class FormCopyTo : Form
    {
        public FormCopyTo()
        {
            InitializeComponent();
        }

        private void btCopyTo_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = txtFrom.Text;
                string destinyPath = txtTo.Text;
                int count = 0;

                if (String.IsNullOrEmpty(sourcePath))
                {
                    MessageBox.Show("Preencha o caminho da pasta de origem com um caminho valido.");
                    return;
                }
                if (String.IsNullOrEmpty(txtFileNames.Text))
                {
                    MessageBox.Show("Preencha o campo nomes dos arquivos, com os nomes separados por vírgula (,).");
                }


                string[] arquivos = Directory.GetFiles(sourcePath);

                string fileNames = txtFileNames.Text;

                fileNames = fileNames.Replace("\n", "");
                fileNames = fileNames.Replace("=\r\n", "");
                fileNames = fileNames.Replace(";\r\n", "");
                fileNames = fileNames.Replace("\t", "");
                fileNames = fileNames.Replace(@"\t|\n|\r", "");
                fileNames = fileNames.Replace("\"", "");
                fileNames = fileNames.Replace("  ", "");
                fileNames = fileNames.Replace("\n", String.Empty);

                string[] arquivosNomes = fileNames.Split(',');

                var listArquivosNomes = arquivosNomes.ToHashSet();

                foreach (string arq in arquivos)
                {
                    string fileName = Path.GetFileNameWithoutExtension(arq);

                    var result = listArquivosNomes.Contains(fileName);

                    if (result)
                    {
                        count++;
                        var arquivo = Path.GetFileName(arq);
                        var arquivoFullPath = arq;
                        CopyFileTo(arquivoFullPath, Path.Combine(destinyPath, arquivo));
                    }

                }
                
                MessageBox.Show($"A copia terminou.Foram copiados {count} arquivos.");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        private void CopyFileTo(string source, string destiny)
        {
            try
            {
                File.Copy(source, destiny, true);
                //MessageBox.Show($"Arquivo de: {source} Copiado com sucesso \npara: {destiny}");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }

        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = txtFrom.Text;
                int count = 0;
                //string destinyPath = txtTo.Text;

                if (String.IsNullOrEmpty(sourcePath))
                {
                    MessageBox.Show("Preencha o caminho da pasta de origem com um caminho valido.");
                    return;
                }

                if (String.IsNullOrEmpty(txtFileNames.Text))
                {
                    MessageBox.Show("Preencha o campo nomes dos arquivos, com os nomes separados por vírgula (,).");
                }

                string[] arquivos = Directory.GetFiles(sourcePath);


                string fileNames = txtFileNames.Text;


                fileNames = fileNames.Replace("\n", "");
                fileNames = fileNames.Replace("=\r\n", "");
                fileNames = fileNames.Replace(";\r\n", "");
                fileNames = fileNames.Replace("\t", "");
                fileNames = fileNames.Replace(@"\t|\n|\r", "");
                fileNames = fileNames.Replace("\"", "");
                fileNames = fileNames.Replace("  ", "");
                fileNames = fileNames.Replace(" ", "");
                fileNames = fileNames.Replace("\n", String.Empty);

                string[] arquivosNomes = fileNames.Split(',');
                //Teste
                var listArquivosNomes = arquivosNomes.ToHashSet();

                foreach (string arq in arquivos)
                {

                    string fileName = Path.GetFileNameWithoutExtension(arq);
                    string fileNameWithExtension = Path.GetFileName(arq);

                    var result = listArquivosNomes.Contains(fileName) || listArquivosNomes.Contains(fileNameWithExtension);

                    if (result)
                    {
                        count++;
                    }

                }

                MessageBox.Show($"Foram escontrados {count.ToString()} arquivos.");

                DialogResult resultDialog = MessageBox.Show("Você quer copiar esses arquivos?", "Confirmar", MessageBoxButtons.YesNoCancel);
                if (resultDialog == DialogResult.Yes){
                    
                }
                else if (resultDialog == DialogResult.No){ }



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }
    }
}
