using UnityEngine;

public class lineController : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    [SerializeField] private Transform[] _pointTransforms;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = _pointTransforms.Length;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _pointTransforms.Length; i++)
        {
            _lineRenderer.SetPosition(i, _pointTransforms[i].position);
        }
    }
}
