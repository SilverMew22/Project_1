using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed = 1;
    int randomXPositionForCube;

    // Start is called before the first frame update
    void Start()
    {
        // Not used
    }

    // Update is called once per frame
    void Update()
    {
        // Moves gameObject's tranform up in the Y direction by increasing the number by .001 each frame.
        //transform.position += Vector3.up * .001f;

        // Moves gameObject's transform up in the Y direction by adding a new Vector3 with .001 as the Y value.
        //this.transform.position = this.transform.position + new Vector3(0, .001f, 0);

        // Moves gameObject's transform to a random X position, and increases the Y position based on a normalized speed.
        //transform.position = new Vector3(randomInt, transform.position.y + speed * Time.deltaTime, 0);

        GenerateANewRandomIntegerAndPutItInRandomXPositionForCube();
        TeleportCubeLeftAndRight();
        MoveCubeOffTheTopOfTheScreen();
    }

    void GenerateANewRandomIntegerAndPutItInRandomXPositionForCube()
    {
        randomXPositionForCube = Random.Range(-10, 11);
    }

    void TeleportCubeLeftAndRight()
    {
        transform.position = new Vector3(randomXPositionForCube, transform.position.y, 0);
    }

    void MoveCubeOffTheTopOfTheScreen()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}