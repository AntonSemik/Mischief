using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerResponse : MonoBehaviour
{
    public string responseText; //load those from file or whatever
    public int trustChange;

    public TMP_Text text;

    private void Start()
    {
        text.text = responseText;
    }

    public void OnSelected()
    {
        if(Customer.onPlayerResponse != null) Customer.onPlayerResponse(trustChange);
    }
}
