using UnityEngine;

public class BerrySwinging : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) _rigidBody2D.AddForce(new Vector3(-2, 0, 0));
        else if (Input.GetKey(KeyCode.D)) _rigidBody2D.AddForce(new Vector3(2, 0, 0));
    }
}
