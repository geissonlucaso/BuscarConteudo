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
            this.lblURLCount = new System.Windows.Forms.Label();
            this.lvwReults = new System.Windows.Forms.ListView();
            this.ch_urlResultado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_numCitacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblContador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lvwURLs = new System.Windows.Forms.ListView();
            this.ch_url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionarURL = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPesquisarPdf = new System.Windows.Forms.Button();
            this.txtPalavraPDF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPdfResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblURLCount);
            this.panel1.Controls.Add(this.lvwReults);
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRemover);
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
            this.panel1.Size = new System.Drawing.Size(786, 684);
            this.panel1.TabIndex = 0;
            // 
            // lblURLCount
            // 
            this.lblURLCount.AutoSize = true;
            this.lblURLCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLCount.Location = new System.Drawing.Point(352, 32);
            this.lblURLCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblURLCount.Name = "lblURLCount";
            this.lblURLCount.Size = new System.Drawing.Size(94, 24);
            this.lblURLCount.TabIndex = 15;
            this.lblURLCount.Text = "Resultado";
            // 
            // lvwReults
            // 
            this.lvwReults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_urlResultado,
            this.ch_numCitacoes});
            this.lvwReults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwReults.HideSelection = false;
            this.lvwReults.Location = new System.Drawing.Point(356, 68);
            this.lvwReults.MultiSelect = false;
            this.lvwReults.Name = "lvwReults";
            this.lvwReults.Size = new System.Drawing.Size(416, 603);
            this.lvwReults.TabIndex = 0;
            this.lvwReults.UseCompatibleStateImageBehavior = false;
            this.lvwReults.View = System.Windows.Forms.View.Details;
            this.lvwReults.DoubleClick += new System.EventHandler(this.VisitPage);
            this.lvwReults.MouseHover += new System.EventHandler(this.ShowTextURL);
            // 
            // ch_urlResultado
            // 
            this.ch_urlResultado.Text = "URL";
            this.ch_urlResultado.Width = 320;
            // 
            // ch_numCitacoes
            // 
            this.ch_numCitacoes.Text = "N° Citações";
            this.ch_numCitacoes.Width = 88;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(139, 157);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(24, 17);
            this.lblContador.TabIndex = 14;
            this.lblContador.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "URLs Adicionadas:";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemover.Location = new System.Drawing.Point(85, 106);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 29);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(236, 630);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 41);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lvwURLs
            // 
            this.lvwURLs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_url});
            this.lvwURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwURLs.HideSelection = false;
            this.lvwURLs.Location = new System.Drawing.Point(12, 177);
            this.lvwURLs.MultiSelect = false;
            this.lvwURLs.Name = "lvwURLs";
            this.lvwURLs.Size = new System.Drawing.Size(336, 412);
            this.lvwURLs.TabIndex = 7;
            this.lvwURLs.UseCompatibleStateImageBehavior = false;
            this.lvwURLs.View = System.Windows.Forms.View.Details;
            // 
            // ch_url
            // 
            this.ch_url.Text = "URL";
            this.ch_url.Width = 330;
            // 
            // btnAdicionarURL
            // 
            this.btnAdicionarURL.Location = new System.Drawing.Point(250, 106);
            this.btnAdicionarURL.Name = "btnAdicionarURL";
            this.btnAdicionarURL.Size = new System.Drawing.Size(98, 29);
            this.btnAdicionarURL.TabIndex = 6;
            this.btnAdicionarURL.Text = "&Adicionar";
            this.btnAdicionarURL.UseVisualStyleBackColor = true;
            this.btnAdicionarURL.Click += new System.EventHandler(this.btnAdicionarURL_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(85, 68);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(263, 29);
            this.txtURL.TabIndex = 5;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(8, 73);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(46, 24);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "URL";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(85, 595);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(263, 29);
            this.txtPalavra.TabIndex = 3;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(8, 600);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(71, 24);
            this.lblPalavra.TabIndex = 2;
            this.lblPalavra.Text = "Palavra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Citações (URL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "PDF";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnPesquisarPdf);
            this.panel2.Controls.Add(this.txtPalavraPDF);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblPdfResult);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(810, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 684);
            this.panel2.TabIndex = 0;
            // 
            // btnPesquisarPdf
            // 
            this.btnPesquisarPdf.Location = new System.Drawing.Point(386, 142);
            this.btnPesquisarPdf.Name = "btnPesquisarPdf";
            this.btnPesquisarPdf.Size = new System.Drawing.Size(127, 41);
            this.btnPesquisarPdf.TabIndex = 21;
            this.btnPesquisarPdf.Text = "&Pesquisar";
            this.btnPesquisarPdf.UseVisualStyleBackColor = true;
            this.btnPesquisarPdf.Click += new System.EventHandler(this.btnPesquisarPdf_Click);
            // 
            // txtPalavraPDF
            // 
            this.txtPalavraPDF.Location = new System.Drawing.Point(88, 147);
            this.txtPalavraPDF.Name = "txtPalavraPDF";
            this.txtPalavraPDF.Size = new System.Drawing.Size(214, 29);
            this.txtPalavraPDF.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Palavra";
            // 
            // lblPdfResult
            // 
            this.lblPdfResult.AutoSize = true;
            this.lblPdfResult.Location = new System.Drawing.Point(111, 631);
            this.lblPdfResult.Name = "lblPdfResult";
            this.lblPdfResult.Size = new System.Drawing.Size(40, 24);
            this.lblPdfResult.TabIndex = 18;
            this.lblPdfResult.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Buscar Citações (PDF)";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(88, 65);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(186, 41);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "&Abrir Documento";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 405);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 711);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader ch_url;
        private System.Windows.Forms.ListView lvwReults;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader ch_numCitacoes;
        private System.Windows.Forms.ColumnHeader ch_urlResultado;
        private System.Windows.Forms.ColumnHeader ch_siteNome;
        private System.Windows.Forms.Label lblURLCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblPdfResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarPdf;
        private System.Windows.Forms.TextBox txtPalavraPDF;
        private System.Windows.Forms.Label label7;
    }
}

