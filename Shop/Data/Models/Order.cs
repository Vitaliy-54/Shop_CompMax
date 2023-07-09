using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        //данное поле никогда не будет видно на страничке
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не более 25 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не более 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адреса не более 35 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина номера не более 20 знаков")]
        public string phone { get; set; }

        [Display(Name = "Введите Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина email не более 25 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]//поле не будет отражено даже в исходном коде
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        //описание всех товаров, которые приобрели    }
    }
}