using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace PostServiceWebApplication.Models;

public partial class Client
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Ім'я")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Прізвище")]
    public string Surname { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Номер телефону")]
    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public string PhoneNumber { get; set; } = null!;

    public virtual ICollection<Parcel> ParcelClientFroms { get; } = new List<Parcel>();

    public virtual ICollection<Parcel> ParcelClientTos { get; } = new List<Parcel>();
}
