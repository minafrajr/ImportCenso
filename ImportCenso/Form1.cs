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
using ImportCenso.db;

namespace ImportCenso
{
	public partial class Form1 : Form
	{
		private censo_escolarEntities2 db_censo;
		private string arquivo;
		private string mensagem;


		public Form1()
		{
			InitializeComponent();

		}

		private void btn_abrirdocumento_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();

			txt_arquivo.Text = openFileDialog1.FileName;
		}

		private void btn_iniciar_Click(object sender, EventArgs e)
		{
			try
			{
				db_censo = new censo_escolarEntities2();

				List<string> mensagemLinha = new List<string>();
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Title = "importação Censo";
					openFileDialog.InitialDirectory = @"d:\desktop"; //Se ja quiser em abrir em um diretorio especifico
					openFileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
					openFileDialog.FilterIndex = 2;
					openFileDialog.RestoreDirectory = true;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
						arquivo = openFileDialog.FileName;
				}

				if (String.IsNullOrEmpty(arquivo))
				{
					MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK);
				}
				else
				{
					char[] delim = { '|' };
					using (StreamReader texto = new StreamReader(arquivo))
					{
						while (texto.Peek() >= 0)
						{
							string linha = texto.ReadLine();

							string[] arrStrings = linha.Split(delim, StringSplitOptions.None);

							switch (arrStrings[0])
							{
								case "00"://escola
									db_censo.escolas.Add(CriaEscola(arrStrings));
									db_censo.SaveChanges();
									break;
								case "10":
									db_censo.predios.Add(CriaPredio(arrStrings));
									db_censo.SaveChanges();
									break;
								case "20":
									db_censo.turmas_pedagogico.Add(CriaTurmaPedagogico(arrStrings));
									db_censo.SaveChanges();
									break;
								case "30":
									db_censo.profissionais_pessoais.Add(CriaProfissional(arrStrings));
									db_censo.SaveChanges();
									break;
								case "40":
									db_censo.profissionais_moradia.Add(CriaProfissionalMoradia(arrStrings));
									db_censo.SaveChanges();
									break;
								case "50":
									db_censo.profissionais_formacao.Add(CriaProfissionalFormacao(arrStrings));
									db_censo.SaveChanges();
									break;
								case "51":
									db_censo.turmas.Add(CriaTurma(arrStrings));
									db_censo.SaveChanges();
									break;
								case "60"://aluno
									db_censo.alunos.Add(CriaAluno(arrStrings));
									db_censo.SaveChanges();
									break;
								case "70":
									db_censo.alunos_pessoais.Add(CriaAlunoPessoais(arrStrings));
									db_censo.SaveChanges();
									break;
								case "80":
									db_censo.alunos_turmas.Add(CriaAlunosTurma(arrStrings));
									db_censo.SaveChanges();
									break;

							}

						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private alunos_turmas CriaAlunosTurma(string[] arrStrings)
		{
			throw new NotImplementedException();
		}

		private static alunos_pessoais CriaAlunoPessoais(IReadOnlyList<string> arrStrings)
		{
			return new alunos_pessoais()
			{
				inep_escola = Convert.ToInt64(arrStrings[1]),
				inep_aluno = Convert.ToInt64(arrStrings[2]),
				codigo_aluno = arrStrings[3],
				identidade_aluno = arrStrings[4],
				orgao_emissor_aluno = Convert.ToInt32(arrStrings[5]),
				uf_aluno = Convert.ToInt32(arrStrings[6]),
				dataexped_identidade_aluno = Convert.ToDateTime(arrStrings[7]),
				certidao_civil_aluno = Convert.ToInt32(arrStrings[8]),
				tipo_certidao_civil_aluno = Convert.ToInt32(arrStrings[9]),
				num_termo_aluno = arrStrings[10],
				folha_aluno = arrStrings[11],
				livro_aluno = arrStrings[12],
				data_emissao_certidao_aluno = Convert.ToDateTime(arrStrings[13]),
				uf_cartorio_aluno = Convert.ToInt32(arrStrings[14]),
				municipio_cartorio_aluno = Convert.ToInt32(arrStrings[14]),
				codigo_cartorio_aluno = Convert.ToInt32(arrStrings[15]),
				num_matricula_aluno = arrStrings[16],
				cpf_aluno = arrStrings[17],
				passaporte_aluno = arrStrings[18],
				nis_aluno = Convert.ToInt32(arrStrings[19]),
				local_residencia_aluno = Convert.ToInt32(arrStrings[20]),
				cep_aluno = arrStrings[21],
				endereco_aluno = arrStrings[22],
				num_residencia_aluno = arrStrings[23],
				complemento_aluno = arrStrings[24],
				bairro_aluno = arrStrings[25],
				uf_identidade_aluno = Convert.ToInt32(arrStrings[26]),
				municipio_aluno = Convert.ToInt32(arrStrings[27])
			};
		}

		private turmas CriaTurma(string[] arrStrings)
		{
			throw new NotImplementedException();
		}

		private profissionais_formacao CriaProfissionalFormacao(string[] arrStrings)
		{
			throw new NotImplementedException();
		}

		private profissionais_moradia CriaProfissionalMoradia(string[] arrStrings)
		{
			throw new NotImplementedException();
		}

		private profissionais_pessoais CriaProfissional(string[] arrStrings)
		{
			throw new NotImplementedException();
		}

		private turmas_pedagogico CriaTurmaPedagogico(string[] arrStrings)
		{
			throw new NotImplementedException();
		}

		private predios CriaPredio(string[] arrStrings)
		{
			throw new NotImplementedException();
		}

		private static escolas CriaEscola(IReadOnlyList<string> arrStrings)
		{
			escolas escola = new db.escolas
			{
				inep_escola = Convert.ToInt32(arrStrings[1]),
				cpf_gestor = arrStrings[2],
				nome_gestor = arrStrings[3],
				cargo_gestor = arrStrings[4].Equals("1"),
				email_gestor = arrStrings[5],
				situacao_escola = Convert.ToInt32(arrStrings[6]),
				inicio_letivo = Convert.ToDateTime(arrStrings[7]),
				final_letivo = Convert.ToDateTime(arrStrings[8]),
				nome_escola = arrStrings[9],
				latitude = arrStrings[10],
				longitude = arrStrings[11],
				cep = arrStrings[12],
				endereco = arrStrings[13],
				endereco_numero = arrStrings[14],
				endereco_complemento = arrStrings[15],
				bairro = arrStrings[16],
				uf_escola = Convert.ToUInt32(arrStrings[17]),
				municipio_escola = Convert.ToUInt32(arrStrings[18]),
				distrito_escola = Convert.ToUInt32(arrStrings[19]),
				DDD_escola = Convert.ToSByte(arrStrings[20]),
				telefone = arrStrings[21],
				telefone_publico = arrStrings[22],
				telefone_outro = arrStrings[23],
				fax_escola = arrStrings[24],
				email_escola = arrStrings[25],
				cod_regional_ensino = arrStrings[26],
				depend_adm = arrStrings[27].Equals("1")
			};
			return escola;
		}

		private static alunos CriaAluno(IReadOnlyList<string> arrStrings)
		{
			alunos aluno = new alunos()
			{
				inep_escola = Convert.ToInt64(arrStrings[1]),
				inep_aluno = Convert.ToInt64(arrStrings[2]),
				codigo_aluno = arrStrings[3],
				nome_aluno = arrStrings[4],
				data_nasc_aluno = Convert.ToDateTime(arrStrings[5]),
				sexo_aluno = arrStrings[6].Equals("1"),
				cor_raca_aluno = (int?)Convert.ToInt64(arrStrings[7]),
				possui_filiacao_aluno = arrStrings[8].Equals("1"),
				filiacao1_aluno = arrStrings[9],
				filiacao2_aluno = arrStrings[10],
				nacionalidade_aluno = (int?)Convert.ToInt64(arrStrings[11]),
				pais_origem_aluno = (int?)Convert.ToInt64(arrStrings[12]),
				uf_nasc_aluno = (int?)Convert.ToInt64(arrStrings[13]),
				municipio_nasc_aluno = (int?)Convert.ToInt64(arrStrings[14]),
				possui_deficiencia_aluno = arrStrings[15].Equals("1"),
				defic_cegueira_aluno = arrStrings[16].Equals("1"),
				defic_baixa_visao_aluno = arrStrings[17].Equals("1"),
				defic_surdez_aluno = arrStrings[18].Equals("1"),
				defic_defic_auditiva_aluno = arrStrings[19].Equals("1"),
				defic_surdocegueira_aluno = arrStrings[20].Equals("1"),
				defic_defic_fisica_aluno = arrStrings[21].Equals("1"),
				defic_defic_intelectual_aluno = arrStrings[22].Equals("1"),
				defic_defic_multipla_aluno = arrStrings[23].Equals("1"),
				defic_autismo_aluno = arrStrings[24].Equals("1"),
				defic_asperger_aluno = arrStrings[25].Equals("1"),
				defic_rett_aluno = arrStrings[26].Equals("1"),
				defic_superdotacao_aluno = arrStrings[27].Equals("1"),
				auxilio_ledor_aluno = arrStrings[28].Equals("1"),
				auxilio_transcricao = arrStrings[29].Equals("1"),
				guia_interprete = arrStrings[30].Equals("1"),
				interprete_libras = arrStrings[31].Equals("1"),
			};

			return aluno;
		}
	}
}
