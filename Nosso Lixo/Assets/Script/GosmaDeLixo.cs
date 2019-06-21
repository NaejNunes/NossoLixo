using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GosmaDeLixo : MonoBehaviour
{

    public float velocidadeGosma;

    int milesimos, segundos;
    // Start is called before the first frame update
    void Start()
    {
        milesimos = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidadeGosma);

        milesimos -= 1;

        if (milesimos <= 0)
        {
            segundos += 1;
        }

        if (segundos >= 1)
        {
            Destroy(this.gameObject);
        }
    }
}
