using UnityEngine;

public class rotation_on_vertical_axis : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed = 30.0f;

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        transform.Rotate(transform.up * horizontalAxis * rotationSpeed * Time.deltaTime);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
    }

}
