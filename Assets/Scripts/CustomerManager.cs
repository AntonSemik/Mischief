using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public GameObject customer;

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
        customer.SetActive(true);
    }

    void SetNight()
    {
        customer.SetActive(false);
    }
}
