using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{
    public SpriteRenderer[] sprites;
    public Color[] colors;
    public Color[] secondColors;
    public Color[] vignetteColors;
    public int id;
    bool startchanging;
    public AudioSource music;
    public AudioClip[] levelSongs;
    [SerializeField] int time;
    // Start is called before the first frame update
    void Start()
    {
        startchanging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startchanging)
        {
            print("coloreate");
            sprites[0].color = Color.Lerp(sprites[0].color, colors[id], time * Time.deltaTime);
            sprites[1].color = Color.Lerp(sprites[1].color, secondColors[id], time * Time.deltaTime);
            sprites[2].color = Color.Lerp(sprites[2].color, vignetteColors[id], time * Time.deltaTime);
            StartCoroutine(WaitToChange());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            music.Stop();
            music.clip = levelSongs[id];
            music.Play();
            startchanging = true;
        }
    }

    IEnumerator WaitToChange()
    {
        yield return new WaitForSeconds(10);
        startchanging = false;
    }
}
