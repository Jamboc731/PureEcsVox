using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Transforms;
using Unity.Entities;

public class RotateSystem : ComponentSystem
{

    public struct RotateGroup
    {
        public Rotate rot;
        public int length;
        public ComponentDataArray<Rotation> rotation;
    }

    [Inject] private RotateGroup rotGroup;
    protected override void OnUpdate ()
    {
        for(int i = 0; i < rotGroup.length; i++)
        {
            var temp = rotGroup.rotation [i];
            temp.Value += Quaternion.Euler (Vector3.one * rotGroup.rot.speed);
        }
    }
}
