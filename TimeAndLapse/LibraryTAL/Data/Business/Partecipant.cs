using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTAL.Data.Designer
{
    public partial class Partecipant
    {
        partial void InitializePartial()
        {
            PartecipantId = new Guid();
        }
    }
}
