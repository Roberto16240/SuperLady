using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaaa : MonoBehaviour
{
        public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("Spawn1", 0f , 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
         void Spawn1()
     {
         Instantiate(bala,transform.position, Quaternion.identity);
     }
}
