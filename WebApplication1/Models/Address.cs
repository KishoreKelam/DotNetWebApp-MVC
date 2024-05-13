using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication1;

public class Address
{
    [Key]
    string? Id { get; set; }
    string? Street {get; set;}
    string? City {get; set;}
    string? State {get; set;}
    string? ZipCode {get; set;}

}
