using SFML.Audio;
using System.Collections.Generic;

namespace SFML_Boilerplate.ResourceManagers
{
    class MusicManager : ResourceManager<MusicName, Music>
    {
        public MusicManager()
        {
            resources = new Dictionary<MusicName, Music>();
        }
        public void AddResource(MusicName name,string filePath)
        {
            Music f = new Music(filePath);
            resources.Add(name, f);
        }
    }
}