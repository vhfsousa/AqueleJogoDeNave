using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaInimigoBoss : MonoBehaviour
{
    public GameObject tiroInimigoBoss;
    private float delay;
    [SerializeField] private float tempoDelayInimigo;
    public AudioSource audioS;
    public AudioClip somTiroBoss;
    void Start()
    {
        audioS = GetComponent<AudioSource>();        
    }

    void Update()
    {
        //Faz com que o tiro saia com um delay, que é decidido no inspector
        delay -= Time.deltaTime;
        if (delay <= 0){
            AtirarTiroInimigoBoss();
            delay = tempoDelayInimigo;
        }
    }

    void AtirarTiroInimigoBoss(){
        //Função que faz com que o projétil seja criado
        audioS.PlayOneShot(somTiroBoss);
        Instantiate (tiroInimigoBoss, this.transform.position, this.transform.rotation);
    }
    }