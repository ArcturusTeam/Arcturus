using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsaacRemix
{
    class Ressource
    {
        public static Texture2D player;


        public static void LoadContent(ContentManager Content)
        {
            player = Content.Load<Texture2D>("Player");
        }

    }
}
