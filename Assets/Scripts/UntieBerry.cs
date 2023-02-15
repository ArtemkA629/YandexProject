using UnityEngine;

public class UntieBerry : MonoBehaviour
{
    private DistanceJoint2D _renderer;

    private void Start()
    {
        _renderer = GetComponent<DistanceJoint2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            _renderer.enabled = false;
    }
}
