using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSecret : MonoBehaviour
{
    public Vector3 teleportPosition;
      
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player") {
            other.transform.position = new Vector3(2.0f,1.52f,0f);
        }
    }
}
