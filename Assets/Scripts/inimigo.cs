using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{

    public float speed ;
    public float stoppingDistance;
    private Transform target;
    int cont = 0;


        void Start()
    {
         target = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Transform>(); 

    }

       void Update()
    {
        
    if(Vector2.Distance(transform.position,target.position)>stoppingDistance)
    {
    transform.position=Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
    }
    
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bala")
        {
            
           cont++;
           if(cont >= 3)
           {
               Destroy(this.gameObject);
           }
             Destroy(collision.gameObject);
           
        }
}

}
