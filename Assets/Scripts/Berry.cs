using UnityEngine;

public class Berry : MonoBehaviour
{
    private bool hooked;
    public bool Hooked => hooked;
    public Rigidbody2D RigidBody2D { get; private set; }

    private void Awake()
    {
        hooked = true;
        RigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void Hook()
    {
        hooked = true;
    }

    public void Unhook()
    {
        hooked = false;
    }
}
