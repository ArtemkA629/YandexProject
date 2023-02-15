using UnityEngine;

public class RopeUnhooking : MonoBehaviour
{
    private DistanceJoint2D _distanceJoint2D;

    private void Start()
    {
        _distanceJoint2D = GetComponent<DistanceJoint2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            _distanceJoint2D.enabled = false;
    }
}
