﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication1;

public class Club
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }

    [ForeignKey("Address")]
    public int? AddressId { get; set; }
    public Address? Address { get; set; }

    // [ForeignKey("Category")]
    public ClubCategory? ClubCategory { get; set; }
    // [ForeignKey("RaceCategory")]
    public RaceCategory? RaceCategory { get; set; }

    [ForeignKey("AppUser")]
    public int AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

}
