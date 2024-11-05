using System.ComponentModel.DataAnnotations;

class RegisterGroupClass
{
    public int GroupId { get; set; }
    [Required]
    public string? GroupOwner { get; set; }
    [Required]
    public string? GroupName { get; set; }

    public FileOptions GroupPicture { get; set; }

    public List<string>? AdminList { get; set; }

    public List<int>? MembersId { get; set; }

    public DateTime DateAndTimeCreated { get; set; }
















}