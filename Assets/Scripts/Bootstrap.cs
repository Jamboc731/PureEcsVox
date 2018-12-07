using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;
using Unity.Mathematics;

namespace PureECSVoxels
{
    public sealed class Bootstrap
    {
        
        public static EntityArchetype meshArchetype;
        public static EntityArchetype voxelArchetype;

        public static MeshInstanceRenderer meshLook;
        public static MeshInstanceRenderer voxelLook;
        public static Mesh meshToVoxelise;
        public static Material materialToVoxelise;
        public static GameObject[] boneList;

        public struct BonesGroup
        {
            public Bone bone;
            public GameObjectEntity gOE;
            public int length;
        }

        [Inject] private BonesGroup bones;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialise()
        {

            var eManager = World.Active.GetOrCreateManager<EntityManager>();

            meshArchetype = eManager.CreateArchetype(typeof(Position), typeof(Rotation), typeof(Voxelise));

            voxelArchetype = eManager.CreateArchetype(typeof(Position), typeof(Rotation), typeof(Scale), typeof(Rotate), typeof(Voxelise), typeof(BoxCollider), typeof(Transform));
            

            

        }
        

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void InitialiseAfterScene()
        {
            var eManager = World.Active.GetOrCreateManager<EntityManager>();

            

            voxelLook = GetMeshInstance("VoxelRendererPrototype");
            meshLook = GetMeshInstance("MeshRendererPrototype");

            var mesh = meshLook.mesh;

            List<Vector3> verts = new List<Vector3>(mesh.vertices);

            boneList = GameObject.FindGameObjectsWithTag("EditorOnly");

            for (int i = 0; i < verts.Count; i++)
            {

                var vox = eManager.CreateEntity(voxelArchetype);
                eManager.SetComponentData(vox, new Position { Value = verts[i] });
                eManager.SetComponentData(vox, new Scale { Value = new float3(0.05f, 0.05f, 0.05f)});
                eManager.AddSharedComponentData(vox, voxelLook);

               
            }

        }

        public static MeshInstanceRenderer GetMeshInstance(string name)
        {

            var rendComponent = GameObject.Find(name);
            var result = rendComponent.GetComponent<MeshInstanceRendererComponent>().Value;
            Object.Destroy(rendComponent);
            return result;

        }

    }
}
