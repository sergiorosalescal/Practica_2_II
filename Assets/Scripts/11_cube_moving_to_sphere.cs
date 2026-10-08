using UnityEngine;

public class cube_moving_to_sphere : MonoBehaviour
{
    public Transform esfera;
    public float speed = 2.0f;

    void Update()
    {
        Vector3 moveDirection = esfera.position - transform.position;
        moveDirection.y = 0;
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
