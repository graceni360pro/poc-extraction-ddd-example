namespace Extraction.DDD.Example.Domain;

/// <summary>
/// Interval object for geometric operations
/// </summary>
public struct Interval
{
    /// <summary>
    /// Left
    /// </summary>
    public int Left { get; set; } = 0;
    /// <summary>
    /// Right
    /// </summary>
    public int Right { get; set; } = 0;
    /// <summary>
    /// Empty Interval
    /// </summary>
    public Interval() { }
    /// <summary>
    /// Interval Constructor
    /// </summary>
    public Interval(int left, int right)
    {
        Left = left;
        Right = right;
    }
    /// <summary>
    /// Center point
    /// </summary>
    public readonly int Center => (Left + Right) / 2;
    /// <summary>
    /// Validation
    /// </summary>
    public readonly bool IsEmpty => Left >= Right;
    /// <summary>
    /// Check point visibility
    /// </summary>
    public readonly bool HasPoint(int x) => x >= Left && x < Right;
    /// <summary>
    /// Overlap Check
    /// </summary>
    public static bool AreOverlapped(int l1, int r1, int l2, int r2, int MinIntersection = 0)
    {
        return Math.Min(r1, r2) - Math.Max(l1, l2) > MinIntersection;
    }
    /// <summary>
    /// Strong Overlap: both centers of the intervals are covered by the other interval
    /// </summary>
    public static bool AreWellOverlapped(Interval ivl1, Interval ivl2)
    {
        return ivl2.Center >= ivl1.Left && ivl2.Center <= ivl1.Right && 
               ivl1.Center >= ivl2.Left && ivl1.Center <= ivl2.Right;
    }
    /// <summary>
    /// AreWellOverlapped with integer values
    /// </summary>
    public static bool AreWellOverlapped(int l1, int r1, int l2, int r2)
    {
        return AreWellOverlapped(new Interval(l1, r1), new Interval(l2, r2));
    }
    /// <summary>
    /// Check if one interval is inside another with integer values
    /// </summary>
    public static bool IsInsideOther(int l1, int r1, int l2, int r2)
    {
            return (l1 >= l2 && r1 <= r2) || (l2 >= l1 && r2 <= r1);
    }
}
/// <summary>
/// Rect object for geometric operations
/// </summary>
public struct Rect
{
    /// <summary>
    /// Left
    /// </summary>
    public int Left { get; set; }
    /// <summary>
    /// Right
    /// </summary>
    public int Right { get; set; }
    /// <summary>
    /// Top
    /// </summary>
    public int Top { get; set; }
    /// <summary>
    /// Bottom
    /// </summary>
    public int Bottom { get; set; }
    /// <summary>
    /// Default/Empty Rect
    /// </summary>
    public Rect()
    {
        Left = Right = Top = Bottom = 0;
    }
    /// <summary>
    /// Rect Constructor
    /// </summary>
    public Rect(int left, int top, int right, int bottom)
    {
        Set(left, top, right, bottom);
    }
    /// <summary>
    /// Rect Copy Constructor
    /// </summary>
    public Rect(Rect other)
    {
        this = other;
    }
    /// <summary>
    /// Rect Initialization
    /// </summary>
    public void Set(int left, int top, int right, int bottom)
    {
        Left = left; Top = top; Right = right; Bottom = bottom;
    }
    /// <summary>
    /// Height
    /// </summary>
    public readonly int Height => Bottom - Top;
    /// <summary>
    /// Width
    /// </summary>
    public readonly int Width => Right - Left;
    /// <summary>
    /// Horizontal Center 
    /// </summary>
    public readonly int CenterX => (Left + Right) / 2;
    /// <summary>
    /// Vertical Center 
    /// </summary>
    public readonly int CenterY => (Top + Bottom) / 2;
    /// <summary>
    /// Validation
    /// </summary>
    public readonly bool IsEmpty => Left >= Right || Top >= Bottom;
    /// <summary>
    /// Check point visibility
    /// </summary>
    public readonly bool HasPoint(int x, int y) => x >= Left && x < Right && y >= Top && y < Bottom;
    /// <summary>
    /// Overlap Check
    /// </summary>
    public readonly bool IsOverlap(Rect rc)
    {
        return Left < rc.Right && Right > rc.Left && Top < rc.Bottom && Bottom > rc.Top;
    }
    /// <summary>
    /// Covering Check
    /// </summary>
    public readonly bool IsCovering(Rect rc)
    {
        return Left <= rc.Left && Right >= rc.Right && Top <= rc.Top && Bottom >= rc.Bottom;
    }
    /// <summary>
    /// Immutable intersection with another Rect objects
    /// </summary>
    public readonly Rect GetIntersection(Rect rect)
    {
        return new Rect()
        {
            Left = Math.Max(Left, rect.Left),
            Top = Math.Max(Top, rect.Top),
            Right = Math.Min(Right, rect.Right),
            Bottom = Math.Min(Bottom, rect.Bottom)
        };
    }
    /// <summary>
    /// Immutable Union of two Rect objects
    /// </summary>
    public readonly Rect GetUnion(Rect rect)
    {
        if (rect.IsEmpty)
            return this;
        if (IsEmpty)
            return rect;
        return new Rect()
        {
            Left = Math.Min(Left, rect.Left),
            Top = Math.Min(Top, rect.Top),
            Right = Math.Max(Right, rect.Right),
            Bottom = Math.Max(Bottom, rect.Bottom)
        };
    }

