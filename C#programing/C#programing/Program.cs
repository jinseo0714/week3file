using System.Collections;
using System.Collections.ObjectModel;
using UnityEngine;

public class AraayListExercise : MonoBehaviour
{
    private void Awake()
    {
        ArrayList arraylist = new.ArrayList();
        Debug log(ArrayList.add(10));
        PrintArrayList(arraylist);
        arraylist.Insert(1, 100);
        PrintArrayList(arraylist);

        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arraylist.Sort()
        PrintArrayList(arraylist);
        arraylist.Remove(10);
        PrintArrayList(arraylist);
        arraylist.Remove(0);
        PrintArrayList(arraylist);
        PrintArrayList(arraylist);
        arraylist.RemoveRange(0, 2);
        PrintArrayList(arraylist);
        arraylist.Clear();
        Debug.Log(arraylist.Count);
    }
}
public void PrintArrayList(ArrayList list)
{
    Debug,Log("========================");

    for (int i = 0; i < list.Count; ++ i )
    {
        Debug.Log($"lsit[{i}] = {list[i]}");

    }
}