using UnityEngine;

public class Berry : MonoBehaviour
{
    private bool hooked;
    public bool Hooked => hooked;

    private void Awake()
    {
        hooked = false;
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
