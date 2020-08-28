using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionamentoTiroBoss : MonoBehaviour
{
    public int velocidadeTiroBoss;
    public Rigidbody2D rb;
    public GameObject explosao;
    public AudioSource audioS;
    public AudioClip perdeVida;
    void Start()
    {
        audioS = GetComponent<AudioSource>();

        //Quando o tiro nasce ele vai para a esquerda com a velocidade que foi decidida no Inspector
        rb.velocity = (transform.right * -1) * velocidadeTiroBoss;
        Destroy(this.gameObject, 2f);
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider){
        //Destruição desse objeto quando colidir com o tiro
        if(collider.gameObject.CompareTag("Bullet")){
            Instantiate(explosao, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
        //Diminuir Vida do Player
        if(collider.gameObject.CompareTag("Jogador")){
            audioS.PlayOneShot(perdeVida);
            Jogador.vidaPlayer --;
        }
    }
}