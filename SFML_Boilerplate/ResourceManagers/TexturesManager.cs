using SFML.Graphics;
using System.Collections.Generic;

namespace SFML_Boilerplate.ResourceManagers
{
    class TexturesManager : ResourceManager<TextureName,Texture>
    {
        public TexturesManager()
        {
            resources = new Dictionary<TextureName, Texture>();
        }
        public void AddResource(TextureName name, string filePath)
        {
            Texture f = new Texture(filePath);
            resources.Add(name, f);
        }
    }
}