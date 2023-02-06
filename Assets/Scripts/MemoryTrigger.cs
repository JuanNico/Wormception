using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoryTrigger : MonoBehaviour
{
    public GameObject memory;
    public GameObject character;
    public bool isEnd;
    bool startMovinOut;
    public GameObject cam, targetPos;
    // Start is called before the first frame update
    void Start()
    {
        memory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startMovinOut)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, targetPos.transform.position, 2 * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            character.GetComponent<PlayerMovement>().speed = 0;
            memory.SetActive(true);
        }
    }

    public void MemoryBtn()
    {
        character.GetComponent<PlayerMovement>().speed = 6;
        memory.SetActive(false);
        
        if (isEnd)
        {
            print("zoom out");
            startMovinOut = true;
            StartCoroutine(WaitToEnd());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    IEnumerator WaitToEnd()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2);
    }

}
