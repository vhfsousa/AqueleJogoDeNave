using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoAutomatica : MonoBehaviour
{
    public float velocidadeMovimentacao;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x + velocidadeMovimentacao * Time.deltaTime, transform.position.y, transform.position.z);
    }
}