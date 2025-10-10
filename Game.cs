using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnackGame
{
    public class Game
    {
        public int w = 80;
        public int h = 20;

        public static ISceneChange nowScene;

        public void Start()
        {
            while (true)
            {
                if (nowScene != null)
                {
                    nowScene.Update();
                }
            }
        }

        public void GameSceneChange(E_Scene Scene){
            
            Console.Clear();
            
            switch (Scene)
            {
                case E_Scene.game:
                    nowScene = new GameScene();
                    break;
                case E_Scene.start:
                    nowScene = new BeginScene();
                    break;
                case E_Scene.end:
                    nowScene = new EndScene();
                    break;

            }
        }
    }
}