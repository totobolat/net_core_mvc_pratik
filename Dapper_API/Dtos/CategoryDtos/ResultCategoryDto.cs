using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dapper_API.Dtos.CategoryDtos;

public class ResultCategoryDto
{
    public int CategoryId { get; set;}
    [Column(TypeName = "varchar(50)")]
    public string? CategoryName { get; set;}
    public bool CategoryStatus { get; set; }
}
