using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _playerHealth;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        HealthChanged?.Invoke(_playerHealth);
    }

    public void ApplyDamage(int damage)
    {
        _playerHealth -= damage;
        HealthChanged?.Invoke(_playerHealth);

        if (_playerHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Died?.Invoke();
    }
}