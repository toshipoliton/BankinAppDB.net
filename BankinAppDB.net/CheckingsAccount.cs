namespace BankinAppDB.net
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckingsAccount")]
    public partial class CheckingsAccount
    {
        public int ID { get; set; }

        public int PersonId { get; set; }

        public Guid AccountId { get; set; }

        public decimal Amount { get; set; }

        public virtual Person Person { get; set; }
    }
}
