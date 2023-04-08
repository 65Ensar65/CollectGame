using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine.EventSystems;

public class GameManager : BaseSingleton<GameManager>
{
    [Title("Cube Index Values")]
    [SerializeField] public int CollectorCubeIndex;
    [SerializeField] public TextMeshProUGUI CubeText;

    [Title("AI Cube Index")]
    [SerializeField] public int AICollectorCubeIndex;
    [SerializeField] public TextMeshProUGUI AICubeText;
    [SerializeField] public bool IsTextFree;
    [SerializeField] public bool AITextFree;

    [SerializeField] GameObject WinPanel;

    private void Update()
    {
        if (AITextFree)
        {
            CubeText.text = CollectorCubeIndex.ToString();

        }

        if (IsTextFree)
        {
            AICubeText.text = AICollectorCubeIndex.ToString();
        }
    }

    public void GetWin()
    {
        WinPanel.SetActive(true);
    }
}
