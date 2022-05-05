﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public Point2D (int x, int y)
        {
            X = _x;
            Y = _y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }      
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }

    }
}
