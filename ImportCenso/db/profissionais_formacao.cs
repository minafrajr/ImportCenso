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
    
    public partial class profissionais_formacao
    {
        public long inep_escola { get; set; }
        public long inep_profissional { get; set; }
        public string codigo_profissional { get; set; }
        public Nullable<int> escolaridade_profissional { get; set; }
        public Nullable<bool> situacao_superior1_profissional { get; set; }
        public Nullable<bool> complet_pedagogica1_profissional { get; set; }
        public string cod_curso_superior1_profissional { get; set; }
        public Nullable<int> ano_inicio_curso_superior1_profissional { get; set; }
        public Nullable<int> ano_conclus_curso_superior1_profissional { get; set; }
        public Nullable<int> ies_superior1_profissional { get; set; }
        public Nullable<bool> especializacao_profissional { get; set; }
        public Nullable<bool> mestrado_profissional { get; set; }
        public Nullable<bool> doutorado_profissional { get; set; }
        public Nullable<bool> pos_graduacao_profissional { get; set; }
        public Nullable<bool> outro_curso_creche_profissional { get; set; }
        public Nullable<bool> outro_curso_pre_escola_profissional { get; set; }
        public Nullable<bool> outro_curso_anos_iniciais_profissional { get; set; }
        public Nullable<bool> outro_curso_anos_finais_profissional { get; set; }
        public Nullable<bool> outro_curso_medio_profissional { get; set; }
        public Nullable<bool> outro_curso_eja_profissional { get; set; }
        public Nullable<bool> outro_curso_educ_especial { get; set; }
        public Nullable<bool> outro_curso_educ_indigena { get; set; }
        public Nullable<bool> outro_curso_educ_campo { get; set; }
        public Nullable<bool> outro_curso_educ_ambiental { get; set; }
        public Nullable<bool> outro_curso_direitos_humanos { get; set; }
        public Nullable<bool> outro_curso_genero_diver_sexual { get; set; }
        public Nullable<bool> outro_curso_direitos_cri_adoles { get; set; }
        public Nullable<bool> outro_curso_etnico_Afro { get; set; }
        public Nullable<bool> outro_curso_outros { get; set; }
        public Nullable<bool> outro_curso_nenhum { get; set; }
    
        public virtual profissionais_pessoais profissionais_pessoais { get; set; }
    }
}