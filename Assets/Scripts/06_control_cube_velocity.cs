using UnityEngine;

public class control_cube_velocity : MonoBehaviour
{
    public float velocidad;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Flecha hacia arriba pulsada. Resultado: " + (Input.GetAxis("Vertical") * velocidad));
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Flecha hacia abajo pulsada. Resultado: " + (Input.GetAxis("Vertical") * velocidad));
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("Flecha hacia la izquierda pulsada. Resultado: " + (Input.GetAxis("Horizontal") * velocidad));
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Debug.Log("Flecha hacia la derecha pulsada. Resultado: " + (Input.GetAxis("Horizontal") * velocidad));
        }
    }
}
