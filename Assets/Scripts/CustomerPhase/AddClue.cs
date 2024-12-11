using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddClue : MonoBehaviour
{
    public string clueText;

    bool isFound = false;
    private void OnEnable()
    {
        isFound = false;
    }

    private void OnMouseDown()
    {
        if (UI_Clues.onClueFound != null && !isFound)
        {
            UI_Clues.onClueFound(clueText);
            isFound = true;
        }
    }
}
