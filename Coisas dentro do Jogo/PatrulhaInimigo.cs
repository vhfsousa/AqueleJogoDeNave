using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrulhaInimigo : MonoBehaviour
{
    [SerializeField] private float velocidadeNaveInimigo;
    [SerializeField] private float limiteYCima;
    [SerializeField] private float limiteYBaixo;

    void Start()
    {
        
    }

    void Update()
    {
        //Faz com que o inimigo vá de uma coordenada a outra, determinadas pelo Inspector
        if (velocidadeNaveInimigo >  0 && transform.position.y >= limiteYCima){
            velocidadeNaveInimigo = velocidadeNaveInimigo * -1;
        }
        else if (velocidadeNaveInimigo < 0 && transform.position.y <= limiteYBaixo){
            velocidadeNaveInimigo = velocidadeNaveInimigo * -1;
        }

        //Move o objeto em um eixo, baseado também no tempo entre um frame e outro, multiplicado pelo valor da velocidade determinado no Inspector
        transform.Translate (0, velocidadeNaveInimigo * Time.deltaTime, 0);
    }
}