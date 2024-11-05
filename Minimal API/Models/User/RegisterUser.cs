using System.ComponentModel.DataAnnotations;

class Userregisterclass
{
    public int Userid { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string? EmailAddress { get; set; }
    [Phone(ErrorMessage = "Please enter a valid phone number format")]
    public string? PhoneNumber { get; set; }

    public int Pin { get; set; }
    [Required]
    [MinLength(8, ErrorMessage = "Password entered is too short")]
    [MaxLength(32, ErrorMessage = "Maximum characters exceeded")]
    public string? Password { get; set; }
    [Required]
    public string? Language { get; set; }

    public FileAccess Picture { get; set; }

    public bool isPaidUser { get; set; }

    public DateTime Datejoined { get; set; }






















}