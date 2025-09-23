using System;

namespace Chpt18DictHash_TablesAndSets;

public class Pointer3DEqualityComparer : IEqualityComparer<Point3D>
{
    public bool Equals(Point3D point1, Point3D point2)
    {
        if (point1 == point2)
            return true;

        if (point1 == null || point2 == null)
            return false;

        if (!point1.X.Equals(point2.X))
            return false;

        if (!point1.Y.Equals(point2.Y))
            return false;

        if (!point1.Z.Equals(point2.Z))
            return false;

        return true;
    }

    public int GetHashCode(Point3D obj)
    {
        Point3D point = obj as Point3D;
        if (point == null)
        {
            return 0;
        }

        int prime = 83;
        int result = 1;
        unchecked
        {
            result = result * prime + point.X.GetHashCode();
            result = result * prime + point.Y.GetHashCode();
            result = result * prime + point.Z.GetHashCode();
        }
        return result;
    }
}
