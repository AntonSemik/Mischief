using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChanger : MonoBehaviour
{
    [SerializeField] GameObject dayUI;
    [SerializeField] GameObject nightUI;

    private void Awake()
    {
        DayCycleManager.onDayStart += SetDay;
        DayCycleManager.onNightStart += SetNight;
    }

    private void OnDestroy()
    {
        DayCycleManager.onDayStart -= SetDay;
        DayCycleManager.onNightStart -= SetNight;
    }

    void SetDay()
    {
        dayUI.SetActive(true);
        nightUI.SetActive(false);
    }

    void SetNight()
    {
        dayUI.SetActive(false);
        nightUI.SetActive(true);
    }
}
