using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoadScript : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial"); // Scene "TestRoom" is loaded on Click
        Debug.Log("Going to first level!"); // Using Debug message to acknowledge scene loaded on click.
    }

    public void Exit()
    {
        Application.Quit(); // On click Quits game.
        Debug.Log("Successfully Quit Game!"); // Debug message shows if game has quit.
    }
    
}
