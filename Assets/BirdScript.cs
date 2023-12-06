using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public Animator Wing;
    // Start is called before the first frame update
    void Start()
    {
        // Vind het gameobject met de tag "Logic" en krijg de LogicScript-component
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //conroleert of de spatiebalk is ingedrukt en of de vogel nog leeft
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
            Wing.SetTrigger("Blub");
        }

        // kijkt of the vogel uit de camera is
        if (transform.position.y > 20 || transform.position.y < -20)
        {
            Die();
        }
    }

    //je gaat dood als je tegen de pipe botst
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //roept de methode aan als de vogel botst
        Die();
    }

    // Methode om de dood van de vogel te verwerken
    void Die()
    {
        // Controleer of de vogel nog leeft om dubbele oproepen te voorkomen
        if (birdIsAlive)
        {
            // Roep de gameOver-methode aan in het LogicScript en markeer de vogel als dood
            logic.gameOver();
            birdIsAlive = false;
        }
    }
}
