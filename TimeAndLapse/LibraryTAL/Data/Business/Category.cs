using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTAL.Data.Designer
{
    public partial class Category
    {
        partial void InitializePartial()
        {
            CategoryId = new Guid();
        }
    }
}
