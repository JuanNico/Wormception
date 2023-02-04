using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryTrigger : MonoBehaviour
{
    public GameObject memory;
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        memory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }
}
