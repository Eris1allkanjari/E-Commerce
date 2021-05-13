using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MisterRobotoArigato.Models {
    public class CardInfo {
        [Required]
        public string CardNumber;
        [Required]
        public string ExpirationDate;
        [Required]
        public string CardCode;
    }
}
