using UnityEngine;

public class traslade_cube : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
       transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
