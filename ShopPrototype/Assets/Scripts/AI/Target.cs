using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Target : MonoBehaviour
{
    public float hp = 50f;
    public float currentHp;
    public Text hpText;
    public static float givePlayerMoney = 1000f;
    public GameObject damageEffects;

    public AudioClip soundClip;
    public AudioSource soundSource;

    void Start()
    {
        soundSource.clip = soundClip;
        if(soundSource.clip == null)
        {
            return;
        }
        hp = currentHp;
    }

    void OnGUI()
    {
        hpText.text = "HP: " + hp + "/" + currentHp.ToString();
    }

    public void TakeDamage(float amount)
    {
        currentHp -= amount;
        PlayerMoney.Money += givePlayerMoney;
        soundSource.Play();
    
        GameObject effect = (GameObject)Instantiate(damageEffects, transform.position, transform.rotation);
        Destroy(effect, 2f);
    
    
        if(currentHp <= 0f)
        {
            Destroy(gameObject);
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }

}
