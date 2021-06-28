using System.Collections;
using UnityEngine;

public class BlockDestroyEffect : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float effectTime = 0.8f;

    void OnEnable()
    {
        StartCoroutine(Animate());
    }

    IEnumerator Animate()
    {
        float time = effectTime;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        while(time > 0)
        {
            time -= Time.deltaTime * speed;
            renderer.material.SetFloat("_Fade", time);
            yield return new WaitForEndOfFrame();
        }

        Destroy(this.gameObject);
    }
}
