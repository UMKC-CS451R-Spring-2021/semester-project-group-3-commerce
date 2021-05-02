using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Commerce_WebApp.Models
{
  public class Notification
  {
    public int Id { get; set; }
    public int? Transaction_Id { get; set; }
    public int Notification_Rule { get; set; }
    public string Message { get; set; }
    /*[DisplayFormat(DataFormatString = "{0:g}")]
    public DateTime TimeStamp { get; set; }*/
    }
}
