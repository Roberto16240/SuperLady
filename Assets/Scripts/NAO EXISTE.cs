﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALADOMALCARALHO : MonoBehaviour
{
    public float speed ;
    public float stoppingDistance;
    private Transform target;
    int cont = 0;
    public static bool iM;

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
}
