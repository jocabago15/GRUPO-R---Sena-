using UnityEngine;
using UnityEngine.InputSystem;

public class MoverseconAWSD : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;
        var keyboard = Keyboard.current;

        if (keyboard.wKey.isPressed)
        {
            moveDirection += Vector3.forward;
        }
        if (keyboard.sKey.isPressed)
        {
            moveDirection += Vector3.back;
        }
        

        transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World);
    }
}