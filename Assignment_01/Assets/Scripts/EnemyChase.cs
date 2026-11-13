using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float speed = 3f;
    public Transform player;

    private Rigidbody2D rb;
    private PlayerController playerScript; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        if (player != null)
        {
            playerScript = player.GetComponent<PlayerController>();
        }
    }

    void FixedUpdate()
    {
        if (playerScript != null && playerScript.isGameOver) return;

        Vector2 direction = ((Vector2)player.position - rb.position).normalized;
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}