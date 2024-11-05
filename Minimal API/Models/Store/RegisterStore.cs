using System.ComponentModel.DataAnnotations;

class RegisterStoreClass
{
    [Required]
    public string? StoreName { get; set; }
    [Required]
    public int StoreId { get; set; }


    [Required]

    public string? ItemName { get; set; }

    public string? Itemtype { get; set; }

    public int Categoryid { get; set; }
    [Required]
    public string? MakerName { get; set; }
    [Required]
    public string? Model { get; set; }

    public int ModelNumber { get; set; }
    [Required]
    public int Price { get; set; }

    public List<string>? Color { get; set; }

    public bool IsAvailable { get; set; }

    public int QuantityLeft { get; set; }

    public DateTime DateCreated { get; set; }



}




