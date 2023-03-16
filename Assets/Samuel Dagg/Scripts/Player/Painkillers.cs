using UnityEngine;

public class Painkillers : MonoBehaviour
{
  [SerializeField] private float healthValue; // Used to indicate how much health to give to the player upon interaction.

  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.tag == "Player") // If the Collision Hitting the box Has the tag "Player" then..
    {
      col.GetComponent<Health>().AddHealth(healthValue); // Get component Health.cs  find AddHealth void and add health
      gameObject.SetActive(false); // make inactive as soon as hit so it cant be abused and add multiple health. 
    }
  }
}
