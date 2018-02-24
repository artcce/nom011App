using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011App.GenericViews
{

    public class CatalogMenuItem
    {
        public CatalogMenuItem()
        {
            TargetType = typeof(CatalogDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}