using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>(); // navigation property. This is simply a property on Criminal class that includes a reference to Job class.
      //this.Jobs = this.JoinEntities
    }

    public int EngineerId { get; set; }//two columns in our Criminal table
    public string Name { get; set; }//
    public string Details { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }
  }
}