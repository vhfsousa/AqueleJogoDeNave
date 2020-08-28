using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    //Atributos
    Rigidbody2D rb;
    SpriteRenderer sr;
    //V = Vertical Axis
    float v;
    public float velocidadeY;
    public static int vidaPlayer;
    public static Vector2 posInicial;
    public static int pontuacao;
    public GameObject explosao;
    public AudioSource audioS;
    public AudioClip perdeVida;
    public string nomeDaCena;
    public Animator anim;

    void Start()
    {
        //Configurações iniciais no jogo
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        audioS = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        v = 0;
        vidaPlayer = 3;
        pontuacao = 0;
        posInicial = new Vector2(-6, 0);
        transform.position = posInicial;
    }

    void FixedUpdate()
    {
        //Velocidade da movimentação
        rb.velocity = new Vector2 (rb.velocity.x, v * velocidadeY);
    }

    void Update()
    {
        //Utilizar os inputs para movimentação
        v = Input.GetAxis("Vertical");

        //Morte
        if(vidaPlayer < 0){
            SceneManager.LoadScene(nomeDaCena);
        }
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Inimigo")){
            audioS.PlayOneShot(perdeVida);
            anim.Play("PlayerTomando");
            vidaPlayer --;
        }

        if(collider.gameObject.CompareTag("InimigoAlien")){
            audioS.PlayOneShot(perdeVida);
            anim.Play("PlayerTomando");
            vidaPlayer --;
        }

        if(collider.gameObject.CompareTag("TiroInimigo")){
            audioS.PlayOneShot(perdeVida);
            anim.Play("PlayerTomando");
            vidaPlayer --;
        }

        if(collider.gameObject.CompareTag("TiroInimigoAlien")){
            audioS.PlayOneShot(perdeVida);
            anim.Play("PlayerTomando");
            vidaPlayer --;
        }

        if(collider.gameObject.CompareTag("Cometa")){
            audioS.PlayOneShot(perdeVida);
            anim.Play("PlayerTomando");
            vidaPlayer --;
        }

        if(collider.gameObject.CompareTag("TiroBoss")){
            anim.Play("PlayerTomando");
        }
}
}