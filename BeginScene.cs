using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnackGame
{
    class BeginScene :BasedScene
    {
        public BeginScene()
        {
            strTitle = "贪吃蛇";
            strOne = "开始游戏";
        }

        public override void SceneChange()
        {
            if(nowSelIndex == 0)
            {
                Game.GameSceneChange(E_Scene.game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}