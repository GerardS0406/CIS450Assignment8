/*
* Gerard Lamoureux
* SortAlgorithm
* Assignment 8
* Handles the abstract sorting algorithm class
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class SortAlgorithm : MonoBehaviour
{
    protected TextMeshProUGUI sortingText;
    protected int[] sortedArray;
    public void Sort(int[] array, TextMeshProUGUI outputText)
    {
        sortingText = outputText;
        sortingText.text = "";
        Initialize();
        DoSort(array);
        sortedArray = array;
        Finish();
    }

    protected virtual void Initialize()
    {
        sortingText.text += "Starting sort!\n";
    }
    protected abstract void DoSort(int[] array);
    protected virtual void Finish()
    {
        sortingText.text += "Sorting has been completed!\n";
        sortingText.text += "Sorted array: ";
        for(int i = 0; i < sortedArray.Length; i++)
        {
            sortingText.text += sortedArray[i] + " ";
        }
    }
}
