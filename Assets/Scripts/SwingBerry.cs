using System.Collections;
using UnityEngine;

public class SwingBerry : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) _rigidBody.AddForce(new Vector3(-2, 0, 0));
        else if (Input.GetKey(KeyCode.D)) _rigidBody.AddForce(new Vector3(2, 0, 0));
    }
}
