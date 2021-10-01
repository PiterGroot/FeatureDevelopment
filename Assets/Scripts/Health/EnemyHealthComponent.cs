using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComponent : HealthComponent
{
    protected override void Death() {
        base.Death();
        Destroy(gameObject);
    }
    protected override void HandleTakeDamage() {
        base.HandleTakeDamage();
        //update health bar
    }
}
