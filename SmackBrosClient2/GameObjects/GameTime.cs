﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmackBrosClient2.GameObjects
{
    public class GameTime
    {
        private TimeSpan internalTime;
        public TimeSpan ElapsedGameTime
        {
            get { return internalTime; }
            set { internalTime = value; }
        }
    }
}
