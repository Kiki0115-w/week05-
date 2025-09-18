using UnityEngine;
using AssignmentSystem.Services;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

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
                    } // หยุดเลื่อน

                    // เลื่อนไปทางขวา
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key; // แทรก
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
            throw new System.NotImplementedException();
        }

        public void AS02_BubbleSortDescending(int[] numbers)
        {
            throw new System.NotImplementedException();
        }

        public void AS03_InsertionSortDescending(int[] numbers)
        {
            throw new System.NotImplementedException();
        }

        public void AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Extra

        public void EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}