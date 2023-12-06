using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddlescript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        // Vind het gameobject met de tag "Logic" en krijg de LogicScript-component
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Wordt aangeroepen wanneer een ander object de trigger van dit object binnengaat
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Controleer of het object dat de trigger binnengaat op laag 3 zit (de laag voor de vogel)
        if (collision.gameObject.layer == 3)
        {
            // Roep de addscore-methode aan in het LogicScript om de score te verhogen
            logic.addscore(1);
        }
        
    }
}
