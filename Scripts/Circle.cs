using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(0,0,speed*Time.deltaTime);
    }
}
