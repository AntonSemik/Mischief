using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseBlockManager : MonoBehaviour
{
    public delegate void OnNextBlock();
    public static OnNextBlock onNextBlock;

    public GameObject[] responseBlocks;

    int currentBlock = 0;

    private void Awake()
    {
        onNextBlock += NextBlock;
        Customer.onPlayerResponse += ResponseTaken;

        foreach (GameObject gameObject in responseBlocks)
        {
            gameObject.SetActive(false);
        }

        responseBlocks[currentBlock].SetActive(true);
    }

    private void OnDestroy()
    {
        onNextBlock -= NextBlock;
        Customer.onPlayerResponse -= ResponseTaken;
    }

    void NextBlock()
    {
        responseBlocks[currentBlock].SetActive(false);
        currentBlock++;

        if (currentBlock >= responseBlocks.Length) currentBlock = 0; //For now cycle back to 0, all this shit will be replaced anyways

        responseBlocks[currentBlock].gameObject.SetActive(true);
    }

    void ResponseTaken(int value)
    {
        responseBlocks[currentBlock].SetActive(false);
    }
}
