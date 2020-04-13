﻿using System.Collections.Generic;

namespace Nomad.Utility
{

    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "(" + X.ToString() + ", " + Y.ToString() + ")";
        }

        public EType Type()
        {
            // Scalar
            if (X == 1 && Y == 1)
            {
                return EType.Scalar;
            }

            // Vector
            if (X == 1 && Y != 1)
            {
                return EType.Vector;
            }

            // Vector.T
            else if (X != 1 && Y == 1)
            {
                return EType.VectorTransposed;
            }

            // Square Matrix
            if (X != 1 && Y != 1 && X == Y)
            {
                return EType.SquareMatrix;
            }

            // Matrix
            return EType.Matrix;
        }
    }
}
