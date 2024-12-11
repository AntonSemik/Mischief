using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Clues : MonoBehaviour
{
    public delegate void OnClueFound(string clue);
    public static OnClueFound onClueFound;

    public Transform cluesParent;
    public TMP_Text cluesPrefab;

    TMP_Text tempClue;
    List<TMP_Text> cluesList = new List<TMP_Text>();

    private void Awake()
    {
        onClueFound += AddClue;
    }

    private void OnDisable()
    {
        foreach(TMP_Text text in cluesList)
        {
            Destroy(text.gameObject);
        }

        cluesList.Clear();
    }

    private void OnDestroy()
    {
        onClueFound -= AddClue;
    }

    public void AddClue(string clueText)
    {
        tempClue = Instantiate(cluesPrefab, cluesParent);

        tempClue.text = clueText;

        cluesList.Add(tempClue);
    }
}
