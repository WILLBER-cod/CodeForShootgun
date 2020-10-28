using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootgun : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < Bullet.Length; i++)
        {
            Instantiate(Bullet[i], shootPoint.position, Bullet[i].transform.rotation);
        }
    }
}
