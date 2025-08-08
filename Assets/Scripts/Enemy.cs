using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 movement = Vector3.down;
    public int health = 3;
    private int currentHealth;

    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * movement;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            currentHealth--;
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
