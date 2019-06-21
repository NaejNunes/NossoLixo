using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldadoCasca : MonoBehaviour
{
    public Transform wayPoints;

    public float speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position != wayPoints.position)
        {
            Vector2 player = Vector2.MoveTowards(transform.position, wayPoints.position, speed);
            GetComponent<Rigidbody2D>().MovePosition(player);
        }
       
        Vector2 dir = wayPoints.position - transform.position;

    }   
 
   public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SpownController.qtdInimigos += 1;
            Destroy(this.gameObject);       
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("GosmaLixo"))
        {
            SpownController.qtdInimigos += 1;
            Destroy(this.gameObject);   
        }
    }
   
}
