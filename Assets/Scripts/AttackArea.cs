using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public MonsterDamage nib;
public class AttackArea : MonoBehaviour

{
    private int damage = 2;

    private void OnTriggerEnter2D(Collider2D collider)
    {
      if(collider.GetComponent<health>() !- null)
        {
            health health = collider.GetComponent<health>();
        }
    }

}
