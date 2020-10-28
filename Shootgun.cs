using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootgun : Weapon
{
    [SerializeField] private Bullet[] _bullet;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _bullet.Length; i++)
        {
            Instantiate(_bullet[i], shootPoint.position, _bullet[i].transform.rotation);
        }
    }
}
