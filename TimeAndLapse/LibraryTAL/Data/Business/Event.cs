using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTAL.Data.Designer
{
    public partial class Event
    {
        partial void InitializePartial()
        {
            EventId = new Guid();
        }
    }
}
