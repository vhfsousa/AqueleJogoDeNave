using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cometa : MonoBehaviour
{
    public int velocidadeCometa;
    public Rigidbody2D rb;
    public GameObject explosao;
    void Start()
    {
        //Movimentação do cometa
        rb.velocity = (transform.right * -1) * velocidadeCometa;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider){
        //Destruição desse objeto quando colidir com o tiro
        if(collider.gameObject.CompareTag("Bullet")){
            Instantiate(explosao, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}