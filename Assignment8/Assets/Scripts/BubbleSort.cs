using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : SortAlgorithm
{
    protected override void Initialize()
    {
        sortingText.text += "Starting Bubble Sort!\n";
    }

    protected override void DoSort(int[] array)
    {
        for(int i=0; i<array.Length-1; i++)
        {
            for(int j=0; j<array.Length - 1 - i; j++)
            {
                sortingText.text += $"Comparing {array[j]} and {array[j+1]}...\n";
                if(array[j] > array[j+1])
                {
                    sortingText.text += $"Swapping {array[j]} and {array[j + 1]}...\n";
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
