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
    
    public partial class Сотрудники
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудники()
        {
            this.Научные_работы = new HashSet<Научные_работы>();
            this.Отделы = new HashSet<Отделы>();
        }
    
        public int ID_сотрудника { get; set; }
        public string Фамилия_сотрудника { get; set; }
        public string Имя_сотрудника { get; set; }
        public string Отчество_сотрудника { get; set; }
        public Nullable<System.DateTime> Дата_рождения { get; set; }
        public string Отдел { get; set; }
        public string Должность { get; set; }
        public decimal Зарплата { get; set; }
        public string Номер_телефона { get; set; }
        public string e_mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Научные_работы> Научные_работы { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Отделы> Отделы { get; set; }
        public virtual Отделы Отделы1 { get; set; }
    }
}
