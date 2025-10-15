using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnackGame
{
    class EndScene :BasedScene
    {
        public EndScene()
        {
            strTitle = "游戏结束";
            strOne = "重新开始";
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