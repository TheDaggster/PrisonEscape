using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public void Fullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen; // Enables the User to Enable/Disable 
        Debug.Log("Fullscreen Enabled/Disabled!");
    }
}