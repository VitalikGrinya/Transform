using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speedScale = 0.0001f;

    void Update()
    {
        var scaleChange = new Vector3(_speedScale, _speedScale, _speedScale);

        transform.localScale += scaleChange;
    }
}
