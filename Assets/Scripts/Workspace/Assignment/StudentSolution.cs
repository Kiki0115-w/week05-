using UnityEngine;
using AssignmentSystem.Services;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public void LCT01_SelectionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }

            foreach (int n1 in numbers)
            {
                Debug.Log(n1);
            }
        }

        public void LCT02_BubbleSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j]; // [..., 4, 2, ...] temp = 4
                        numbers[j] = numbers[j + 1]; // [..., 2, 2, ...] = temp = 4
                        numbers[j + 1] = temp; // [..., 2, 4, ...]
                    }
                }
            }

            foreach ( int n1 in numbers) 
            {
                Debug.Log(n1);
            }
        }

        public void LCT03_InsertionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0)
                {
                    if (key > numbers[j])
                    {
                        break;
                    } // ËÂØ´àÅ×èÍ¹

                    // àÅ×èÍ¹ä»·Ò§¢ÇÒ
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key; // á·Ã¡
            }

            foreach ( int n1 in numbers)
            {
                Debug.Log(n1);
            }

        }

        #endregion

        #region Assignment

        public void AS01_SelectionSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }

            foreach (int n1 in numbers)
            {
                Debug.Log(n1);
            }
        }

        public void AS02_BubbleSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j]; // [..., 4, 2, ...] temp = 4
                        numbers[j] = numbers[j + 1]; // [..., 2, 2, ...] = temp = 4
                        numbers[j + 1] = temp; // [..., 2, 4, ...]
                    }
                }
            }

            foreach (int n1 in numbers)
            {
                Debug.Log(n1);
            }
        }

        public void AS03_InsertionSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0)
                {
                    if (key < numbers[j])
                    {
                        break;
                    } // ËÂØ´àÅ×èÍ¹

                    // àÅ×èÍ¹ä»·Ò§¢ÇÒ
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key; // á·Ã¡
            }

            foreach (int n1 in numbers)
            {
                Debug.Log(n1);
            }
        }

        public void AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);

            int largest = numbers[0];
            int secondLargest = int.MinValue;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < largest)
                {
                    secondLargest = numbers[i];
                    break;
                }
            }

            Debug.Log(secondLargest);
        }

        #endregion

        #region Extra

        public void EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Debug.Log("The longest consecutive sequence is: 0");
                return;
            }

            Array.Sort(numbers);
            int longest = 1;
            int currentStreak = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    continue;
                }
                if (numbers[i] == numbers[i - 1] + 1)
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1;
                }
                longest = Math.Max(longest, currentStreak);
            }

            Debug.Log($"The longest consecutive sequence is: {longest}");
        }

        #endregion
    }
}