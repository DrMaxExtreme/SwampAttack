using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Shotgun : Weapon
{
    public override void Charge(List<Transform> shootPoints)
    {
        foreach (var shootPoint in shootPoints)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        }
    }
}
