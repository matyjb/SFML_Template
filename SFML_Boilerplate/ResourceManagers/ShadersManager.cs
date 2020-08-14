using SFML.Graphics;
using System.Collections.Generic;

namespace SFML_Boilerplate.ResourceManagers
{
    class ShadersManager : ResourceManager<ShaderName, Shader>
    {
        public ShadersManager()
        {
            resources = new Dictionary<ShaderName, Shader>();
        }
        public void AddResource(ShaderName name, string vertexFilePath, string geometryShaderFilePath, string fragmentFilePath)
        {
            Shader f = new Shader(vertexFilePath, geometryShaderFilePath, fragmentFilePath);
            resources.Add(name, f);
        }
    }
}