    /// <summary>
    /// Rects Union
    /// </summary>
    public static Rect Union(Rect rc1, Rect rc2)
    {

        Rect rc = new();
        if (rc1.IsEmpty)
            rc = rc2;
        else if (rc2.IsEmpty)
            rc = rc1;
        else
        {
            rc.Left = Math.Min(rc1.Left, rc2.Left);
            rc.Top = Math.Min(rc1.Top, rc2.Top);
            rc.Right = Math.Max(rc1.Right, rc2.Right);
            rc.Bottom = Math.Max(rc1.Bottom, rc2.Bottom);
        }
        return rc;
    }
    /// <summary>
    /// LeftTop Comparison
    /// </summary>
    public static int CompareLeftTop(Rect rc1, Rect rc2)
    {
        if (rc1.Left == rc2.Left && rc1.Top == rc2.Top)
            return 0;
        return rc1.Left < rc2.Left || rc1.Left == rc2.Left && rc1.Top < rc2.Top ? -1 : 1;
    }
    /// <summary>
    /// TopLeft Comparison
    /// </summary>
    public static int CompareTopLeft(Rect rc1, Rect rc2)
    {
        if (rc1.Left == rc2.Left && rc1.Top == rc2.Top)
            return 0;
        return rc1.Top < rc2.Top || rc1.Top == rc2.Top && rc1.Left < rc2.Left ? -1 : 1;
    }
    /// <summary>
    /// CenterY-Left Comparison
    /// </summary>
    public static int ComparerCenterYLeft(Rect rc1, Rect rc2)
    {
        if (rc1.CenterY == rc2.CenterY && rc1.Left == rc2.Left)
            return 0;
        return rc1.CenterY < rc2.CenterY || (rc1.CenterY == rc2.CenterY && rc1.Left < rc2.Left) ? -1 : 1;
    }

}
/// <summary>
/// Field bounding box information
/// </summary>
public class BoundingBox
{
    /// <summary>
    /// Default/Empty BoundingBox
    /// </summary>
    public BoundingBox()
    {
        Left = Width = Top = Height = 0;
    }
    /// <summary>
    /// Used in OCR/JSON to represent Word's bounding box.
    /// </summary>
    public BoundingBox(int top, int left, int height, int width)
    {
        Top = top;
        Left = left;
        Height = height;
        Width = width;
    }
    /// <summary>
    /// Gets or sets bounding rectangle X value of start point in pixels.
    /// </summary>
    public int Left { get; set; }

    /// <summary>
    /// Gets or sets bounding rectangle Y value of start point in pixels.
    /// </summary>
    public int Top { get; set; }

    /// <summary>
    /// Gets or sets bounding rectangle width in pixels.
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Gets or sets bounding rectangle height in pixels.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Convert to Rect
    /// </summary>
    public Rect Rect
    {
        get
        {
            return new Rect(Left, Top, (Left + Width), (Top + Height));
        }
    }
}
