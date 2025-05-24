using UnityEngine;

public class SettearNubes : MonoBehaviour
{
    [SerializeField] GameObject nubes, sol;
    [SerializeField] Transform[] spawn;
    public Transform solSpawn;
    void Start()
    {
        InstanciarNubes();
        InstanciarSol();
    }
    void InstanciarNubes()
    {
        for (int i = 0; i < spawn.Length; i++)
        {
            int index = i;
            if (spawn.Length >= i)
            {
                Instantiate(nubes, spawn[i].position, Quaternion.identity);
            }
        }
    }
    void InstanciarSol()
    {
        Instantiate(sol, solSpawn.position, Quaternion.identity);
    }
}    