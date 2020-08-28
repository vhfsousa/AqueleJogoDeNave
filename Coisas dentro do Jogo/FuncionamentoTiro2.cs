using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionamentoTiro2 : MonoBehaviour
{
    public int velocidadeBala;
    public Rigidbody2D rb;
    public AudioSource audioS;
    public AudioClip somPontuacao;
    
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        //Quando o tiro nasce ele vai para a direita com a velocidade que foi decidida no Inspector
        rb.velocity = transform.right * velocidadeBala;
        Destroy(this.gameObject, 3f);
    }

    void Update()
    {

    }


    void OnTriggerEnter2D (Collider2D collider){
        //Pontuação do Jogo + Destruição do Tiro do Player

        if(collider.gameObject.CompareTag("Inimigo")){
            audioS.PlayOneShot(somPontuacao);
            Jogador.pontuacao += 100;
        }
        
    if(collider.gameObject.CompareTag("InimigoAlien")){
            audioS.PlayOneShot(somPontuacao);
            Jogador.pontuacao += 50;
        }

        if(collider.gameObject.CompareTag("TiroInimigo")){
            audioS.PlayOneShot(somPontuacao);
            Jogador.pontuacao += 5;
        }

        if(collider.gameObject.CompareTag("TiroInimigoAlien")){
            audioS.PlayOneShot(somPontuacao);
            Jogador.pontuacao += 5;
        }

        if(collider.gameObject.CompareTag("Cometa")){
            audioS.PlayOneShot(somPontuacao);
            Jogador.pontuacao += 150;
        }
    }
}