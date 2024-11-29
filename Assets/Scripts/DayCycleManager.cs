using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycleManager : MonoBehaviour
{
    public delegate void OnDayStart();
    public static OnDayStart onDayStart;
    public delegate void OnNightStart();
    public static OnNightStart onNightStart;

    bool isDaytime = true;

    private void Start()
    {
        onDayStart();
        isDaytime = true;
    }

    private void Update()
    {
        //TODO: call cycle changes when all clients are processed or player starts a day; For now done on Spacebar

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (isDaytime)
            {
                onNightStart();
                isDaytime = false;
            } else
            {
                onDayStart();
                isDaytime = true;
            }
        }
    }
}
