namespace WebApplication1.Models;

public class Application
{
    public int ApplicationID { get; set; } //getter and setter automatically built
    public string Category { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }
    public bool? Edited { get; set; }
    public string? LendTo { get; set; }
    public string? Notes { get; set; }
}