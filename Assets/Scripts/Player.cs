using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject bala;
    public static int cont = 5;
    public static bool dano;
    public SpriteRenderer sprite;
    public static int pontos;
    public int c;
  
    
    // Start is called before the first frame update
    void Start()
    {
    dano = false;
        c = pontos;
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
    	var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    	transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bala, transform.position + new Vector3(dir.x/105, dir.y/105), transform.rotation * new Quaternion(0f, 0f, 90f, 0f) );
        }

        if (inimigo.iM == true)
        {
            pontos++;

            inimigo.iM = false;

        }

        c = pontos;
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Inimigo")
        {
            dano = true;
           cont --;
           if(cont == 0)
           {
                sprite.enabled = false;
           }
            Destroy(collision.gameObject);
           
        }
    }
        //[Serialized]
       // private image[] VIDAS;
}
	

