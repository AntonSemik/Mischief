using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public delegate void OnTrustChange(int newValue);
    public static OnTrustChange onTrustChange;

    public delegate void OnPlayerResponse(int trustChange, string answer); //can add animations to pass here and other stuff
    public static OnPlayerResponse onPlayerResponse;

    public string customerName = "Kate";
    public int baseTrust = 50;

    public TMP_Text answerText;

    int maxTrust = 100;
    int currentTrust;

    private void Awake()
    {
        onPlayerResponse += ReactToPlayerResponse;
    }

    private void OnDestroy()
    {
        onPlayerResponse -= ReactToPlayerResponse;
    }

    private void Start()
    {
        SetupCustomer();
    }

    private void OnEnable()
    {
        SetupCustomer();
    }

    void SetupCustomer()
    {
        currentTrust = baseTrust;

        if (onTrustChange != null) onTrustChange(currentTrust);
    }

    void ReactToPlayerResponse(int trustChange, string answer)
    {
        ChangeTrust(trustChange);

        answerText.text = answer;

        StartCoroutine(WaitToMoveOn(0.2f));
    }

    void ChangeTrust(int value)
    {
        currentTrust += value;

        currentTrust = Mathf.Clamp(currentTrust, 0, maxTrust);

        if(onTrustChange != null) onTrustChange(currentTrust);
    }

    IEnumerator WaitToMoveOn(float time)
    {
        yield return new WaitForSeconds(time);

        if(ResponseBlockManager.onNextBlock != null) ResponseBlockManager.onNextBlock();
    }
}