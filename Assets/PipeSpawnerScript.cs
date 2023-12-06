using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Controleer of de timer minder is dan de spawnrate
        if (timer < spawnrate)
        {
            // Verhoog de timer met de verstreken tijd sinds de vorige frame
            timer = timer + Time.deltaTime;
        }
        else
        {
            // Roep de spawnpipe-methode aan en reset de timer
            spawnpipe();
            timer = 0;
        }
       
    }
    void spawnpipe()
    {
        // Bepaal de laagste en hoogste positie voor het spawnen van pijpen
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Spawn een pijp op een willekeurige hoogte binnen het bereik
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range( lowestPoint, highestPoint ), 0), transform.rotation);
    }
}
