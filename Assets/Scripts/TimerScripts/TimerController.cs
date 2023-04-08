using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine.UI;

public class TimerController : Base
{
    private float CountDownTime = 0f;

    [Title("Timer Index Values")]
    [SerializeField] float StartingTime = 60f;
    [SerializeField] public TextMeshProUGUI TimerText;
    void Start()
    {
        CountDownTime = StartingTime;
    }

    private void Update()
    {
        GetTimerController();
    }
    public void GetTimerController()
    {
        CountDownTime -= 1 * Time.deltaTime;
        TimerText.text = CountDownTime.ToString("0");

        if (CountDownTime <= 0)
        {
            CountDownTime = 0;
            e_spawnController.IsFree = false;
            GameManager.Instance.GetWin();
        }
    }
}
