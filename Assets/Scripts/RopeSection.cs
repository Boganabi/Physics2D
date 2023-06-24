using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct RopeSection
{
    public Vector3 pos;
    public Vector3 vel;

    // to write RopeSection.zero
    public static readonly RopeSection zero = new RopeSection(Vector3.zero);

    public RopeSection(Vector3 pos)
    {
        this.pos = pos;
        this.vel = Vector3.zero;
    }
}
