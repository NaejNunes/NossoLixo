using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownController : MonoBehaviour
{

    public GameObject[] soldadoCasca;

    public static float posX, posY;

   public static int qtdInimigos;

    // Start is called before the first frame update
    void Start()
    {
        qtdInimigos = 1;
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;

        if (qtdInimigos <= 0 && PlayerController.pontosNatureza <= 0)
        {
            Instantiate(this.soldadoCasca[0], new Vector2(SpownController.posX, SpownController.posY), Quaternion.identity);
            qtdInimigos += 1;
        }

        if (qtdInimigos <= 0 && PlayerController.pontosNatureza == 1)
        {
            Instantiate(this.soldadoCasca[1], new Vector2(SpownController.posX, SpownController.posY), Quaternion.identity);
            qtdInimigos += 1;
        }

        if (qtdInimigos <= 0 && PlayerController.pontosNatureza == 2)
        {
            Instantiate(this.soldadoCasca[2], new Vector2(SpownController.posX, SpownController.posY), Quaternion.identity);
            qtdInimigos += 1;
        }

        if (qtdInimigos <= 0 && PlayerController.pontosNatureza == 3)
        {
            Instantiate(this.soldadoCasca[3], new Vector2(SpownController.posX, SpownController.posY), Quaternion.identity);
            qtdInimigos += 1;
        }
    }
}
