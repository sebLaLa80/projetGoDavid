//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Adherent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adherent()
        {
            this.AdherentCotisations = new HashSet<AdherentCotisation>();
            this.CompteRendus = new HashSet<CompteRendu>();
            this.Equipes = new HashSet<Equipe>();
        }
    
        public string codeAdherent { get; set; }
        public string nomAdherent { get; set; }
        public string prenomAdherent { get; set; }
        public string emailAdherent { get; set; }
        public string telephoneAdherent { get; set; }
        public string adresseAdherent { get; set; }
        public Nullable<System.DateTime> dateAdhesionAdherent { get; set; }
        public string statutAdhesionAdherent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdherentCotisation> AdherentCotisations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompteRendu> CompteRendus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipe> Equipes { get; set; }
    }
}
