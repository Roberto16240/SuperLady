using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{
      public SpriteRenderer sprite; 

    // Start is called before the first frame update
    void Start()
    {
                sprite.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
         if (Player.dano == true || Player.cont == 4)
    {   
               
        sprite.enabled = false;
        Debug.Log ( " deu certo");
    }
    }
}
