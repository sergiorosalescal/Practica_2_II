using UnityEngine;

public class cube_player_delta_time : MonoBehaviour
{
    public float speed;  
    
    void Update()
    {
        float movimiento_horizontal = Input.GetAxis("HorizontalArrows");
        float movimiento_vertical = Input.GetAxis("VerticalArrows");

        transform.Translate(movimiento_horizontal * speed * Time.deltaTime, movimiento_vertical * speed * Time.deltaTime, 0);
    }
}
