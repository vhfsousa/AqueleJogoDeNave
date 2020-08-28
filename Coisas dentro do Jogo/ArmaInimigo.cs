using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaInimigo : MonoBehaviour
{
  public GameObject tiroInimigo;
    private float delay;
    [SerializeField] private float tempoDelayInimigo;
    public AudioSource audioS;
    public AudioClip somTiroInimigo;
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Faz com que o tiro saia com um delay, que é decidido no inspector
        delay -= Time.deltaTime;
        if (delay <= 0){
            AtirarTiroInimigo();
            delay = tempoDelayInimigo;
        }
    }

    void AtirarTiroInimigo(){
        //Função que faz com que o projétil seja criado
        audioS.PlayOneShot(somTiroInimigo);
        Instantiate (tiroInimigo, this.transform.position, this.transform.rotation);
    }
}