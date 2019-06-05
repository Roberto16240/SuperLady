using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{ 
    public SpriteRenderer sprite; 
    void Start()
    {
        sprite.enabled = true;
    }

    void Update()
    {
        
    if (Player.dano == true || Player.cont == 4)
    {   
               
        sprite.enabled = false;
        Debug.Log ( " deu certo");
    }

    }

}


