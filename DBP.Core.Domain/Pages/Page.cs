using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBP.Core.Domain.Pages
{
    public class Page
    {
        [Key]
        public int PageId { get; set; }

        public Guid Id { get; set; }

        public int TemplateId { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }

        public int? ParentPageId { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsPublished { get; set; }

        public bool IsDeleted { get; set; }

        public int ScopeId { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public DateTimeOffset? CreatedOn { get; set; }

        public DateTimeOffset? ModifiedOn { get; set; }

        [ForeignKey("TemplateId")]
        public virtual PageTemplate PageTemplate { get; set; }
    }
}
