//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBKursovaya.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Отделы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Отделы()
        {
            this.Оборудование = new HashSet<Оборудование>();
            this.Сотрудники1 = new HashSet<Сотрудники>();
        }
    
        public string Название_подразделения { get; set; }
        public Nullable<bool> Наличие_какой_нибудь_фигни { get; set; }
        public string Какая_нибудь_еще_штука { get; set; }
        public Nullable<int> ID_руководителя { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Оборудование> Оборудование { get; set; }
        public virtual Сотрудники Сотрудники { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудники> Сотрудники1 { get; set; }
    }
}
