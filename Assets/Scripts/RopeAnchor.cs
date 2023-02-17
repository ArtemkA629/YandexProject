using UnityEngine;

public class RopeAnchor : MonoBehaviour
{
    private DistanceJoint2D _distanceJoint2D;
    private Berry _berry;

    private void Awake()
    {
        _distanceJoint2D = GetComponent<DistanceJoint2D>();
        if (_distanceJoint2D.connectedBody != null && 
            _distanceJoint2D.connectedBody.TryGetComponent(out Berry berry))
            _berry = berry;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            _berry.Unhook();
            _distanceJoint2D.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.TryGetComponent(out Berry berry) && berry.Hooked == false)
        {
            _berry = berry;
            _berry.Hook();
            _distanceJoint2D.connectedBody = _berry.RigidBody2D;
            _distanceJoint2D.enabled = true;
        }
    }
}
