using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject tiroDaNave;
    public GameObject tiroEspecial;
    private float delay;
    [SerializeField] private float tempoDelay;
    public static bool powerUp;
    public AudioSource audioS;
    public AudioClip somTiroJogador;
    public AudioClip somTiroJogadorEspecial;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Faz com que o tiro saia com um delay, que é decidido no inspector
        delay -= Time.deltaTime;
        if (delay <= 0 && Input.GetKeyDown(KeyCode.Space) && powerUp == false){
            AtirarProjetil();
            delay = tempoDelay;
        }
        else if (delay <= 0 && Input.GetKeyDown(KeyCode.Space) && powerUp == true){
            AtirarEspecial();
            powerUp = false;
        }
    }

    void AtirarProjetil(){
        //Função que faz com que o projétil seja criado
        audioS.PlayOneShot(somTiroJogador);
        Instantiate (tiroDaNave, this.transform.position, this.transform.rotation);
    }
    
    void AtirarEspecial(){
        //Função que ativa o tiro especial
        audioS.PlayOneShot(somTiroJogadorEspecial);
        Instantiate (tiroEspecial, this.transform.position, this.transform.rotation);
    }
}