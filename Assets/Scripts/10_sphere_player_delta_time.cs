using UnityEngine;

public class sphere_player_delta_time : MonoBehaviour
{
    public float speed;  

    void Update()
    {
        float movimiento_horizontal = Input.GetAxis("HorizontalWASD");
        float movimiento_vertical = Input.GetAxis("VerticalWASD");

        transform.Translate(movimiento_horizontal * speed * Time.deltaTime, movimiento_vertical * speed * Time.deltaTime, 0);
    }
}