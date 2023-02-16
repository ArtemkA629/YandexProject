using UnityEngine;

public class RopeHooking : MonoBehaviour
{
    private DistanceJoint2D _distanceJoint2D;
    private Berry _berryComponent;

    void Start()
    {
        _distanceJoint2D = GetComponent<DistanceJoint2D>();
        GameObject berry = _distanceJoint2D.attachedRigidbody.gameObject;
        _berryComponent = berry.GetComponent<Berry>();
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.TryGetComponent(out Berry _berryComponent) && _berryComponent.Hooked == false)
        {
            _distanceJoint2D.enabled = true;
            _berryComponent.Hook();     
        }
    }
}
