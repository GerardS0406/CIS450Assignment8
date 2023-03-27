/*
* Gerard Lamoureux
* QuickSort
* Assignment 8
* Handles the QuickSort algorithm
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : SortAlgorithm
{
    protected override void Initialize()
    {
        sortingText.text += "Starting quick sort!\n";
    }

    protected override void DoSort(int[] array)
    {
        QuickSortRecursive(array, 0, array.Length - 1);
    }

    private void QuickSortRecursive(int[] array, int left, int right)
    {
        if(left < right)
        {
            int pivot = Partition(array, left, right);
            sortingText.text += $"Pivot: {pivot}, Left: {left}, Right: {right}\n";
            QuickSortRecursive(array, left, pivot - 1);
            QuickSortRecursive(array, pivot + 1, right);
        }
    }

    private int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        
        for(int j = left; j < right; j++)
        {
            if(array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int temp2 = array[i + 1];
        array[i + 1] = array[right];
        array[right] = temp2;

        return i + 1;
    }
}
