using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoadScript : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial"); // Scene "TestRoom" is loaded on Click
        Debug.Log("Going to first level!"); //Debug Log in case of error
    }

    public void Exit()
    {
        Application.Quit(); // On click Quits game.
        Debug.Log("Successfully Quit Game!"); //Debug Log in case of error
    }
    
}
