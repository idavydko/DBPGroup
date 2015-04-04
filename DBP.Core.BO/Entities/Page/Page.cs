using System;

namespace DBP.Core.BO.Entities.Page
{

    public class Page : BaseEntity
    {
        /// <summary>
        /// Gets or sets page identifier
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets page unique identifier
        /// </summary>
        public Guid Id { get; set; }

        public int TemplateId { get; set; }

        /// <summary>
        /// Gets or sets page name which is unique
        /// </summary>
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? ParentPageId { get; set; }

        /// <summary>
        /// Gets or sets is page disabled by user
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets is page published
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Gets or sets is page deleted by user
        /// </summary>
        public bool IsDeleted { get; set; }

        public int ScopeId { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public DateTimeOffset CreatedBy { get; set; }

        public DateTimeOffset ModifiedBy { get; set; }
    }
}
