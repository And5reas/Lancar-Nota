using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lançar_Nota
{
    public partial class FrmLancarNota : Form
    {
        #region Variáveis Globais
        Double trab, nota1, nota2, nota3, media, qtdLinhaFile;
        #endregion
        public FrmLancarNota()
        {
            InitializeComponent();
        }
        #region Cadastrar
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text.Length > 0 && TxtNota1.Text.Length > 0 && TxtNota2.Text.Length > 0 && TxtNota3.Text.Length > 0 &&
                TxtNumero.Text.Length > 0 && TxtTrab.Text.Length > 0 && TxtFalta.Text.Length > 0)
            {
                media = (nota1 + nota2 + nota3 + trab) / 4;
                DgvLancarNota.Enabled = true;
                DataRow novaLinha = DtsCadastrar.Tables["LancarNota"].NewRow();
                novaLinha["Nome"] = TxtNome.Text.ToString();
                novaLinha["N°"] = TxtNumero.Text.ToString();
                novaLinha["Nota 1"] = nota1.ToString();
                novaLinha["Nota 2"] = nota2.ToString();
                novaLinha["Nota 3"] = nota3.ToString();
                novaLinha["Trabalho"] = trab.ToString();
                novaLinha["Média"] = media.ToString();
                novaLinha["Falta(s)"] = TxtFalta.Text.ToString();
                DtsCadastrar.Tables["LancarNota"].Rows.Add(novaLinha);
                DgvLancarNota.Enabled = false;
                TxtFalta.Clear(); TxtNome.Clear(); TxtNota1.Clear(); TxtNota2.Clear(); TxtNota3.Clear(); TxtNumero.Clear(); TxtTrab.Clear();
                TxtNome.Focus();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Limpar
        private void TsmLimpar_Click(object sender, EventArgs e)
        {
            TxtFalta.Clear(); TxtNome.Clear(); TxtNota1.Clear(); TxtNota2.Clear(); TxtNota3.Clear(); TxtNumero.Clear(); TxtTrab.Clear(); TxtFiltro.Clear(); CmbFiltro.Text = "";
            TxtNome.Focus();
        }
        #endregion
        #region Sair
        private void FrmLancarNota_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion
        #region Exportar
        private void TsmExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo de Texto|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                for(int i = 0; i < DtsCadastrar.Tables["LancarNota"].Rows.Count; i++)
                {
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["Nome"]);
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["N°"]);
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["Nota 1"]);
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["Nota 2"]);
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["Nota 3"]);
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["Trabalho"]);
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["Falta(s)"]);
                    SW.WriteLine(DtsCadastrar.Tables["LancarNota"].Rows[i]["Média"]);
                    SW.WriteLine(String.Empty);
                }
                SW.Dispose();
            }
        }
        #endregion
        #region Importar
        private void TsmImporta_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos de Texto|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DgvLancarNota.Enabled = true;
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                qtdLinhaFile = File.ReadLines(openFileDialog1.FileName).Count();
                qtdLinhaFile = qtdLinhaFile / 8;
                for(int i = 0; i < qtdLinhaFile - 1; i++)
                {
                    DataRow novaLinha = DtsCadastrar.Tables["LancarNota"].NewRow();
                    novaLinha["Nome"] = SR.ReadLine();
                    novaLinha["N°"] = SR.ReadLine();
                    novaLinha["Nota 1"] = SR.ReadLine();
                    novaLinha["Nota 2"] = SR.ReadLine();
                    novaLinha["Nota 3"] = SR.ReadLine();
                    novaLinha["Trabalho"] = SR.ReadLine();
                    novaLinha["Falta(s)"] = SR.ReadLine();
                    novaLinha["Média"] = SR.ReadLine();
                    SR.ReadLine();
                    DtsCadastrar.Tables["LancarNota"].Rows.Add(novaLinha);
                }
                SR.Dispose();
                DgvLancarNota.Enabled = false;
            }
        }
        #endregion
        #region Apenas números
        public void JustNumbers(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 45 || e.KeyChar == 44 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
        #region Validar
        private void TxtNota1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (TxtNota1.Text != "")
                {
                    nota1 = Convert.ToDouble(TxtNota1.Text);
                    if (nota1 > 10)
                    {
                        MessageBox.Show("Nota maior que 10 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNota1.Clear();
                        TxtNota1.Focus();
                    }
                    else if (nota1 < 0)
                    {
                        MessageBox.Show("Nota menor que 0 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNota1.Clear();
                        TxtNota1.Focus();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Opa! Algo não ocorreu como o planejado...", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtNota2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (TxtNota2.Text != "")
                {
                    nota2 = Convert.ToDouble(TxtNota2.Text);
                    if (nota2 > 10)
                    {
                        MessageBox.Show("Nota maior que 10 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNota2.Clear();
                        TxtNota2.Focus();
                    }
                    else if (nota2 < 0)
                    {
                        MessageBox.Show("Nota menor que 0 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNota2.Clear();
                        TxtNota2.Focus();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Opa! Algo não ocorreu como o planejado...", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtNota3_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (TxtNota3.Text != "")
                {
                    nota3 = Convert.ToDouble(TxtNota3.Text);
                    if (nota3 > 10)
                    {
                        MessageBox.Show("Nota maior que 10 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNota3.Clear();
                        TxtNota3.Focus();
                    }
                    else if (nota3 < 0)
                    {
                        MessageBox.Show("Nota menor que 0 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNota3.Clear();
                        TxtNota3.Focus();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Opa! Algo não ocorreu como o planejado...", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtTrab_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (TxtTrab.Text != "")
                {
                    trab = Convert.ToDouble(TxtTrab.Text);
                    if (trab > 10)
                    {
                        MessageBox.Show("Nota maior que 10 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtTrab.Clear();
                        TxtTrab.Focus();
                    }
                    else if (trab < 0)
                    {
                        MessageBox.Show("Nota menor que 0 não é permitido!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtTrab.Clear();
                        TxtTrab.Focus();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Opa! Algo não ocorreu como o planejado...", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            switch (CmbFiltro.Text)
            {
                case "Nome":
                    BsLancarNota.Filter = "Nome like '%" + TxtFiltro.Text + "%'";
                    break;
                case "Número":
                    BsLancarNota.Filter = "N° like '%" + TxtFiltro.Text + "%'";
                    break;
                default:
                    MessageBox.Show("Escolha uma opção", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }

    }
}
