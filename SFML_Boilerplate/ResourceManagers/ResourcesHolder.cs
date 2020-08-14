using SFML.Audio;
using SFML.Graphics;

namespace SFML_Boilerplate.ResourceManagers
{
    class ResourcesHolder
    {
        TexturesManager textures;
        FontsManager fonts;
        SoundsManager sounds;
        ShadersManager shaders;
        MusicManager music;

        public ResourcesHolder()
        {
            textures = new TexturesManager();
            fonts = new FontsManager();
            sounds = new SoundsManager();
            shaders = new ShadersManager();
            music = new MusicManager();

            //Add all resources here:
            Add(FontName.Arial, "Resources/Fonts/arial.ttf");

        }

        public Texture Get(TextureName name)
        {
            return textures.GetResource(name);
        }
        public SoundBuffer Get(SoundName name)
        {
            return sounds.GetResource(name);
        }
        public Font Get(FontName name)
        {
            return fonts.GetResource(name);
        }
        public Shader Get(ShaderName name)
        {
            return shaders.GetResource(name);
        }
        public Music Get(MusicName name)
        {
            return music.GetResource(name);
        }

        public void Add(TextureName name, string filePath)
        {
            textures.AddResource(name, filePath);
        }
        public void Add(SoundName name, string filePath)
        {
            sounds.AddResource(name, filePath);
        }
        public void Add(FontName name, string filePath)
        {
            fonts.AddResource(name, filePath);
        }
        public void Add(ShaderName name, string vertexFilePath, string geometryShaderFilePath, string fragmentFilePath)
        {
            shaders.AddResource(name, vertexFilePath, geometryShaderFilePath, fragmentFilePath);
        }
        public void Add(MusicName name, string filePath)
        {
            music.AddResource(name, filePath);
        }
    }
}
