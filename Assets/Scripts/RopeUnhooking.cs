using UnityEngine;

public class RopeUnhooking : MonoBehaviour
{
    private DistanceJoint2D _distanceJoint2D;
    private Berry _berryComponent;

    private void Start()
    {
        _distanceJoint2D = GetComponent<DistanceJoint2D>();
        GameObject berry = _distanceJoint2D.attachedRigidbody.gameObject;
        _berryComponent = berry.GetComponent<Berry>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            _distanceJoint2D.enabled = false;
            _berryComponent.Unhook();
        }
    }
}
