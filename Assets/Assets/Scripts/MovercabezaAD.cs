using UnityEngine;
using UnityEngine.InputSystem;

public class MovercabezaAD : MonoBehaviour
{
    public float rotationSpeed = 120f;

    void Update()
    {
        var keyboard = Keyboard.current;

        float rotation = 0f;

        if (keyboard.aKey.isPressed)
            rotation = -1f;

        if (keyboard.dKey.isPressed)
            rotation = 1f;

      
        transform.Rotate(Vector3.up * rotation * rotationSpeed * Time.deltaTime);
    }
}