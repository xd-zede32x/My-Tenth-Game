using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speedEnemy;

    private void Update()
    {
        transform.Translate(Vector3.left * _speedEnemy * Time.deltaTime);
    }
}