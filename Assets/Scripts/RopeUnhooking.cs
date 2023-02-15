using UnityEngine;

public class RopeUnhooking : MonoBehaviour
{
    private SpringJoint2D _springJoint2D;

    private void Start()
    {
        _springJoint2D = GetComponent<SpringJoint2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            _springJoint2D.enabled = false;
    }
}
