using UnityEngine;

public class Lava : MonoBehaviour
{

    [SerializeField] private float damage;

    private void OnCollisionEnter2D(Collision2D col)

    {
        if (col.gameObject.tag == "Player")
        {
            Health playerHealth = col.gameObject.GetComponent<Health>();
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}