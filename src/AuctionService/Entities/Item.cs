using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("items")]
public class Item
{
    public Guid Id { get; set; }
    public int? MakeId { get; set; } = 0;
    public string Make { get; set; }
    public long? ModelId { get; set; } = 0;
    public string Model { get; set; }
    public long? EngineId { get; set; } = 0;
    public string Engine { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }

    public Guid AuctionId { get; set; } 
    public Auction Auction{ get; set; }

}
