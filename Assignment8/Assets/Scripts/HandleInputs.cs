/*
* Gerard Lamoureux
* HandleInputs
* Assignment 8
* Handles the inputs from the user to then call the sorting algorithms
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HandleInputs : MonoBehaviour
{
    public TMP_InputField inputField;

    public TextMeshProUGUI outputText;

    private BubbleSort bubbleSort = new BubbleSort();

    private QuickSort quickSort = new QuickSort();

    private int[] GetNumberArray()
    {
        string[] _nums = inputField.text.Split(",");
        int[] _array = new int[_nums.Length];
        for (int i = 0; i < _nums.Length; i++)
            _array[i] = int.Parse(_nums[i]);
        return _array;

    }
    public void QuickSort()
    {
        quickSort.Sort(GetNumberArray(), outputText);
    }

    public void BubbleSort()
    {
        bubbleSort.Sort(GetNumberArray(), outputText);
    }
}
