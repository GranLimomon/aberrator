using UnityEngine;

public class PersistentFollowPlayer : MonoBehaviour
{
    public Transform player;  // Referencia al jugador
    public float followSpeed = 5f;  // Velocidad de seguimiento
    public float stopDistance = 0.1f;  // Distancia m�nima para detenerse
    public float maxDistance = 10f;  // Distancia m�xima para dejar de seguir

    private bool isFollowing = false;  // Estado de seguimiento

    void Update()
    {
        if (isFollowing)
        {
            // Calcular la posici�n objetivo del objeto
            Vector3 targetPosition = player.position;

            // Calcular la distancia al jugador
            float distanceToPlayer = Vector3.Distance(transform.position, targetPosition);

            // Si la distancia es mayor que la distancia m�xima, dejar de seguir al jugador
            if (distanceToPlayer > maxDistance)
            {
                isFollowing = false;
                return;
            }

            // Si la distancia es mayor que la distancia m�nima, moverse hacia el jugador
            if (distanceToPlayer > stopDistance)
            {
                Vector3 direction = (targetPosition - transform.position).normalized;
                transform.position += direction * followSpeed * Time.deltaTime;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si la colisi�n es con el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            isFollowing = true;  // Comenzar a seguir al jugador
        }
    }
}
