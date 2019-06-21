using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    public Transform[] wayPoints;

    int cur = 0;

    public float speed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != wayPoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, wayPoints[cur].position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        else
        {
            cur = (cur + 1) % wayPoints.Length;
        }

        Vector2 dir = wayPoints[cur].position - transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pacman")
        {
            Destroy(co.gameObject);
        }
    }
}
