using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>(); // navigation property. This is simply a property on Criminal class that includes a reference to Job class.
      //this.Jobs = this.JoinEntities
    }

    public int EngineerId { get; set; }//three columns in our Engineer table
    public string Name { get; set; }//
    public string Details { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}