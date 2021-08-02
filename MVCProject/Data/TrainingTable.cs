using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Data
{
    public class TrainingTable
    {

        [Key]
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TRAINING_NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public bool  STATUS { get; set; }
    }
}
