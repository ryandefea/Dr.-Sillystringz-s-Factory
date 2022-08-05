using System.Collections.Generic;//includes ICollection, HashSet

namespace Factory.Models
{
  public class Machine
  {
    public machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Description { get; set; }
    public virtual ICollection<EngineerMachine> Engineer { get; set; } //ICollection includes built in methods that help us manipulate our data. Entity needs it.
    // Criminals named after this.Criminals
  }
}