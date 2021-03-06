﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Catan.Interfaces
{
    public interface IDrawable
    {
        Rectangle Rectangle { get; }

        Texture2D Texture { get; }

        void Draw(SpriteBatch spriteBatch);
    }
}
