using UnityEngine;

public class UntieBerry : MonoBehaviour
{
    private SpringJoint2D _renderer;
    private SwingBerry _renderer2;

    private void Start()
    {
        _renderer = GetComponent<SpringJoint2D>();
        _renderer2 = GetComponent<SwingBerry>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            _renderer.enabled = false;
            _renderer2.enabled = false;
        }
    }
}
