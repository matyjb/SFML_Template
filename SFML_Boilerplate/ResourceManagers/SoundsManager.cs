using SFML.Audio;
using System.Collections.Generic;

namespace SFML_Boilerplate.ResourceManagers
{
    class SoundsManager : ResourceManager<SoundName, SoundBuffer>
    {
        public SoundsManager()
        {
            resources = new Dictionary<SoundName, SoundBuffer>();
        }
        public void AddResource(SoundName name, string filePath)
        {
            SoundBuffer f = new SoundBuffer(filePath);
            resources.Add(name, f);
        }
    }
}