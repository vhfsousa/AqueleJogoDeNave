using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionamentoTiroInimigo : MonoBehaviour
{
    public int velocidadeTiroInimigo;
    public Rigidbody2D rb;
    public GameObject explosao;
    void Start()
    {
        //Quando o tiro nasce ele vai para a esquerda com a velocidade que foi decidida no Inspector
        rb.velocity = (transform.right * -1) * velocidadeTiroInimigo;
        Destroy(this.gameObject, 2f);
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