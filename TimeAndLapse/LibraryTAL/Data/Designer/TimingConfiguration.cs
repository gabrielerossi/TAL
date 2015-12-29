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
    // Timings
    public partial class TimingConfiguration : EntityTypeConfiguration<Timing>
    {
        public TimingConfiguration()
            : this("dbo")
        {
        }
 
        public TimingConfiguration(string schema)
        {
            ToTable(schema + ".Timings");
            HasKey(x => x.TimingId);

            Property(x => x.TimingId).HasColumnName("TimingID").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Time).HasColumnName("Time").IsRequired().HasColumnType("datetime");
            Property(x => x.RunId).HasColumnName("RunID").IsOptional().HasColumnType("uniqueidentifier");
            Property(x => x.TimingTypeId).HasColumnName("TimingTypeID").IsOptional().HasColumnType("uniqueidentifier");

            // Foreign keys
            HasOptional(a => a.Run).WithMany(b => b.Timings).HasForeignKey(c => c.RunId); // FK__Timings__RunID__1E3A7A34
            HasOptional(a => a.TimingType).WithMany(b => b.Timings).HasForeignKey(c => c.TimingTypeId); // FK__Timings__TimingT__1F2E9E6D
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>