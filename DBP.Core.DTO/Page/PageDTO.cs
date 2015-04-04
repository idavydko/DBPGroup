using System;

namespace DBP.Core.DTO.Page
{
    public class PageDTO : BaseCoreDTO
    {
        public int PageId { get; set; }

        public int TemplateId { get; set; }

        public string Name { get; set; }

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

        public DateTimeOffset CreatedBy { get; set; }

        public PageDTO(Guid? id)
            : base (id)
        {
        }
    }
}
