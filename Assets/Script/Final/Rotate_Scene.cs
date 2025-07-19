using UnityEngine;

public class Rotate_Scene : MonoBehaviour
{
    public Transform scene;
    public float rotateSpd = 100f;
    public float maxAngle = 70f;

    private void Update()
    {
        float currentZ = scene.localEulerAngles.z;
        if (currentZ > 180f) currentZ -= 360f; // Convertimos de 0-360 a -180 a 180

        if (Input.GetMouseButton(0) && currentZ < maxAngle)
        {
            scene.Rotate(0, 0, Time.deltaTime * rotateSpd);
        }

        if (Input.GetMouseButton(1) && currentZ > -maxAngle)
        {
            scene.Rotate(0, 0, -Time.deltaTime * rotateSpd);
        }
    }
}
