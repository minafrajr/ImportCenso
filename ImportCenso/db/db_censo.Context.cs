﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class censo_escolarEntities2 : DbContext
    {
        public censo_escolarEntities2()
            : base("name=censo_escolarEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<alunos> alunos { get; set; }
        public DbSet<alunos_turmas> alunos_turmas { get; set; }
        public DbSet<area_cursos_superior> area_cursos_superior { get; set; }
        public DbSet<cursos_superior> cursos_superior { get; set; }
        public DbSet<disciplinas> disciplinas { get; set; }
        public DbSet<escolas> escolas { get; set; }
        public DbSet<profissionais_pessoais> profissionais_pessoais { get; set; }
        public DbSet<turmas> turmas { get; set; }
        public DbSet<alunos_pessoais> alunos_pessoais { get; set; }
        public DbSet<predios> predios { get; set; }
        public DbSet<profissionais_formacao> profissionais_formacao { get; set; }
        public DbSet<profissionais_moradia> profissionais_moradia { get; set; }
        public DbSet<turmas_pedagogico> turmas_pedagogico { get; set; }
    }
}
