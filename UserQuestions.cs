//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QA_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserQuestions
    {
        public int Id { get; set; }
        public int UserSystemsId { get; set; }
        public string QuestionBody { get; set; }
        public Nullable<int> DemandDescriptionId { get; set; }
    
        public virtual UserSystems UserSystem { get; set; }
        public virtual DemandDescription DemandDescription { get; set; }
    }
}
