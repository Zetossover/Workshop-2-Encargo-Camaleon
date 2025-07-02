using UnityEngine;

public class CaminoCorrecto : MonoBehaviour
{
    public TuberiasRotacion[] tuberiasCamino;
    public bool Camino()
    {
        foreach(var camino in tuberiasCamino)
        {
            if (!camino.IsCorrect())
            {
                return false;
            }
        }
        return true;
    }
}
