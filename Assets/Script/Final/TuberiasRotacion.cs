using UnityEngine;

public class TuberiasRotacion : MonoBehaviour
{
    public float rotacionCorrecta = 0f;

    public bool IsCorrect()
    {
        return Mathf.Approximately(transform.eulerAngles.z, rotacionCorrecta);
    }
}
