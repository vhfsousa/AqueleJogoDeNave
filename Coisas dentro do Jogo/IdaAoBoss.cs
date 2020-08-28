using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdaAoBoss : MonoBehaviour
{
    public string nomeDaCena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Jogador")){
            SceneManager.LoadScene(nomeDaCena);
        }
    }
}