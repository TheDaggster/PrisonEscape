using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currenthealth { get; private set; }
    public GameObject DeathMenu;
    public bool dead;
    private void Awake()
    {
        currenthealth = startingHealth;
    }

    public void TakeDamage(float damage)
    {
        currenthealth = Mathf.Clamp(currenthealth - damage, 0, startingHealth);

        if (currenthealth > 0)
        {
            // Player takes damage
        }
        else
        {
            if (!dead)
            {
                DeathMenu.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
            TakeDamage(1);
    }
    
}

