using UnityEngine;

public class sphere_player : MonoBehaviour
{
    public float speed;  

    void Update()
    {
        float movimiento_horizontal = Input.GetAxis("HorizontalWASD");
        float movimiento_vertical = Input.GetAxis("VerticalWASD");

        transform.Translate(movimiento_horizontal * speed, movimiento_vertical * speed, 0);
    }
}
