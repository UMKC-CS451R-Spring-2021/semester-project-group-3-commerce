using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAdministration.Models
{
  public class Financial_Transaction
  {
    public int Id { get; set; }
    public int Account_Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Balance_After { get; set; }
  }
}
