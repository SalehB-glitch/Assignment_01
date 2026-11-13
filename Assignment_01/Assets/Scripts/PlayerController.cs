using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    public int targetScore = 1000;
    public CoinSpawner coinSpawner;

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private int score;
    public bool isGameOver = false; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isGameOver) return; 

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(h, v).normalized;
    }

    void FixedUpdate()
    {
        if (isGameOver) return; 

        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isGameOver) return; 

        if (other.CompareTag("Coin"))
        {
            Coin coin = other.GetComponent<Coin>();
            score += coin.value;
            Debug.Log("Score: " + score);

            Destroy(other.gameObject);
            coinSpawner.CoinCollected();

            if (score >= targetScore)
            {
                isGameOver = true;
                Debug.Log("you won");
            }
        }
        else if (other.CompareTag("Enemy"))
        {
            isGameOver = true;
            Debug.Log("you lose");
        }
    }
}