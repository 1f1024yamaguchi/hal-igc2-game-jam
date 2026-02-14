using UnityEngine;


public class DeathEffect : MonoBehaviour
{
    [SerializeField] private GameObject deathEffectPrefab; // 死亡エフェクトのプレハブ
    [SerializeField] private AudioClip deathSE; // 死亡時のサウンドエフェクト
    [SerializeField] private float volume = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void PlayEffect()
    {
        if (deathEffectPrefab != null)
        {
            Instantiate(deathEffectPrefab, transform.position, Quaternion.identity);
        }

        if (deathSE != null)
        {
            AudioSource.PlayClipAtPoint(deathSE, transform.position, volume);
        }
    }

}
