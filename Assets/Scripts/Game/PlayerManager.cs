using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10.0f;
    public GameObject[] hp_gameobject;
    AudioSource audioSource;

    public static int hit_points = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        print(hit_points);
        if (hit_points < 0 ) {
            hit_points = 0;
        }

        for (int i = 0; i < hp_gameobject.Length - hit_points; i++)
        {
            Destroy(hp_gameobject[i].gameObject);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + speed * Time.fixedDeltaTime * movement.normalized);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collectable")
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }

        if (other.tag == "Key")
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Door"));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hit_points--;

            if (hit_points <= 0)
            {
                SceneManager.LoadSceneAsync("GameOver");
            }
            else
            {
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            hit_points--;

            if (hit_points <= 0)
            {
                SceneManager.LoadSceneAsync("GameOver");
            }
            else
            {
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
