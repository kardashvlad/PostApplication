using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostServiceWebApplication.Models;

public partial class ParcelType
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Довжина")]
    [Range(1, 1000,
            ErrorMessage = "Довжина повинна бути від 1 до 1000")]
    public long Length { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Ширина")]
    [Range(1, 1000,
            ErrorMessage = "Ширина повинна бути від 1 до 1000")]
    public long Width { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Висота")]
    [Range(1, 1000,
            ErrorMessage = "Висота повинна бути від 1 до 1000")]
    public long Height { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Вартість")]
    [Range(1, 1000000,
            ErrorMessage = "Ціна повинна бути від 1 до 1000000")]
    public long ShipmentCost { get; set; }

    public virtual ICollection<Parcel> Parcels { get; } = new List<Parcel>();
}
