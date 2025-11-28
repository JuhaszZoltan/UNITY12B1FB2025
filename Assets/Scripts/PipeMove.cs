using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float _speed = .65f;

    private void Update()
    {
        transform.position += _speed * Time.deltaTime * Vector3.left;
    }
}
