using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public bool moveCon;
   public GameObject goSc;
    void Start()
    {
        goSc=GameObject.FindGameObjectWithTag("Manager");
        rb=GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {   
        if(moveCon==false)
        rb.MovePosition(rb.position+Vector2.up*speed*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Circle")
        {
            transform.SetParent(col.transform);
            moveCon=true;
        }
        if(col.gameObject.tag=="SmallCircle")
        {
           goSc.GetComponent<GameOver>().gOver();
        }
    }
}
