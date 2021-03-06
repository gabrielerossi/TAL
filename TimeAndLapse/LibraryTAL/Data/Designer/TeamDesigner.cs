// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.52
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace LibraryTAL.Data.Designer
{
    // Teams
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Team
    {
        public Guid TeamId { get; set; } // TeamID (Primary key)
        public string Code { get; set; } // Code
        public string Description { get; set; } // Description
        public string Place { get; set; } // Place
        public string President { get; set; } // President
        public string Address { get; set; } // Address
        public byte[] Logo { get; set; } // Logo
        public string Email { get; set; } // Email

        // Reverse navigation
        public virtual ICollection<Player> Players { get; set; } // Players.FK__Players__TeamID__178D7CA5
        
        public Team()
        {
            Players = new List<Player>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
