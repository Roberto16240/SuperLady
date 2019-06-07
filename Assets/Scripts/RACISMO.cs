using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RACISMO : MonoBehaviour
{
 public GameObject inimigo;
    void Start()
    {
       InvokeRepeating("Spawn", 60f , 60f);
    }

    void Update()
    {
       
        

    }
    void Spawn()
     {
         Instantiate(inimigo,transform.position, Quaternion.identity);
     }
}
