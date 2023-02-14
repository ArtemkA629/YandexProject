using UnityEngine;

public class UntieBerry : MonoBehaviour
{
    private SpringJoint2D _renderer;

    private void Start()
    {
        _renderer = GetComponent<SpringJoint2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            _renderer.enabled = false;
    }
}
