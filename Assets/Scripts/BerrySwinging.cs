using UnityEngine;

public class BerrySwinging : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 leftPush = new Vector3(-2, 0, 0);
        Vector3 rightPush = new Vector3(2, 0, 0);
        if (Input.GetKey(KeyCode.A)) _rigidBody2D.AddForce(leftPush);
        else if (Input.GetKey(KeyCode.D)) _rigidBody2D.AddForce(rightPush);
    }
}
