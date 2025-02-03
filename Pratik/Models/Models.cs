using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pratik.Models;

public class Category
{
    public int CategoryId { get; set;}
    [Column(TypeName = "varchar(50)")]
    public string? CategoryName { get; set;}
    public bool CategoryStatus { get; set; }
}
 public class Product {

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

 public class ProductDetails {
   [Key]
    public int ProductDetailId { get; set;}
    public int ProductSize  { get; set; }
    public int BedroomCount { get; set; }
    public int BathCount { get; set; }
    public int RoomCount { get; set; }
    public int GarageSize { get; set; }
    [Column(TypeName = "char(4)")]
    public char BuildYear { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "varchar(500)")]
    public string? Location { get; set; }
    [Column(TypeName = "varchar(1000)")]
    public string? VideoUrl { get; set; }
    public int ProductId { get; set; }
 }

public class Client {
    public int ClientId { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string? Name { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string? Title { get; set; }
    [Column(TypeName = "varchar(2000)")]
    public string? Comment { get; set; }
   
}

public class Employee {
   public int EmployeeId { get; set;}
   [Column(TypeName = "varchar(100)")]
   public string? Name { get; set;}
   [Column(TypeName = "varchar(100)")]
   public string? Title { get; set; }
   [Column(TypeName = "varchar(100)")]
   public string? Mail { get; set; }
   [Column(TypeName = "varchar(100)")]
   public string? Phone { get; set; }
   [Column(TypeName = "varchar(1000)")]
   public string? ImageUrl { get; set; }
   public bool EmployeeStatus { get; set; }
}