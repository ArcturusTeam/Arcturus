using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsaacRemix
{
    class Player
    {

        //-------------------------------------------------------------------------------------------------VARIABLES

        int speed;
        Vector2 position;

        Texture2D texture;
        Rectangle rectangle;

        //-------------------------------------------------------------------------------------------------CONSTRUCTEUR

        public Player()
        {
            speed = 15;
            texture = Ressource.player;
            rectangle = new Rectangle(0, 0, 50, 50);

            position = new Vector2(100, 100);
        }


        //-------------------------------------------------------------------------------------------------METHODE





        //-------------------------------------------------------------------------------------------------UPDATE
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
            
            //GAUCHE
            if(keyboard.IsKeyDown(Keys.Q))
            {
                position.X -= speed;
            }

            //DROITE
            if (keyboard.IsKeyDown(Keys.D))
            {
                position.X += speed;
            }

            //HAUT
            if (keyboard.IsKeyDown(Keys.Z))
            {
                position.Y -= speed;
            }

            //BAS
            if (keyboard.IsKeyDown(Keys.S))
            {
                position.Y += speed;
            }

        }


        //-------------------------------------------------------------------------------------------------DRAW
        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(texture, position, rectangle, Color.White, 0f, new Vector2(texture.Width / 2, texture.Height / 2), 1, SpriteEffects.None, 1);

        }


    }
}
