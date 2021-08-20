using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject BigCircle;
    public GameObject SpawnLoc;
   public void gOver()
   {
       BigCircle.GetComponent<Circle>().enabled=false;
       SpawnLoc.GetComponent<StickSpawner>().enabled=false;
       
   }
}
