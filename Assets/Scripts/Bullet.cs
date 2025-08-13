using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 movement = Vector3.up;

    void Start()
    {
        // Destroi o projétil após 3 segundos para evitar que ele fique no jogo indefinidamente
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        // Move o projétil na direção especificada (por padrão é pra cima) a uma velocidade constante
        transform.position += speed * Time.deltaTime * movement;
    }
}
