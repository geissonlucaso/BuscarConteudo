namespace BuscarConteudo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbPDF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbURL = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lvwURLs = new System.Windows.Forms.ListView();
            this.btnAdicionarURL = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.ch_numCitacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_urlResultado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_siteNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.rdbPDF);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdbURL);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.lvwURLs);
            this.panel1.Controls.Add(this.btnAdicionarURL);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.lblURL);
            this.panel1.Controls.Add(this.txtPalavra);
            this.panel1.Controls.Add(this.lblPalavra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 637);
            this.panel1.TabIndex = 0;
            // 
            // rdbPDF
            // 
            this.rdbPDF.AutoSize = true;
            this.rdbPDF.Location = new System.Drawing.Point(283, 56);
            this.rdbPDF.Name = "rdbPDF";
            this.rdbPDF.Size = new System.Drawing.Size(65, 28);
            this.rdbPDF.TabIndex = 11;
            this.rdbPDF.TabStop = true;
            this.rdbPDF.Text = "PDF";
            this.rdbPDF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "PDF";
            // 
            // rdbURL
            // 
            this.rdbURL.AutoSize = true;
            this.rdbURL.Location = new System.Drawing.Point(12, 56);
            this.rdbURL.Name = "rdbURL";
            this.rdbURL.Size = new System.Drawing.Size(64, 28);
            this.rdbURL.TabIndex = 9;
            this.rdbURL.TabStop = true;
            this.rdbURL.Text = "URL";
            this.rdbURL.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(236, 581);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 41);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lvwURLs
            // 
            this.lvwURLs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_url});
            this.lvwURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwURLs.HideSelection = false;
            this.lvwURLs.Location = new System.Drawing.Point(12, 209);
            this.lvwURLs.MultiSelect = false;
            this.lvwURLs.Name = "lvwURLs";
            this.lvwURLs.Size = new System.Drawing.Size(336, 167);
            this.lvwURLs.TabIndex = 7;
            this.lvwURLs.UseCompatibleStateImageBehavior = false;
            this.lvwURLs.View = System.Windows.Forms.View.Details;
            // 
            // btnAdicionarURL
            // 
            this.btnAdicionarURL.Location = new System.Drawing.Point(250, 141);
            this.btnAdicionarURL.Name = "btnAdicionarURL";
            this.btnAdicionarURL.Size = new System.Drawing.Size(98, 29);
            this.btnAdicionarURL.TabIndex = 6;
            this.btnAdicionarURL.Text = "Adicionar";
            this.btnAdicionarURL.UseVisualStyleBackColor = true;
            this.btnAdicionarURL.Click += new System.EventHandler(this.btnAdicionarURL_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(85, 106);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(263, 29);
            this.txtURL.TabIndex = 5;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(8, 111);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(46, 24);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "URL";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(85, 528);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(263, 29);
            this.txtPalavra.TabIndex = 3;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(8, 533);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(71, 24);
            this.lblPalavra.TabIndex = 2;
            this.lblPalavra.Text = "Palavra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Citações";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtH);
            this.panel2.Controls.Add(this.lblH);
            this.panel2.Controls.Add(this.lblQ);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(388, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 637);
            this.panel2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_siteNome,
            this.ch_urlResultado,
            this.ch_numCitacoes});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 56);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 550);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ch_url
            // 
            this.ch_url.Text = "URL";
            this.ch_url.Width = 330;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemover.Location = new System.Drawing.Point(85, 141);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 29);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "URLs Adicionadas:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(12, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 78);
            this.panel3.TabIndex = 1;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(139, 189);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(24, 17);
            this.lblContador.TabIndex = 14;
            this.lblContador.Text = "00";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(449, 19);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(25, 24);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "Q";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(68, 19);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(24, 24);
            this.lblH.TabIndex = 2;
            this.lblH.Text = "H";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.Location = new System.Drawing.Point(28, 302);
            this.txtH.Multiline = true;
            this.txtH.Name = "txtH";
            this.txtH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtH.Size = new System.Drawing.Size(477, 176);
            this.txtH.TabIndex = 3;
            // 
            // ch_numCitacoes
            // 
            this.ch_numCitacoes.Text = "N° Citações";
            this.ch_numCitacoes.Width = 86;
            // 
            // ch_urlResultado
            // 
            this.ch_urlResultado.Text = "URL";
            // 
            // ch_siteNome
            // 
            this.ch_siteNome.Text = "Site";
            this.ch_siteNome.Width = 114;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Buscar Palavras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwURLs;
        private System.Windows.Forms.Button btnAdicionarURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbURL;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader ch_url;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.ColumnHeader ch_numCitacoes;
        private System.Windows.Forms.ColumnHeader ch_urlResultado;
        private System.Windows.Forms.ColumnHeader ch_siteNome;
    }
}

