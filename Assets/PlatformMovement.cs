using System.Net.Sockets;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public Transform[] points;

    public int i;
    private void Start()
    {
        transform.position = points[startingPoint].position;
    }

    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.1f)
        {
            i++;
            if (i >= points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
