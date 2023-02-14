using UnityEngine;

public class UntieBerry : MonoBehaviour
{
    private SpringJoint2D _renderer;
    private DistanceJoint2D _renderer2;

    private void Start()
    {
        _renderer = GetComponent<SpringJoint2D>();
        _renderer2 = GetComponent<DistanceJoint2D>();
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
