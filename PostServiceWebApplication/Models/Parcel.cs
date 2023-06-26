using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostServiceWebApplication.Models;

public partial class Parcel
{
    public long Id { get; set; }

    [Display(Name = "Відправник")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public long ClientFromId { get; set; }

    [Display(Name = "Отримувач")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public long ClientToId { get; set; }

    [Display(Name = "Тип (розмір коробки)")]
    public long? TypeId { get; set; }

    [Display(Name = "Статус")]
    public long? StatusId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [Display(Name = "Хрупкість")]
    public bool IsFragile { get; set; }
    public bool IsDeleted { get; set; } = false;
    public virtual Client ClientFrom { get; set; } = null!;

    [Display(Name = "Отримувач")]
    public virtual Client ClientTo { get; set; } = null!;
    public virtual ICollection<ParcelHistory> ParcelHistories { get; } = new List<ParcelHistory>();

    [Display(Name = "Статус")]
    public virtual Status? Status { get; set; } = null!;

    [Display(Name = "Тип")]
    public virtual ParcelType? Type { get; set; } = null!;
}
