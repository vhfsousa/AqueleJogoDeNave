using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuação : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
         GetComponent<TextMeshProUGUI>().text = Jogador.pontuacao.ToString();
    }
}