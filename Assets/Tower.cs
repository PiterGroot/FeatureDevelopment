using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyInRangeChecker))]
public class Tower : MonoBehaviour
{
    [SerializeField] private int damageAmount;
    private float fireRate = 1f;
    [SerializeField] private Transform Turret;
    public bool canShoot;
    private EnemyInRangeChecker enemyInRangeChecker;
    private float nextShoottimer;
    private void Start() {
        enemyInRangeChecker = gameObject.GetComponent<EnemyInRangeChecker>();
    }
    private void Update() {
        Enemy enemy = enemyInRangeChecker.GetFirstEnemyInRange();
        if (enemy != null) {
            if (canShoot) {
                enemy.GetComponent<EnemyHealthComponent>().TakeDamage(damageAmount);
                nextShoottimer = Time.time + fireRate;
            }
        }
    }
}
