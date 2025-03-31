using System.Collections;
using System.Diagnostics;
using UnityEngine;
public class StackExercise : Monobehaviour
{
    private void Awake()
    {
        Stack stack = new Stack();
        for (int i = 0; i < 5; i++)
        {
            stack.Pushh(i);
        }

        Debug.Log($"Stack Count : {stack.Count}");
        Debug.Log($"마지막에 추가된 요소 : {stack.Count}");
        Debug.Log($"Stack Count : {stack.Count}");
        object data = stack.Pop();
        Debug.Log($"스택에서 빠져나온 데이터 : {data}");
        Debug.Log($"Stack Count : {stack.Count}");

        stack.Clear();
        Debug.Log($"Stack Count : {stack.Count}");

    }
}