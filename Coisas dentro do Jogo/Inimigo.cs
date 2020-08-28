using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public GameObject explosao;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider){
    //Destrói esse objeto de inimigo quando colide com a bala
    if(collider.gameObject.CompareTag("Bullet")){
        Instantiate(explosao, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
    }
}