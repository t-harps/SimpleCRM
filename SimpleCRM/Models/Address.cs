using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCRM.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        [Required]
        [StringLength(20)]
        public string NameOrNum { get; set; }
        [Required]
        [StringLength(20)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [RegularExpression(@"^([A-PR-UWYZ]([0-9]{1,2}|([A-HK-Y][0-9]|[A-HK-Y][0-9]([0-9]|[ABEHMNPRV-Y]))|[0-9][A-HJKS-UW])\ [0-9][ABD-HJLNP-UW-Z]{2}|(GIR\ 0AA)|(SAN\ TA1)|(BFPO\ (C\/O\ )?[0-9]{1,4})|((ASCN|BBND|[BFS]IQQ|PCRN|STHL|TDCU|TKCA)\ 1ZZ))$")]
        public string Postcode { get; set; }
        [Required]
        public string County { get; set; }
        [Required]
        public string Country { get; set; }

        public virtual Customer Customer { get; set; }
    }
}