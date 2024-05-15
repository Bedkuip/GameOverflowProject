using UnityEngine;

public class WarningManager : MonoBehaviour
{
    public GameObject WarningScreen;
    public HealthManager HealthManager;
    void Update()
    {
        if (HealthManager.healthValue <= 30)
        {
            WarningScreen.SetActive(true);
        }
        else if (HealthManager.healthValue > 30)
        {
            WarningScreen.SetActive(false);
        }
    }
}