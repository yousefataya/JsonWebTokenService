using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.Accounting
{
    [Table("AccountingTransactions")]
    public class AccountingTransactions : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }


    }
}
