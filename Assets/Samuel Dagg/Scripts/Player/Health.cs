using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currenthealth { get; private set; }
    public GameObject DeathMenu; // GameObject DeathMenu is called 
    public bool dead; // Tick to Check if player is dead (if so initiate the DeathMenu called prior to this. 
    private void Awake()
    {
        currenthealth = startingHealth;
    }

    public void TakeDamage(float damage)
    {
        currenthealth = Mathf.Clamp(currenthealth - damage, 0, startingHealth);

        if (currenthealth > 0)
        {
            // Player takes damage (add animation to indicate the player lost health here) - Sam. 20/03/23
        }
        else
        {
            if (!dead)
            {
                /* Instead of adding some sort of death animation I had gotten lazy and added a death menu
                 which would pause the game and activate the death menu as a replacement to adding another animation
                 - Sam 20/03/23 p.s this subtext may be removed as I find time to do it. 
                */
                
                DeathMenu.SetActive(true); // Activates the Death screen Menu Object to show the player there options (Restart or Return to Menu).
                Time.timeScale = 0; // Pauses the screen to stop player being able to run and thought pause would be easier to implement then separately pausing the player. 
            }
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) // Small Test Example for Heart damage (If user presses the F key)
            TakeDamage(1); // Take "1" Heart from the GUI/Script When the user looses all 4 the Game over menu is played
    }

    public void AddHealth(float _value) // Small void to heal the player if they interact with certain objects
    {
        currenthealth = Mathf.Clamp(currenthealth + _value, 0, startingHealth); // Script tells current health to add the value (what ever number is filled in the script float value min is 0  and when is interacted with is added to starting health (or what health you have left)
    }
    
}

