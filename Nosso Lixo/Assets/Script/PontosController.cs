using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosController : MonoBehaviour
{
    public GameObject[] hudPontosLixo, hudPontosNatureza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.pontosLixo <= 3)
        {
            hudPontosLixo[0].SetActive(false);
        }
        else if (PlayerController.pontosLixo == 4)
        {
            hudPontosLixo[0].SetActive(true);
        }

        if (PlayerController.pontosLixo <= 2)
        {
            hudPontosLixo[1].SetActive(false);
        }
        else if (PlayerController.pontosLixo == 3)
        {
            hudPontosLixo[1].SetActive(true);
        }

        if (PlayerController.pontosLixo <= 1)
        {
            hudPontosLixo[2].SetActive(false);
        }
        else if (PlayerController.pontosLixo == 2)
        {
            hudPontosLixo[2].SetActive(true);
        }

        if (PlayerController.pontosLixo <= 0)
        {
            hudPontosLixo[3].SetActive(false);
        }
        else if (PlayerController.pontosLixo == 1)
        {
            hudPontosLixo[3].SetActive(true);
        }
    }
}
