using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_CustomerTrustBar : MonoBehaviour
{
    TMP_Text trustText;

    public Gradient gradient;

    int maxTrust = 100;

    private void Awake()
    {
        trustText = GetComponent<TMP_Text>();

        Customer.onTrustChange += UpdateValue;
    }

    private void OnDestroy()
    {
        Customer.onTrustChange -= UpdateValue;
    }

    void UpdateValue(int newValue)
    {
        trustText.text = newValue.ToString();

        trustText.color = gradient.Evaluate((newValue * 1f) / maxTrust);
    }
}
