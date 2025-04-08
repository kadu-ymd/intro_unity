using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] bool HorizontalMovement = true;

    public GameObject pointA;
    public GameObject pointB;
    public float speed;

    private Rigidbody2D rb;

    private Transform currentPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }

    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == pointB.transform)
        {
            if (HorizontalMovement)
            {
                rb.linearVelocity = new Vector2(speed, 0);
            }
            else
            {
                rb.linearVelocity = new Vector2(0, speed);
            }
        }
        else
        {
            print(currentPoint == pointB.transform);
            if (HorizontalMovement)
            {
                rb.linearVelocity = new Vector2(-speed, 0);
            }
            else
            {
                rb.linearVelocity = new Vector2(0, -speed);
            }
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform) 
        {
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }
    }

}