using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    //gun damage
    public static int damage = 10;
    //gun distance for bullet
    public float range = 10f;
    //impact value of bullet
    public float impactForce = 10f;
    [Tooltip("The higher this number is, the faster the fire rate increases." +
             " The Lower this number is, the slower it fires.")]
    public float fireRate; //fire rate for gun
    private float nextTimeToFire; //next time till the next bullet
    //the camera
    public Camera fpsCamera;
    //max ammo for clip size
    public int maxAmmo = 50;
    //how long for reload
    public float reloadTime = 5f;
    //players current ammo
    private int currentAmmo;
    //text for players current ammo
    public Text currentAmmoText;
    //is the player reloading?
    private bool isReloading = false;
    //animation
    public Animator animator;
    //impact effects (currently no effect)
    private GameObject impactEffects;

    void Start()
    {
        //players starting ammo is always the same as the max ammo
        currentAmmo = maxAmmo;
    }

    //should fix for when more than 1 weapon is implemented
    void OnEnable()
    {
        isReloading = false;
        animator.SetBool("Reloading", false);
    }

    void OnGUI()
    {
        //UI text for ammo
        currentAmmoText.text = "Ammo: " + currentAmmo + "/" + maxAmmo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //checking if the player is reloading
        if (isReloading)
        {
            return;
        }

        //if the player presses R
        if (Input.GetKeyDown(KeyCode.R))
        {
            //checks if the current ammo is the same as the max ammo
            if (currentAmmo == maxAmmo)
            {
                //return nothing if ammo is full
                return;
            }
            //start the reload coroutine
            StartCoroutine(Reload());
            return;
        }
        //checks if the ammo is less than or is 0
        if (currentAmmo <= 0)
        {
            //reload gun automatically
            StartCoroutine(Reload());
            return;
        }
        //checking if left mouse button is pushed and the next time to fire
        if (Input.GetButton("Fire1") && Time.time > nextTimeToFire)
        {
            //setting the nexttimetofire to the time +1 divided by firerate
            nextTimeToFire = Time.time + 1f / fireRate;
            //shoot the bullet
            Shoot();
            Debug.Log("FIRE!");
        }
    }
    /// <summary>
    /// Reloading the gun!
    /// Setting animation to either true and waiting a small amount of time
    /// </summary>
    /// <returns></returns>
    IEnumerator Reload()
    {
        isReloading = true;

        animator.SetBool("Reloading", true);
        Debug.Log("Reloading.");
        yield return new WaitForSeconds(reloadTime - .25f);

        animator.SetBool("Reloading", false);
        yield return new WaitForSeconds(.25f);

        currentAmmo = maxAmmo;
        isReloading = false;
    }

    //Raycasting shots
    void Shoot()
    {
        int layerMask = 1 >> 8;
        layerMask = ~layerMask;

        currentAmmo--;

        RaycastHit hitInfo;

        if (Physics.Raycast(fpsCamera.transform.position,
                            fpsCamera.transform.forward, out hitInfo, range, layerMask))
        {
            Debug.Log(hitInfo.transform.name);

            Target target = hitInfo.transform.GetComponent<Target>();
            if (target != null)
            {
                target.DamageTaken(damage);

            }

            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(hitInfo.normal * impactForce);
            }

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.green);
            GameObject impact = Instantiate(impactEffects, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            Destroy(impact, 2f);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.green);
        }

    }
}
