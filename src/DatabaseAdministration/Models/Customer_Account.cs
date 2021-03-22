using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAdministration.Models
{
  [Keyless]
  public class Customer_Account
  {
    public string Customer_Id { get; set; }
    public int Account_Id { get; set; }
  }
}
