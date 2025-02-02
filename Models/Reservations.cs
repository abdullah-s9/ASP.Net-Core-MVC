﻿using System.ComponentModel.DataAnnotations;

namespace SaudiGuide.Models
{
    public class Reservations
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الرجاء إدخال اسمك")]
        [StringLength(100, ErrorMessage = "الاسم يجب ألا يتجاوز 100 حرف")]
        public string Name { get; set; }

        [Required(ErrorMessage = "الرجاء إدخال رقم جوالك")]
        [Phone(ErrorMessage = "رقم الجوال غير صحيح")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "الرجاء تحديد تاريخ الحجز")]
        [DataType(DataType.Date, ErrorMessage = "تاريخ الحجز غير صحيح")]
        [FutureDate(ErrorMessage = "التاريخ يجب أن يكون في المستقبل")] 

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "الرجاء إدخال عدد الاشخاص")]
        public int Count { get; set; }
        [Required(ErrorMessage = "الرجاء إدخال نوع الرحلة")]

        public string Type { get; set; }




    }
}
