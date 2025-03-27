using System.Collections;
using UnityEngine;
using TMPro;

public class DeadLineScript : MonoBehaviour
{
    [SerializeField] private int daysBeforeWinter = 10;
    [SerializeField] private TextMeshProUGUI HUD;
    private float countdownTime = 180f; // 3 minutos em segundos

    void Start()
    {
        HUD.text = "Days Before Winter: " + daysBeforeWinter;
        StartCoroutine(DecreaseDaysCoroutine());
    }


    private IEnumerator DecreaseDaysCoroutine()
    {
        while (daysBeforeWinter > 0)
        {
            yield return new WaitForSeconds(countdownTime);
            DecreaseDays();
        }
    }

    private void DecreaseDays()
    {
        if (daysBeforeWinter > 0)
        {
            daysBeforeWinter--;
            HUD.text = "Days Before Winter: " + daysBeforeWinter;
        }
    }
}