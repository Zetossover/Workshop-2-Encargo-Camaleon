using UnityEngine;

public class Rotate_Scene : MonoBehaviour
{
    public Transform scene;
    public float rotateSpd;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RotateLeft();
        }
        if (Input.GetMouseButton(1))
        {
            RotateRight();
        }
    }
    void RotateLeft()
    {
        scene.Rotate(0, 0, Time.deltaTime * rotateSpd);
    }
    void RotateRight()
    {

    }
}
