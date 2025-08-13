using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 movement = Vector3.down;
    public int health = 3;
    private int currentHealth;

    void Start()
    {
        // Inicializa a saúde do inimigo
        currentHealth = health;

        Destroy(gameObject, 5f); // Destroi o inimigo após 5 segundos para evitar que ele fique no jogo indefinidamente
    }

    void Update()
    {
        // Move o inimigo na direção especificada (por padrão é pra baixo) a uma velocidade constante
        transform.position += speed * Time.deltaTime * movement;
    }

    // Função chamada quando o inimigo colide com outro objeto
    // Aqui, verifica se o objeto colidido é uma bala e reduz a saúde do inimigo
    // O OnTriggerEnter2D é uma função da Unity, então ela é chamada automaticamente
    // quando ocorre uma colisão com um objeto que tem um Collider2D marcado como Trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        // Todo GameObject tem um campo chamado tag, e aqui estamos buscando um com a tag Bullet
        if (other.CompareTag("Bullet"))
        {
            // Se o inimigo colidir com uma bala, destrói a bala e reduz a saúde do inimigo
            Destroy(other.gameObject);
            currentHealth--;

            // Se a saúde do inimigo chegar a zero, destrói o inimigo
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
