using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosão : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip somExplosao;

    // Start is called before the first frame update
    void Start()
    {
        audioS.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestruirObjeto(){
        Destroy(this.gameObject);
    }

    void TocarSom(){
        audioS.PlayOneShot(somExplosao);
    }
}