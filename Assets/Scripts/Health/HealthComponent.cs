using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    private float CurrentHealth;
    public float currenthealth {
        get { return CurrentHealth; }
    }
    [SerializeField] private float StartHealth;

    private void Awake() {
        CurrentHealth = StartHealth;
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            TakeDamage(1);
        }
    }
    public void TakeDamage(int damageAmount) {
        CurrentHealth -= damageAmount;
        HandleTakeDamage();
        if(CurrentHealth <= 0) {
            Death();
        }
    }
    protected virtual void HandleTakeDamage() {
        print("DAMAGE");
    }
    protected virtual void Death() {
        print("Im dead");
    }
}
