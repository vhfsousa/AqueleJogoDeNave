using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionamentoTiro : MonoBehaviour
{
    public int velocidadeBala;
    public Rigidbody2D rb;
    void Start()
    {
        //Quando o tiro nasce ele vai para a direita com a velocidade que foi decidida no Inspector
        rb.velocity = transform.right * velocidadeBala;
        Destroy(this.gameObject, 1.5f);
    }

    void Update()
    {

    }


    void OnTriggerEnter2D (Collider2D collider){
        //Pontuação do Jogo + Destruição do Tiro do Player

        if(collider.gameObject.CompareTag("Inimigo")){
            Jogador.pontuacao += 100;
            Destroy(this.gameObject);
        }
        
    if(collider.gameObject.CompareTag("InimigoAlien")){
            Jogador.pontuacao += 50;
            Destroy(this.gameObject);
        }

        if(collider.gameObject.CompareTag("TiroInimigo")){
            Jogador.pontuacao += 5;
            Destroy(this.gameObject);
        }

        if(collider.gameObject.CompareTag("TiroInimigoAlien")){
            Jogador.pontuacao += 5;
            Destroy(this.gameObject);
        }

        if(collider.gameObject.CompareTag("Cometa")){
            Jogador.pontuacao += 150;
            Destroy(this.gameObject);
        }

        if(collider.gameObject.CompareTag("Boss")){
            Destroy(this.gameObject);
        }
    }
}