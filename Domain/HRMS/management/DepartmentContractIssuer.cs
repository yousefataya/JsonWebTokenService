using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS.management
{
    [Table("DepartmentContractIssuer")]
    public class DepartmentContractIssuer : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("IssuerName")]
        public string IssuerName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("IssuePlace")]
        public string IssuePlace { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        /* employee audit reference key */

        /* employee department head reference key */

        /* department reference key */

        /* contract info reference key */

    }
}