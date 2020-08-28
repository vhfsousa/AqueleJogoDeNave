using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Contador de Vida
        GetComponent<Animator>().SetInteger("playerLife", Jogador.vidaPlayer);
    }
}