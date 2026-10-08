using UnityEngine;

public class cube_player : MonoBehaviour
{
    public float speed;  
    
    void Update()
    {
        float movimiento_horizontal = Input.GetAxis("HorizontalArrows");
        float movimiento_vertical = Input.GetAxis("VerticalArrows");

        transform.Translate(movimiento_horizontal * speed, movimiento_vertical * speed, 0);
    }
}
