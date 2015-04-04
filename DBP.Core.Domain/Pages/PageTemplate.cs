
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBP.Core.Domain.Pages
{
    public class PageTemplate
    {
        [Key]
        public int TemplateId { get; set; }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(250)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

    }
}
