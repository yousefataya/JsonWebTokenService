using AuditingDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCoreArchitecture.Domain.HRMS
{
    [Table("EmployeeDiscountInfo")]
    public class EmployeeDiscount : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ServiceName")]
        public string ServiceName { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("FromDate")]
        public DateTime FromDate { get; set; }

        [Column("ToDate")]
        public DateTime ToDate { get; set; }

        [Column("AmountByMonth")]
        public int AmountByMonth { get; set; }

        [Column("Percentage")]
        public string Percentage { get; set; }

        [Column("IsExpired")]
        public bool IsExpired { get; set; }

        [Column("IsApproved")]
        public bool IsApproved { get; set; }

        [Column("ExpiredDate")]
        public DateTime ExpiredDate { get; set; }

        [Column("ApprovedDate")]
        public DateTime ApprovedDate { get; set; }

        [Column("ServiceDescription")]
        public string ServiceDescription { get; set; }

        /* employee issuer reference key */

        /* desired employee reference key */

        /* department reference key */

        /* organizarion reference key */

        [Column("DiscountCatogry")]
        public string DiscountCatogry { get; set; }

        /* discount lookup reference key */


    }
}
