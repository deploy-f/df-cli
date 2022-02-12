namespace Deployf.Cli.Models;

public class ApplicationSummaryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedTS { get; set; }
    public bool IsRunned { get; set; }
    public bool NeedRestart { get; set; }
    public float LimitCPU { get; set; }
    public float LimitRAM { get; set; }
}