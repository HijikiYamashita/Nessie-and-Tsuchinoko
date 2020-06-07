using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject[] points = new GameObject[5];
    int targetIndex = 0;
    public float speed = 1.0f;

    void Start()
    {
        points = GameObject.FindGameObjectsWithTag("Points");

        transform.position = points[targetIndex].transform.position;
        transform.LookAt(points[targetIndex].transform.position);
    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, points[targetIndex].transform.position) < 0.1f)
        {
            targetIndex = Random.Range(0, 5);
            transform.LookAt(points[targetIndex].transform.position);
        }
    }
}
