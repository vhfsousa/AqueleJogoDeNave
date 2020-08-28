using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoMenu : MonoBehaviour
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

    public void TrocarCena(){
        SceneManager.LoadScene(nomeDaCena);
    }
}