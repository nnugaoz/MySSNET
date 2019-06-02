using MySmartStore.Web.Framework.Modelling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MySmartStore.Web.Framework.Localization
{
    public class SmartResourceDisplayName:System.ComponentModel.DisplayNameAttribute,IModelAttribute
    {
        private readonly string _callerPropertyName;

        public SmartResourceDisplayName(string resourceKey, [CallerMemberName] string propertyName = null)
    : base(resourceKey)
        {
            ResourceKey = resourceKey;
            _callerPropertyName = propertyName;
        }

        public string ResourceKey { get; set; }

        public string Name
        {
            get { return "SmartResourceDisplayName"; }
        }
    }
}
