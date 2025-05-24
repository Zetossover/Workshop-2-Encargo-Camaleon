using System.Collections.Generic;
using UnityEngine;

public class Settear_Objetos : MonoBehaviour
{
    [SerializeField] GameObject objetos;
    [SerializeField] Transform[] spawn;
    void Start()
    {
        InstanciarNubes();
    }
    void InstanciarNubes()
    {
        for (int i = 0; i < spawn.Length; i++)
        {
            int index = i;
            if (spawn.Length >= i)
            {
                Instantiate(objetos, spawn[i].position, Quaternion.identity);

            }
        }
    }
   
}
