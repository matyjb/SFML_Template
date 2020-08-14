using System.Collections.Generic;

namespace SFML_Boilerplate.ResourceManagers
{
    abstract class ResourceManager<TEnum,TResource>
    {
        protected Dictionary<TEnum, TResource> resources;
        
        public TResource GetResource(TEnum name)
        {
            return resources[name];
        }
    }
}
