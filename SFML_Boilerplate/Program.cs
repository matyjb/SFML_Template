using SFML.Window;

namespace SFML_Boilerplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new SFMLWindow(new VideoMode(800, 600), "sfml_boilerplate");
            window.Run();
        }
    }
}
