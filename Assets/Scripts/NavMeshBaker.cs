using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using Unity.AI.Navigation;
//using Unity.AI;
using UnityEngine.AI;

public class NavMeshBaker : MonoBehaviour
{
    public ARPlaneManager ARPlaneManager; // drag n drop the xr origin here in unity so itll pick up the manager component from origin
    public Transform player; //drag n drop the camera(camera offset) which is inside the xr origin here in unity

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach(var plane in ARPlaneManager.trackables)
        {
            if(plane.transform.position.y < player.position.y)
                plane.GetComponent<NavMeshSurface>().BuildNavMesh();
        }
    }
}
