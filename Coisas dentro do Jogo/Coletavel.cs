using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip somPontuacao;
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collider){
        if(collider.gameObject.CompareTag("Jogador")){
            audioS.PlayOneShot(somPontuacao);
            Jogador.pontuacao += 200;
            Arma.powerUp = true;
            Destroy(this.gameObject);
        }
    }
}