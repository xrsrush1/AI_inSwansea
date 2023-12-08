using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Yarn.Unity;


public class anuWalkScript : MonoBehaviour
{
    public FollowScript followScript;
    public InMemoryVariableStorage yarnInMemoryStorage; //ref for the yarn script
    
    // Start is called before the first frame update
    void Start()
    {
        followScript.isAnusha = true;
        followScript.goToplayer = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("CallAnusha")]
    public void callAnusha()
    {
        followScript.goToplayer = true;
    }
}
