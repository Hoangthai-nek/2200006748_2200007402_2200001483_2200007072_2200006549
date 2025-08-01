using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Models;

[Table("Student")]
public partial class Student
{
    [Key]
    public int StudentId { get; set; }

    [StringLength(100)]
    public string FullName { get; set; } = null!;

    public bool? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    [StringLength(200)]
    public string? PhotoPath { get; set; }

    [StringLength(100)]
    public string? Hometown { get; set; }

    [StringLength(50)]
    public string? StudentSchoolYear { get; set; }

    public int? DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Students")]
    public virtual Department? Department { get; set; }
}
