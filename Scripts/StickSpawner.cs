using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSpawner : MonoBehaviour
{
    public GameObject smallStick;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Spawn();
        }
    }
    void Spawn()
    {
        Instantiate(smallStick,transform.position,transform.rotation);
    }
}
