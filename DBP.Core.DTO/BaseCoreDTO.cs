using System;

namespace DBP.Core.DTO
{
    public class BaseCoreDTO
    {
        public Guid Id { get; private set; }

        public BaseCoreDTO(Guid? id)
        {
            Id = id.HasValue && id.Value != Guid.Empty ? id.Value : Guid.NewGuid();
        }
    }
}
