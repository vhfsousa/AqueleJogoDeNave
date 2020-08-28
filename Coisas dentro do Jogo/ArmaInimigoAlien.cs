using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaInimigoAlien : MonoBehaviour
{
  public GameObject tiroInimigoAlien;
    private float delay;
    [SerializeField] private float tempoDelayInimigo;
    public AudioSource audioS;
    public AudioClip somTiroInimigoAlien;
    void Start()
    {
        audioS = GetComponent<AudioSource>();        
    }

    void Update()
    {
        //Faz com que o tiro saia com um delay, que é decidido no inspector
        delay -= Time.deltaTime;
        if (delay <= 0){
            AtirarTiroInimigoAlien();
            delay = tempoDelayInimigo;
        }
    }

    void AtirarTiroInimigoAlien(){
        //Função que faz com que o projétil seja criado
        audioS.PlayOneShot(somTiroInimigoAlien);
        Instantiate (tiroInimigoAlien, this.transform.position, this.transform.rotation);
    }
}