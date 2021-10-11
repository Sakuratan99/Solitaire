﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public GameObject HighScorePanel;
    public Selectable[] topStacks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HasWon())
        {
            Win();
        }
    }

    public bool HasWon()
    {
        int i = 0;
        foreach (Selectable topstack in topStacks)
        {
            i += topstack.value;
        }
        if(i>= 52)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Win()
    {
        HighScorePanel.SetActive(false);
        print("You Have Won");
    }

}
