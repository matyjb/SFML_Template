using SFML.Graphics;
using System.Collections.Generic;

namespace SFML_Boilerplate.ResourceManagers
{
    class FontsManager : ResourceManager<FontName, Font>
    {
        public FontsManager()
        {
            resources = new Dictionary<FontName, Font>();
        }
        public void AddResource(FontName name,string filePath)
        {
            Font f = new Font(filePath);
            resources.Add(name, f);
        }
    }
}