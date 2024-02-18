using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Vector2 targetPosition;
    public float moveStep;

    void Start()
    {
        targetPosition = GetRandomPoint();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveStep * Time.deltaTime);

        if ((Vector2)transform.position == targetPosition)
        {
            targetPosition = GetRandomPoint();
        }

    }

    Vector2 GetRandomPoint()
    {
        Vector2 randomVector = new Vector2();

        randomVector.x = Random.Range(-6, 6);
        randomVector.y = Random.Range(-3, 3);

        return randomVector;
    }

    void Catch()
    {
        Player.score++;
    }
}
