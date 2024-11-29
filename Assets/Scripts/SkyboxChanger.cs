using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    [SerializeField] Material daySkybox;
    [SerializeField] Material nightSkybox;

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
        RenderSettings.skybox = daySkybox;
    }

    void SetNight()
    {
        RenderSettings.skybox = nightSkybox;
    }
}
