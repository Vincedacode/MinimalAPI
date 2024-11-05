using System.ComponentModel.DataAnnotations;

class RegisterChatClass
{
    [Required]
    public string? UserName { get; set; }
    [Required]
    public int SenderId { get; set; }
    [Required]
    public string? Receiver_Name { get; set; }
    [Required]
    public int ReceiverId { get; set; }
    [Required]
    public int ChatId { get; set; }
    [Required]
    public string? Message { get; set; }

    public DateTime DateandTIme { get; set; }











}