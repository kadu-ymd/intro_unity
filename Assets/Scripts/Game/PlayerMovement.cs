using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10.0f;
    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement.normalized * Time.fixedDeltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collectable")
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadSceneAsync("GameOver");
        }
    }
}
