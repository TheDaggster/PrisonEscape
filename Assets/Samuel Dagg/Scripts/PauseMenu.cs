using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool IsPaused; // This is made static field in case the group would like to make the enemy also follow the pause they just have to make a simple IsPaused method like this one.


    void Start()
    {
        pauseMenu.SetActive(false); // Stops the Pause menu showing up instantly if we accidentally left it on during a build for the game.
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // this key can be changed to anything i Just thought ESC would be a nice way to pause the game
        {
            if (IsPaused) // Script checks if IsPaused function is true/false if game is currently paused pressing ESC again will resume and vice versa. 
            {
                Resume(); 
            }           
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0; // slows down game to 0 speed (this gives the effect the game is paused) 
            IsPaused = true; // IsPaused is true since we are pausing the game. 
        }


        public void Resume()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1; // 1 speed puts the game back to default time space. (gives effect the game has been un-paused)
            IsPaused = false; //IsPaused is false since we are resuming the game. 
        }

        public void Return() // This void returns the user back to the main menu
        {
            Time.timeScale = 1; // Returns the speed back to default. 
            SceneManager.LoadScene("Menu"); // Loads the "Menu" or whatever we have as the menu named as and loads here
        }

        /*
        public void ragequit() 
        {
            Application.Quit(); //Un-Comment this if you wanted to make another button where you can just straight up rage quit in menu without ALT + F4'ing!
        }
        */
    }


