﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Ring
    {
        private double _innerRadius;

        private double _outerRadius;

        public Ring (Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        public Point2D Center { get; set; }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius), value);
                Validator.AssertValueInRange(nameof(OuterRadius), value, _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius), value);
                Validator.AssertValueInRange(nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}
