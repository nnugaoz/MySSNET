using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySmartStore.Web.Framework.Modelling
{
    public abstract partial class ModelBase
    {

    }

    public abstract partial class EntityModelBase:ModelBase
    {

        public virtual int Id { get; set; }
    }
}
