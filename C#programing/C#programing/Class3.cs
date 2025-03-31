using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class HashtableExercise : MonoBehaviour
{
    Hashtable hash = new Hashtable();
    Goblin goblin = new Goblin();
    Slime slime = new Slime();

    hash["Goblin"] = goblin;

    hash.Add("Slime", slime);
    hash.Add(1, "정수");
    hash.Add(1.2f, "실수");
    hash.Add("안녕하세요. 배진서입니다.", "문자열");

    foreach (object key in hash.Keys )
    {
        Debug.Log($"hash[{key}] = {hash[key]}");
    }   
    if ( Hashtable.ContainKey("Slime") )
    {
        Debug.Llog($"slime 키 존재");

    }
    if hash.ContainValue(goblin) )
    {
    Debug.Log($"{goblin} 값 존재");

    }
    Debug.Log($"hashtable : {Hashtable.Count}");
    Hash.Remove("Slime");
    Debug.Log($"hashtable Count : {Hashtable.Count}");
    Hashtable.Clear();
    Debug.Log($"hashtable Count : {Hashtable.Count}");
}

public class Goblin { }
public class Slime { }  