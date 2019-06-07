using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject bala;
    public Transform mao;
    public static int cont = 5;
    //public static bool dano;
    public SpriteRenderer sprite;
    public static int pontos;
    public int pontuação;
    public Sprite[] vidinhas;
    public Image vidao;

  
    
    void Start()
    {
        //dano = false;
        pontuação = pontos;
        sprite.enabled = true;
        mao = GetComponentInChildren<Transform>();
    }

    void Update()
    {
       
            
        
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
    	var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    	transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Input.GetMouseButtonDown(0))
        {
             Instantiate(bala, mao.position + new Vector3(dir.x/105, dir.y/105), transform.rotation * new Quaternion(0f, 0f, 90f, 0f) );
            //Instantiate(bala, mao.position, transform.forward);
             //Instantiate(bala, mao.position + new Vector3(dir.x/100, dir.y/-105), transform.rotation * new Quaternion(0f, 0f, 90f, 0f) );
        }

        if (inimigo.iM == true)
        {
            pontos++;

            inimigo.iM = false;

        }

        pontuação = pontos;
        //trocar sprite da vida
        trocarVida();
    } 
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Inimigo")
        {
            //dano = true;
           cont --;
           if(cont == 0)
           {
                sprite.enabled = false;
                SceneManager.LoadScene("GameOver");
                pontos = 0;
           }
            Destroy(collision.gameObject);
           
           
        }
    }
    public void trocarVida()
    {
        if(cont == 4)
        {
            vidao.sprite = vidinhas[cont];
        }
        if(cont == 3)
        {
            vidao.sprite = vidinhas[cont];
        }
        if(cont == 2)
        {
            vidao.sprite = vidinhas[cont];
        }
        if(cont == 1)
        {
            vidao.sprite = vidinhas[cont];
        }
    }
       
}
	

