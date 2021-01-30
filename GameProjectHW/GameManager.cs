using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHW
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name+" Oyunu Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "Oyunu Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + "Oyunu Güncellendi");
        }
    }
}
