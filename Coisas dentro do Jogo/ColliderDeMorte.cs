using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDeMorte : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip perdeVida;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    //Quando o personagem sai da tela, ele perde uma vida
    void OnTriggerExit2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Jogador"))
        {
            Jogador.vidaPlayer --;
            audioS.PlayOneShot(perdeVida);
            collider.GetComponent<Jogador>().transform.position = Jogador.posInicial;
        }
    }
}