namespace Lançar_Nota
{
    partial class FrmLancarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLancarNota));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtFalta = new System.Windows.Forms.TextBox();
            this.TxtTrab = new System.Windows.Forms.TextBox();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblFalta = new System.Windows.Forms.Label();
            this.LblTrab = new System.Windows.Forms.Label();
            this.LblNota3 = new System.Windows.Forms.Label();
            this.LblNota2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNota1 = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmImporta = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvLancarNota = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabalhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Média = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsLancarNota = new System.Windows.Forms.BindingSource(this.components);
            this.DtsCadastrar = new System.Data.DataSet();
            this.DttLancarNota = new System.Data.DataTable();
            this.DtcNome = new System.Data.DataColumn();
            this.DtcNúmero = new System.Data.DataColumn();
            this.DtcNota1 = new System.Data.DataColumn();
            this.DtcNota2 = new System.Data.DataColumn();
            this.DtcNota3 = new System.Data.DataColumn();
            this.DtcTrabalho = new System.Data.DataColumn();
            this.DtcFalta = new System.Data.DataColumn();
            this.DtcMedia = new System.Data.DataColumn();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLancarNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsLancarNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DttLancarNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.TxtFalta);
            this.groupBox1.Controls.Add(this.TxtTrab);
            this.groupBox1.Controls.Add(this.TxtNota3);
            this.groupBox1.Controls.Add(this.TxtNota2);
            this.groupBox1.Controls.Add(this.TxtNota1);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.LblFalta);
            this.groupBox1.Controls.Add(this.LblTrab);
            this.groupBox1.Controls.Add(this.LblNota3);
            this.groupBox1.Controls.Add(this.LblNota2);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.LblNota1);
            this.groupBox1.Controls.Add(this.LblNumero);
            this.groupBox1.Controls.Add(this.LblNome);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(260, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de dados";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.Location = new System.Drawing.Point(76, 439);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(109, 49);
            this.BtnCadastrar.TabIndex = 7;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxtFalta
            // 
            this.TxtFalta.Location = new System.Drawing.Point(10, 341);
            this.TxtFalta.Name = "TxtFalta";
            this.TxtFalta.Size = new System.Drawing.Size(243, 24);
            this.TxtFalta.TabIndex = 6;
            this.TxtFalta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            // 
            // TxtTrab
            // 
            this.TxtTrab.Location = new System.Drawing.Point(10, 293);
            this.TxtTrab.Name = "TxtTrab";
            this.TxtTrab.Size = new System.Drawing.Size(243, 24);
            this.TxtTrab.TabIndex = 5;
            this.TxtTrab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            this.TxtTrab.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTrab_Validating);
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(10, 245);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(243, 24);
            this.TxtNota3.TabIndex = 4;
            this.TxtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            this.TxtNota3.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNota3_Validating);
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(10, 197);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(243, 24);
            this.TxtNota2.TabIndex = 3;
            this.TxtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            this.TxtNota2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNota2_Validating);
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(10, 149);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(243, 24);
            this.TxtNota1.TabIndex = 2;
            this.TxtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            this.TxtNota1.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNota1_Validating);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(10, 101);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(243, 24);
            this.TxtNumero.TabIndex = 1;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbers);
            // 
            // LblFalta
            // 
            this.LblFalta.AutoSize = true;
            this.LblFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFalta.Location = new System.Drawing.Point(7, 320);
            this.LblFalta.Name = "LblFalta";
            this.LblFalta.Size = new System.Drawing.Size(66, 18);
            this.LblFalta.TabIndex = 0;
            this.LblFalta.Text = "Falta(s)";
            // 
            // LblTrab
            // 
            this.LblTrab.AutoSize = true;
            this.LblTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrab.Location = new System.Drawing.Point(7, 272);
            this.LblTrab.Name = "LblTrab";
            this.LblTrab.Size = new System.Drawing.Size(74, 18);
            this.LblTrab.TabIndex = 0;
            this.LblTrab.Text = "Trabalho";
            // 
            // LblNota3
            // 
            this.LblNota3.AutoSize = true;
            this.LblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota3.Location = new System.Drawing.Point(7, 224);
            this.LblNota3.Name = "LblNota3";
            this.LblNota3.Size = new System.Drawing.Size(58, 18);
            this.LblNota3.TabIndex = 0;
            this.LblNota3.Text = "Nota 3";
            // 
            // LblNota2
            // 
            this.LblNota2.AutoSize = true;
            this.LblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota2.Location = new System.Drawing.Point(7, 176);
            this.LblNota2.Name = "LblNota2";
            this.LblNota2.Size = new System.Drawing.Size(58, 18);
            this.LblNota2.TabIndex = 0;
            this.LblNota2.Text = "Nota 2";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(10, 53);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(243, 24);
            this.TxtNome.TabIndex = 0;
            // 
            // LblNota1
            // 
            this.LblNota1.AutoSize = true;
            this.LblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota1.Location = new System.Drawing.Point(7, 128);
            this.LblNota1.Name = "LblNota1";
            this.LblNota1.Size = new System.Drawing.Size(58, 18);
            this.LblNota1.TabIndex = 0;
            this.LblNota1.Text = "Nota 1";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(7, 80);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(68, 18);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Número";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(7, 32);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(53, 18);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmExportar,
            this.TsmImporta,
            this.TsmLimpar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmExportar
            // 
            this.TsmExportar.Image = ((System.Drawing.Image)(resources.GetObject("TsmExportar.Image")));
            this.TsmExportar.Name = "TsmExportar";
            this.TsmExportar.Size = new System.Drawing.Size(79, 20);
            this.TsmExportar.Text = "Exportar";
            this.TsmExportar.Click += new System.EventHandler(this.TsmExportar_Click);
            // 
            // TsmImporta
            // 
            this.TsmImporta.Image = ((System.Drawing.Image)(resources.GetObject("TsmImporta.Image")));
            this.TsmImporta.Name = "TsmImporta";
            this.TsmImporta.Size = new System.Drawing.Size(77, 20);
            this.TsmImporta.Text = "Importa";
            this.TsmImporta.Click += new System.EventHandler(this.TsmImporta_Click);
            // 
            // TsmLimpar
            // 
            this.TsmLimpar.Image = ((System.Drawing.Image)(resources.GetObject("TsmLimpar.Image")));
            this.TsmLimpar.Name = "TsmLimpar";
            this.TsmLimpar.Size = new System.Drawing.Size(72, 20);
            this.TsmLimpar.Text = "Limpar";
            this.TsmLimpar.Click += new System.EventHandler(this.TsmLimpar_Click);
            // 
            // DgvLancarNota
            // 
            this.DgvLancarNota.AutoGenerateColumns = false;
            this.DgvLancarNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLancarNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn,
            this.trabalhoDataGridViewTextBoxColumn,
            this.faltasDataGridViewTextBoxColumn,
            this.Média});
            this.DgvLancarNota.DataSource = this.BsLancarNota;
            this.DgvLancarNota.Enabled = false;
            this.DgvLancarNota.Location = new System.Drawing.Point(280, 60);
            this.DgvLancarNota.Name = "DgvLancarNota";
            this.DgvLancarNota.ReadOnly = true;
            this.DgvLancarNota.Size = new System.Drawing.Size(843, 551);
            this.DgvLancarNota.TabIndex = 2;
            this.DgvLancarNota.TabStop = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N°";
            this.nDataGridViewTextBoxColumn.HeaderText = "N°";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota 1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "Nota 1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            this.nota1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota 2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "Nota 2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            this.nota2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "Nota 3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "Nota 3";
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            this.nota3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trabalhoDataGridViewTextBoxColumn
            // 
            this.trabalhoDataGridViewTextBoxColumn.DataPropertyName = "Trabalho";
            this.trabalhoDataGridViewTextBoxColumn.HeaderText = "Trabalho";
            this.trabalhoDataGridViewTextBoxColumn.Name = "trabalhoDataGridViewTextBoxColumn";
            this.trabalhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faltasDataGridViewTextBoxColumn
            // 
            this.faltasDataGridViewTextBoxColumn.DataPropertyName = "Falta(s)";
            this.faltasDataGridViewTextBoxColumn.HeaderText = "Falta(s)";
            this.faltasDataGridViewTextBoxColumn.Name = "faltasDataGridViewTextBoxColumn";
            this.faltasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Média
            // 
            this.Média.DataPropertyName = "Média";
            this.Média.HeaderText = "Média";
            this.Média.Name = "Média";
            this.Média.ReadOnly = true;
            // 
            // BsLancarNota
            // 
            this.BsLancarNota.DataMember = "LancarNota";
            this.BsLancarNota.DataSource = this.DtsCadastrar;
            // 
            // DtsCadastrar
            // 
            this.DtsCadastrar.DataSetName = "Cadastrar";
            this.DtsCadastrar.Tables.AddRange(new System.Data.DataTable[] {
            this.DttLancarNota});
            // 
            // DttLancarNota
            // 
            this.DttLancarNota.Columns.AddRange(new System.Data.DataColumn[] {
            this.DtcNome,
            this.DtcNúmero,
            this.DtcNota1,
            this.DtcNota2,
            this.DtcNota3,
            this.DtcTrabalho,
            this.DtcFalta,
            this.DtcMedia});
            this.DttLancarNota.TableName = "LancarNota";
            // 
            // DtcNome
            // 
            this.DtcNome.ColumnName = "Nome";
            // 
            // DtcNúmero
            // 
            this.DtcNúmero.ColumnName = "N°";
            // 
            // DtcNota1
            // 
            this.DtcNota1.ColumnName = "Nota 1";
            // 
            // DtcNota2
            // 
            this.DtcNota2.ColumnName = "Nota 2";
            // 
            // DtcNota3
            // 
            this.DtcNota3.ColumnName = "Nota 3";
            // 
            // DtcTrabalho
            // 
            this.DtcTrabalho.ColumnName = "Trabalho";
            // 
            // DtcFalta
            // 
            this.DtcFalta.ColumnName = "Falta(s)";
            // 
            // DtcMedia
            // 
            this.DtcMedia.ColumnName = "Média";
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "",
            "Nome",
            "Número"});
            this.CmbFiltro.Location = new System.Drawing.Point(354, 25);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(157, 26);
            this.CmbFiltro.TabIndex = 3;
            this.CmbFiltro.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Procurar por:";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(652, 27);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(137, 24);
            this.TxtFiltro.TabIndex = 5;
            this.TxtFiltro.TabStop = false;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmLancarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.DgvLancarNota);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLancarNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar Nota";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLancarNota_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLancarNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsLancarNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DttLancarNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView DgvLancarNota;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.BindingSource BsLancarNota;
        private System.Data.DataSet DtsCadastrar;
        private System.Windows.Forms.TextBox TxtFalta;
        private System.Windows.Forms.TextBox TxtTrab;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblFalta;
        private System.Windows.Forms.Label LblTrab;
        private System.Windows.Forms.Label LblNota3;
        private System.Windows.Forms.Label LblNota2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNota1;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblNome;
        private System.Data.DataTable DttLancarNota;
        private System.Data.DataColumn DtcNome;
        private System.Data.DataColumn DtcNúmero;
        private System.Data.DataColumn DtcNota1;
        private System.Data.DataColumn DtcNota2;
        private System.Data.DataColumn DtcNota3;
        private System.Data.DataColumn DtcTrabalho;
        private System.Data.DataColumn DtcFalta;
        private System.Data.DataColumn DtcMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabalhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Média;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem TsmExportar;
        private System.Windows.Forms.ToolStripMenuItem TsmImporta;
        private System.Windows.Forms.ToolStripMenuItem TsmLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

