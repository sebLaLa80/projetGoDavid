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
    
    public partial class Equipe
    {
        public string codeProjet { get; set; }
        public string codeAdherent { get; set; }
    
        public virtual Adherent Adherent { get; set; }
        public virtual Projet Projet { get; set; }
    }
}
