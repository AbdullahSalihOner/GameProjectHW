using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHW
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
