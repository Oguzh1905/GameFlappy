using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    //snelheid hoe de pipe beweegt
    public float moveSpeed = 5;
    //de plek waar de pipe wordt verwijderdt
    public float deadzone = -35;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //verplaatst de posotie van de pipe naar links
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        //kijkt of de positie van de pipe de deadzone heeft bereikt
        if(transform.position.x < deadzone)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
    }
}
