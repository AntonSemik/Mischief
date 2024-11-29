using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayStartButton : MonoBehaviour
{
    public void OnPressed()
    {
        DayCycleManager.onDayStart();
    }
}
