//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImportCenso.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class alunos_pessoais
    {
        public long inep_escola { get; set; }
        public long inep_aluno { get; set; }
        public string codigo_aluno { get; set; }
        public string identidade_aluno { get; set; }
        public Nullable<int> orgao_emissor_aluno { get; set; }
        public Nullable<int> uf_identidade_aluno { get; set; }
        public Nullable<System.DateTime> dataexped_identidade_aluno { get; set; }
        public Nullable<int> certidao_civil_aluno { get; set; }
        public Nullable<int> tipo_certidao_civil_aluno { get; set; }
        public string num_termo_aluno { get; set; }
        public string folha_aluno { get; set; }
        public string livro_aluno { get; set; }
        public Nullable<System.DateTime> data_emissao_certidao_aluno { get; set; }
        public Nullable<int> uf_cartorio_aluno { get; set; }
        public Nullable<int> municipio_cartorio_aluno { get; set; }
        public Nullable<int> codigo_cartorio_aluno { get; set; }
        public string num_matricula_aluno { get; set; }
        public string cpf_aluno { get; set; }
        public string passaporte_aluno { get; set; }
        public Nullable<int> nis_aluno { get; set; }
        public Nullable<int> local_residencia_aluno { get; set; }
        public string cep_aluno { get; set; }
        public string endereco_aluno { get; set; }
        public string num_residencia_aluno { get; set; }
        public string complemento_aluno { get; set; }
        public string bairro_aluno { get; set; }
        public Nullable<int> uf_aluno { get; set; }
        public Nullable<int> municipio_aluno { get; set; }
    
        public virtual alunos alunos { get; set; }
        public virtual escolas escolas { get; set; }
    }
}
