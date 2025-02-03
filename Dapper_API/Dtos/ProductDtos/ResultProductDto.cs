using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dapper_API.Dtos.ProductDtos;

public class ResultProductDto
{
    public int ProductId { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string? Title { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "varchar(250)")]
    public string? CoverImage { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string? City { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string? District { get; set; }
    [Column(TypeName = "varchar(500)")]
    public string? Address { get; set; }
    [Column(TypeName = "varchar(8000)")]
    public string? Description { get; set; }
    public int ProductCategory { get; set; }
    public int EmployeeId { get; set; }
}
