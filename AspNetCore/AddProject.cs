using System.Data;
namespace AspNetCore
{
  public class AddProject
  {
  public int Id { get; set; } 
  public string? Project { get; set; }
  public string? Coordinator { get; set; }
  public DateOnly Start { get; set; }
   public DateOnly End { get; set; }
  
} 

  }
