using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    [Header("Shooting Settings")]
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float fireRate = 0.2f;
    private float nextFireTime = 0f;

    void Update()
    {
        Move();
        Shoot();
    }

    void Move()
    {
        // Captura o input do jogador para o movimento horizontal e vertical
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Cria um vetor de movimento baseado no input do jogador
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
        
        transform.position += speed * Time.deltaTime * movement;
    }
    
    void Shoot()
    {
        // Além de verificar a tecla de disparo, verifica se o tempo de recarga foi atingido
        // O Time.time é apenas o tempo atual do jogo (em segundos), e nextFireTime é o tempo em que o próximo disparo pode ocorrer
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            // Atualiza o tempo do próximo disparo e instancia o projétil
            // Se o disparo for feito aos 10 segundos, e fireRate for 0.5, então nextFireTime será 10.5 segundos
            nextFireTime = Time.time + fireRate;
            Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
}
