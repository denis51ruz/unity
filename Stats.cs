using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    //жизни
    public int health = 10;
    public int level = 2;
    public int speed = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
