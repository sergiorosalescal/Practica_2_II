using UnityEngine;

public class move_objects_with_marker : MonoBehaviour
{
    public Vector3 desplazamiento;
    private Vector3 posicionInicial;

    void Start()
    {        
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (Input.GetAxis("Jump") > 0.0f)
        {
            transform.position = posicionInicial + desplazamiento;
        }
    }
}