using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context.Contacts
{
   public abstract class BaseAuditEntity
    {
        /// <summary>
        /// идентификатор
        /// </summary>>
        public Guid Id { get; set; }

        /// <summary>
        /// когда создан 
        /// </summary>>

        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// кем создан 
        /// </summary>>

        public string CreatedBy { get; set; } = string.Empty;


        /// <summary>
        /// когда изменен  
        /// </summary>>
        
        public DateTimeOffset UpDatedAt { get; set; }

        /// <summary>
        /// кем изменен 
        /// </summary>>

        public string UpDatedBy { get; set; } = String.Empty;
        
        /// <summary>
        /// Дата удаления 
        /// </summary>>
        
        public DateTimeOffset? DatedAt { get; set; }
    }
}
