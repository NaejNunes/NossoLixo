using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static float positionX, positionY, positionZ;

    public float speed, forceJump;

    public static int pontosLixo, pontosNatureza;

    int milesimos, segundos;

    bool groundCheck;

    public Rigidbody2D body;

    public GameObject gosmaLixo;

    Animator animacao;
    // Start is called before the first frame update
    void Start()
    {
        pontosLixo = 0;

        groundCheck = true;
        body = gameObject.GetComponent<Rigidbody2D>();

        animacao = GetComponent<Animator>();

        milesimos = 60;
        segundos = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Tempo();

        positionX = transform.position.x;
        positionY = transform.position.y;
        positionZ = transform.position.z;

        MovimentarPlayer();

        if (pontosLixo < 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (segundos <= 0)
        {
            GosmaLixo();
        }
    }

     void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Platform"))
        {
            groundCheck = true;
        }    
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("SoldadoCasca"))
        {
            pontosLixo -= 1;
        }
    }

    void MovimentarPlayer()
    {

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animacao.SetInteger("AndarHorizontal", 3);
            GetComponent<SpriteRenderer>().flipX = false;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        else if (Input.GetAxisRaw("Horizontal") < 0)
        {

            GetComponent<SpriteRenderer>().flipX = true;
            animacao.SetInteger("AndarHorizontal", 1);
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        }
        else
        {
            animacao.SetInteger("AndarHorizontal", 2);
        }

        if (Input.GetButtonDown("Jump") && groundCheck == true)
        {
            animacao.SetInteger("AndarHorizontal", 5);

            groundCheck = false;

            body.AddForce(new Vector2(0, forceJump));
        }
    }

    public void GosmaLixo()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animacao.SetInteger("AndarHorizontal", 4);

            Instantiate(this.gosmaLixo, new Vector3(PlayerController.positionX + 0.8f, PlayerController.positionY, PlayerController.positionZ), Quaternion.identity);

            segundos = 2;
        }
    }

    public void Tempo()
    {
        milesimos -= 1;

        if (milesimos <= 0)
        {
            segundos -= 1;

            milesimos = 60;
        }
    }
}
