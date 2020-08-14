using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML_Boilerplate.ResourceManagers;

namespace SFML_Boilerplate
{
    class SFMLWindow : RenderWindow
    {
        bool drawDebug = false;
        Time deltaTime;
        ResourcesHolder resources;

        public SFMLWindow(VideoMode vmode, string title) : base(vmode, title) 
        {
            resources = new ResourcesHolder();
            Closed += SFMLWindow_Closed;
            KeyPressed += SFMLWindow_KeyPressed;
        }

        private void Init()
        {
            SetFramerateLimit(60);
        }

        private void MainLoop()
        {
            Clock clock = new Clock();
            while (IsOpen)
            {
                Clear();
                DispatchEvents();
                deltaTime = clock.Restart();
                Update();
                Draw();
                Display();
            }
        }

        private void Update()
        {

        }

        private void Draw()
        {

        }

        private void SFMLWindow_KeyPressed(object sender, KeyEventArgs e)
        {
            if(e.Code == Keyboard.Key.F3)
            {
                drawDebug = !drawDebug;
            }
        }

        private void SFMLWindow_Closed(object sender, System.EventArgs e)
        {
            Close();
        }

        public void Run()
        {
            Init();
            MainLoop();
        }
    }
}
