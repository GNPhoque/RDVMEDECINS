//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RDVMEDECINS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RV
    {
        public long ID { get; set; }
        public Nullable<System.DateTime> JOUR { get; set; }
        public Nullable<long> ID_CLIENT { get; set; }
        public Nullable<long> ID_CRENEAU { get; set; }
    
        public virtual CLIENTS CLIENTS { get; set; }
        public virtual CRENEAUX CRENEAUX { get; set; }
    }
}
