using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int vidaBoss;
    public string nomeDoLevel;
    public AudioSource audioS;
    public AudioClip danoBoss;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        vidaBoss = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaBoss == 0){
            SceneManager.LoadScene(nomeDoLevel);
        }
    }

    void OnTriggerEnter2D (Collider2D collider){
        if(collider.gameObject.CompareTag("Bullet")){
            anim.Play("BossTomando");
            audioS.PlayOneShot(danoBoss);
            vidaBoss --;
    }
}
}