using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class ProgrammingLanguageModel
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }
    }
}
