using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Models;

[Table("Department")]
public partial class Department
{
    [Key]
    public int DepartmentId { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    public int? EstablishedYear { get; set; }

    [StringLength(200)]
    public string? Address { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
