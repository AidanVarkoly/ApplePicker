using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject appleprefab;

    public float speed = 1f;

    public float LeftandRightEdge = 10f;

    public float ChanceToChangeDirections = 0.1f;

    public float SecondsBetweenAppleDrops = 1f;

    // Dropping Apples every second
    void Start()
    {

        Invoke("DropApple", 2f);

    }
        void DropApple()
        {

            GameObject apple = Instantiate<GameObject>(appleprefab);
            apple.transform.position = transform.position;
            Invoke("DropApple", SecondsBetweenAppleDrops);

        }


    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
        if (pos.x < -LeftandRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > LeftandRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < ChanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
