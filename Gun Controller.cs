using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour
{
    public Transform gunTransform;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float reloadTime = 2f;
    public float bulletSpeed = 20f;

    public int maxAmmoInMagazine = 10;
    public int totalAmmo = 50;
    private int currentAmmoInMagazine;
    private bool isReloading = false;

    void Start()
    {
        currentAmmoInMagazine = maxAmmoInMagazine;
    }

    void Update()
    {
        RotateGunToMouse();

        if (isReloading)
            return;

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }

        if (currentAmmoInMagazine <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void RotateGunToMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - gunTransform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        gunTransform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    void Shoot()
    {
        if (currentAmmoInMagazine > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint.right * bulletSpeed;
            Debug.Log("Ammo left: " + currentAmmoInMagazine);
            currentAmmoInMagazine--;
        }
        else
        {
            Debug.Log("Mag empty, reloading");
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        isReloading = false;
        
        int ammoNeeded = maxAmmoInMagazine - currentAmmoInMagazine;
        
        if (totalAmmo >= ammoNeeded)
        {
            totalAmmo -= ammoNeeded;
            currentAmmoInMagazine = maxAmmoInMagazine;
        }
        else
        {
            currentAmmoInMagazine += totalAmmo;
            totalAmmo = 0;
        }

        if (totalAmmo <= 0)
        {
            Debug.Log("No ammo left");
        }

        Debug.Log("Ammo left: " + totalAmmo);
    }
}
