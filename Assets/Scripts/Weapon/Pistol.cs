using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Shoot(Transform shootPoint, float delayBetweenShots)
    {
        var delayShootJob = StartCoroutine(DelayShoot(shootPoint, delayBetweenShots));
    }

    private IEnumerator DelayShoot(Transform shootPoint, float delayBetweenShots)
    {
        var waitForSeconds = new WaitForSeconds(delayBetweenShots);

        Instantiate(Bullet, shootPoint.position, Quaternion.identity);

        yield return waitForSeconds;
    }
}
