using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaaa : MonoBehaviour
{
       public GameObject inimigo;
    void Start()
    {
       InvokeRepeating("Spawn", 0f , 3f);
    }

    void Update()
    {
       
        

    }
    void Spawn()
     {
         Instantiate(inimigo,transform.position, Quaternion.identity);
     }  
}
