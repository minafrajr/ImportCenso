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
    
    public partial class alunos_turmas
    {
        public long inep_escola { get; set; }
        public long inep_aluno { get; set; }
        public string codigo_aluno { get; set; }
        public long inep_turma { get; set; }
        public string codigo_turma { get; set; }
        public Nullable<int> matricula_aluno { get; set; }
        public Nullable<int> turma_unificada { get; set; }
        public Nullable<int> turma_multietapa_eja_misto_tecnico { get; set; }
        public Nullable<int> escolarizacao_outro_espaco { get; set; }
        public Nullable<bool> transporte_publico { get; set; }
        public Nullable<int> responsavel_transporte { get; set; }
        public Nullable<bool> transporte_van_kombi { get; set; }
        public Nullable<bool> transporte_microonibus { get; set; }
        public Nullable<bool> transporte_onibus { get; set; }
        public Nullable<bool> transporte_bicicleta { get; set; }
        public Nullable<bool> transporte_tracao_animal { get; set; }
        public Nullable<bool> transporte_outro { get; set; }
        public Nullable<bool> aquaviario_ate5 { get; set; }
        public Nullable<bool> aquaviario_entre5e15 { get; set; }
        public Nullable<bool> aquaviario_entre15e35 { get; set; }
        public Nullable<bool> aquaviario_acima30 { get; set; }
        public Nullable<bool> ferroviario_metro { get; set; }
        public Nullable<int> forma_ingresso { get; set; }
    
        public virtual alunos alunos { get; set; }
        public virtual escolas escolas { get; set; }
        public virtual turmas turmas { get; set; }
    }
}