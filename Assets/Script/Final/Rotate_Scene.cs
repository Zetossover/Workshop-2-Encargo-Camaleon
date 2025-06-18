using UnityEngine;

public class Rotate_Scene : MonoBehaviour
{
    public Transform scene;
    public float rotateSpd;
    public bool rotateLeft;
    public bool rotateRight;
    public int rotateCountLeft = 0;
    public int rotateCountRight = 0;

    private void Update()
    {
        if (Input.GetMouseButton(0) && rotateLeft == true)
        {
            RotateLeft();
            rotateCountLeft++;
            rotateCountRight--;
        }
        if (Input.GetMouseButton(1) && rotateRight == true)
        {
            RotateRight();
            rotateCountRight++;
            rotateCountLeft--;
        }
        if (rotateCountLeft == 0)
        {
            rotateCountLeft = 0;
            rotateLeft = true;
        }
        if (rotateCountRight == 0)
        {
            rotateCountRight = 0;
            rotateRight = true;
        }
        if (rotateCountLeft >= 70)
        {
            rotateLeft = false;
        }
        if (rotateCountRight >= 70)
        {
            rotateRight = false;
        }
    }
    void RotateLeft()
    {
        scene.Rotate(0, 0, Time.deltaTime * rotateSpd);
    }
    void RotateRight()
    {
        scene.Rotate(0, 0, -Time.deltaTime * rotateSpd);
    }
}
