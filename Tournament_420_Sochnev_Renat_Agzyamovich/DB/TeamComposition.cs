//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_420_Sochnev_Renat_Agzyamovich.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamComposition
    {
        public int Id { get; set; }
        public Nullable<int> IdTeam { get; set; }
        public Nullable<int> IdPlayer { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
