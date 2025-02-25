﻿using System;
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

            if (state.IsKeyDown(Keys.A))
            {
                playerSprite.spritePosition = new Vector2(playerSprite.spritePosition.X - 10, playerSprite.spritePosition.Y);
            }

            if (state.IsKeyDown(Keys.D))
            {
                playerSprite.spritePosition = new Vector2(playerSprite.spritePosition.X + 10, playerSprite.spritePosition.Y);
            }

            if (state.IsKeyDown(Keys.W))
            {
                playerSprite.spritePosition = new Vector2(playerSprite.spritePosition.X, playerSprite.spritePosition.Y - 10);
            }

            if (state.IsKeyDown(Keys.S))
            {
                playerSprite.spritePosition = new Vector2(playerSprite.spritePosition.X, playerSprite.spritePosition.Y + 10);
            }
        }

        
    }
}
