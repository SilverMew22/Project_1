using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    int wholeNumber;
    float decimalNumber;
    Vector3 threeFloats;

    int randomXPositionThatIsLeftOrRight;

    void Start()
    {
        wholeNumber = 4;
        decimalNumber = 4.021f;
        threeFloats = new Vector3(2.0f, 1.0f, 3.333f);
        threeFloats.y = 4.23f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTheSphereToEitherTheLeftOrRightOfScreen();
        MoveTheSphereDeeperIntoTheScreen();
    }

    void MoveTheSphereToEitherTheLeftOrRightOfScreen()
    {
        randomXPositionThatIsLeftOrRight = Random.Range(0, 2);
        transform.position = new Vector3(-10 + 20 * randomXPositionThatIsLeftOrRight, transform.position.y, transform.position.z);
    }

    void MoveTheSphereDeeperIntoTheScreen()
    {
        transform.position = transform.position + Vector3.forward * Time.deltaTime * 10;
    }
}