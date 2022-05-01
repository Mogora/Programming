using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    class Point2D
    {
        private float _x;

        private float _y;

        public Point2D ()
        {
            X = _x;
            Y = _y;
        }

        public float X
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

        public float Y
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
