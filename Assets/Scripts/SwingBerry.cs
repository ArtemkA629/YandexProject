using UnityEngine;

public class SwingBerry : MonoBehaviour
{
    private Transform _renderer;
    private Vector3 firstPosition;
    private Vector3 secondPosition;

    private void Start()
    {
        _renderer = GetComponent<Transform>();
        firstPosition = new Vector3(-1, -1.69f, 0);
        secondPosition = new Vector3(1, -1.69f, 0);
    }

    private void Update()
    {
        _renderer.position = Vector3.Lerp(firstPosition, secondPosition, Mathf.Sin(Time.timeSinceLevelLoad));
    }
}
