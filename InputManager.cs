using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cmeera_test
{
    class InputManager
    {
        KeyboardState state;

        public void CheckKeys(Player playerSprite)
        {
            state = Keyboard.GetState();

            playerSprite.goingLeft = false;
            playerSprite.goingRight = false;
            playerSprite.goingUp = false;
            playerSprite.goingDown = false;

            if (state.IsKeyDown(Keys.A))
            {
                playerSprite.spritePosition = new Vector2(playerSprite.spritePosition.X + 1, playerSprite.spritePosition.Y);
            }

            if (state.IsKeyDown(Keys.D))
            {
                
            }

            if (state.IsKeyDown(Keys.W))
            {
                
            }

            if (state.IsKeyDown(Keys.S))
            {
                
            }
        }

        
    }
}
