using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealth;
    [SerializeField] private Image currenthealth;

    private void Start()
    {
        totalhealth.fillAmount = playerHealth.currenthealth / 10; 
    }

    private void Update()
    {
        currenthealth.fillAmount = playerHealth.currenthealth / 10;
    }
}
