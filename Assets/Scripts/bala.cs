using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour {

    [SerializeField]
    private float speed = 10;
     private int ponto;
     public int score;

    void Start()
    {
        int score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Destroy(gameObject,0.8f);
        
        
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Inimigo")
        {
         Destroy(this.gameObject);

        ponto++;
      
          
        }
        if(ponto >= 3)
        {
          score ++;


        }
}
       
}

