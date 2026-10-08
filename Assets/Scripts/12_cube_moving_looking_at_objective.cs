using UnityEngine;

public class cube_moving_looking_at_objective : MonoBehaviour
{
    public Transform esfera;
    public float speed = 5.0f;

    void Update()
    {
        Vector3 moveDirection = esfera.position - transform.position;
        moveDirection.y = 0;
        transform.LookAt(esfera);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
