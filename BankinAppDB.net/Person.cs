namespace BankinAppDB.net
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            CheckingsAccounts = new HashSet<CheckingsAccount>();
            SavingsAccounts = new HashSet<SavingsAccount>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(350)]
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public String Role { get; set; }

        public Address HomeAddress { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Salary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckingsAccount> CheckingsAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SavingsAccount> SavingsAccounts { get; set; }
    }
}
