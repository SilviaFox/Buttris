
using UnityEngine;

public class SRSWallKickTests
{
    // Standard rotation types
    public static Vector2[] ZeroR = new Vector2[5]
    {new Vector2(0,0), new Vector2(-1,0), new Vector2(-1,1), new Vector2(0,-2), new Vector2(-1,-2)};

    public static Vector2[] RZero = new Vector2[5]
    {new Vector2(0,0), new Vector2(1,0), new Vector2(1,-1), new Vector2(0,2), new Vector2(1,2)};

    public static Vector2[] RTwo = new Vector2[5]
    {new Vector2(0,0), new Vector2(1,0), new Vector2(1,-1), new Vector2(0,2), new Vector2(1,2)};

    public static Vector2[] TwoR = new Vector2[5]
    {new Vector2(0,0), new Vector2(-1,0), new Vector2(-1,1), new Vector2(0,-2), new Vector2(-1,-2)};

    public static Vector2[] TwoL = new Vector2[5]
    {new Vector2(0,0), new Vector2(1,0), new Vector2(1,1), new Vector2(0,-2), new Vector2(1,-2)};

    public static Vector2[] LTwo = new Vector2[5]
    {new Vector2(0,0), new Vector2(-1,0), new Vector2(-1,-1), new Vector2(0,2), new Vector2(-1,2)};

    public static Vector2[] LZero = new Vector2[5]
    {new Vector2(0,0), new Vector2(-1,0), new Vector2(-1,-1), new Vector2(0,2), new Vector2(-1,2)};

    public static Vector2[] ZeroL = new Vector2[5]
    {new Vector2(0,0), new Vector2(1,0), new Vector2(1,1), new Vector2(0,-2), new Vector2(1,-2)};


    // I piece
    public static Vector2[] iZeroR = new Vector2[5]
    {new Vector2(0,0), new Vector2(-2,0), new Vector2(1,0), new Vector2(-2,1), new Vector2(1,2)};

    public static Vector2[] iRZero = new Vector2[5]
    {new Vector2(0,0), new Vector2(2,0), new Vector2(-1,0), new Vector2(2,1), new Vector2(-1,-2)};

    public static Vector2[] iRTwo = new Vector2[5]
    {new Vector2(0,0), new Vector2(-1,0), new Vector2(2,0), new Vector2(-1,2), new Vector2(2,-1)};

    public static Vector2[] iTwoR = new Vector2[5]
    {new Vector2(0,0), new Vector2(1,0), new Vector2(-2,0), new Vector2(1,-2), new Vector2(-2,1)};

    public static Vector2[] iTwoL = new Vector2[5]
    {new Vector2(0,0), new Vector2(2,0), new Vector2(-1,0), new Vector2(2,1), new Vector2(-1,-2)};

    public static Vector2[] iLTwo = new Vector2[5]
    {new Vector2(0,0), new Vector2(-2,0), new Vector2(1,0), new Vector2(-2,-1), new Vector2(1,2)};

    public static Vector2[] iLZero = new Vector2[5]
    {new Vector2(0,0), new Vector2(1,0), new Vector2(-2,0), new Vector2(1,-2), new Vector2(-2,1)};

    public static Vector2[] iZeroL = new Vector2[5]
    {new Vector2(0,0), new Vector2(-1,0), new Vector2(2,0), new Vector2(-1,2), new Vector2(2,-1)};

}
