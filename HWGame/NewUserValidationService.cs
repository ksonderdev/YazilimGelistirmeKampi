using System;
using System.Collections.Generic;
using System.Text;

namespace HWGame
{
    class NewUserValidationService : IPlayerValidService
    {
        public bool Valid(Player player)
        {
            return true;
        }
    }
}
