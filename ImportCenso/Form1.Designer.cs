namespace ImportCenso
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte do Designer - não modifique
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btn_abrirdocumento = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_arquivo = new System.Windows.Forms.TextBox();
			this.btn_iniciar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btn_abrirdocumento
			// 
			this.btn_abrirdocumento.Location = new System.Drawing.Point(12, 36);
			this.btn_abrirdocumento.Name = "btn_abrirdocumento";
			this.btn_abrirdocumento.Size = new System.Drawing.Size(75, 23);
			this.btn_abrirdocumento.TabIndex = 0;
			this.btn_abrirdocumento.Text = "Abrir";
			this.btn_abrirdocumento.UseVisualStyleBackColor = true;
			this.btn_abrirdocumento.Click += new System.EventHandler(this.btn_abrirdocumento_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Importação do Censo";
			// 
			// txt_arquivo
			// 
			this.txt_arquivo.Location = new System.Drawing.Point(93, 38);
			this.txt_arquivo.Name = "txt_arquivo";
			this.txt_arquivo.Size = new System.Drawing.Size(408, 20);
			this.txt_arquivo.TabIndex = 2;
			// 
			// btn_iniciar
			// 
			this.btn_iniciar.Location = new System.Drawing.Point(250, 113);
			this.btn_iniciar.Name = "btn_iniciar";
			this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
			this.btn_iniciar.TabIndex = 3;
			this.btn_iniciar.Text = "Iniciar";
			this.btn_iniciar.UseVisualStyleBackColor = true;
			this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 165);
			this.Controls.Add(this.btn_iniciar);
			this.Controls.Add(this.txt_arquivo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_abrirdocumento);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btn_abrirdocumento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_arquivo;
		private System.Windows.Forms.Button btn_iniciar;
	}
}

