<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
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
>>>>>>> 85d9245004b123c7024ce19faf76cb595f0ffdce
