using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : WeaponClass
{
    private styleScriptTwo style;
    private void Awake()
    {
        style = GameObject.FindGameObjectWithTag("Player").GetComponent<styleScriptTwo>();
    }
    public Bottle()
    {
        type = WeaponType.BOTTLE;
    }

    public override void LeftClick()
    {
        Throw();
    }

    public override void RightClick()
    {
        Throw();
    }

    public override void ThrowInteractions(Collider2D collision)
    {
        
        if (collision.CompareTag("Enemy"))
        {
            style.enemyStun();
            Debug.Log("collide with enemy");
            rb.velocity = (-rb.velocity).normalized * 1;
        }
    }
}
