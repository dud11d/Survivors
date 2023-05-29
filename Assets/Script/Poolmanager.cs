using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Poolmanager : MonoBehaviour
{
    public GameObject[] Prefab;

    List<GameObject>[] pools;

    void Awake()
    {
        pools = new List<GameObject>[Prefab.Length];

        for (int index = 0; index < pools.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }
    }

    public GameObject Get(int index)
    {
        GameObject select = null;
        
        foreach(GameObject item in pools[index])
        {
            if (!item.activeSelf)
            {
                select = item;
                select.SetActive(true);
                break;
            }
        }

        if(!select) {
            select = Instantiate(Prefab[index], transform);
            pools[index].Add(select);
        }

        return select;
    }

}
