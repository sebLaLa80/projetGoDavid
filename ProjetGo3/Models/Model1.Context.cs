﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetGo3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DotNetAppSqlDb_projetGoEntities : DbContext
    {
        public DotNetAppSqlDb_projetGoEntities()
            : base("name=DotNetAppSqlDb_projetGoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adherent> Adherents { get; set; }
        public virtual DbSet<AdherentCotisation> AdherentCotisations { get; set; }
        public virtual DbSet<Campagne> Campagnes { get; set; }
        public virtual DbSet<Comite> Comites { get; set; }
        public virtual DbSet<CompteRendu> CompteRendus { get; set; }
        public virtual DbSet<Cotisation> Cotisations { get; set; }
        public virtual DbSet<Don> Dons { get; set; }
        public virtual DbSet<Donateur> Donateurs { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Projet> Projets { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
