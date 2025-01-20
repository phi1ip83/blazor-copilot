using System;
using System.ComponentModel.DataAnnotations;

public class Event
{

    [Required]
    public string Name { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public string Details { get; set; }
    // ...existing code...
}
