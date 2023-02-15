using UnityEngine;

public class StickRope : MonoBehaviour
{
    private DistanceJoint2D _renderer;
    private Transform _transform;
    private GameObject ropeEnd;
    private DistanceJoint2D ropeEndRenderer;
    private Transform ropeEndTransform;

    private void Start()
    {
        _renderer = GetComponent<DistanceJoint2D>();
        _transform = GetComponent<Transform>();
        ropeEnd = GameObject.Find("RopeEnd");
        ropeEndRenderer = ropeEnd.GetComponent<DistanceJoint2D>();
        ropeEndTransform = ropeEnd.GetComponent<Transform>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(_transform.position, ropeEndTransform.position);
        if (!_renderer.enabled && distance <= 0.2f) ropeEndRenderer.enabled = true;
    }
}
