using UnityEngine;

public class Rotacion90Grados : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.Rotate(0, 0, -90);
    }
}
