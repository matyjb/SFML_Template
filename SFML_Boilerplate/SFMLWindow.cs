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
                Drawing();
                Display();
            }
        }

        private void Update()
        {

        }

        private void Drawing()
        {
            if(drawDebug)
            {
                string debugText = string.Format("fps: {0}", string.Format("{0:0.00}", 1f / deltaTime.AsSeconds()));
                Text t = new Text(debugText, resources.Get(FontName.Arial))
                {
                    CharacterSize = 14,
                    FillColor = Color.White,
                    OutlineColor = Color.Black,
                    OutlineThickness = 1,
                    Style = Text.Styles.Bold,
                };
                Draw(t);
            }
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
