using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMP_EndDayButton : MonoBehaviour
{
    public void OnPressed()
    {
        DayCycleManager.onNightStart();
    }
}
