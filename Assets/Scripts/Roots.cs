using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roots : MonoBehaviour{

    int rootCapacity = 5;
    int currentRootSelection = 0;
    [SerializeField] List<Sprite> fadeRootsPrefabs;
    [SerializeField] List<GameObject> realRootsPrefabs;
    [SerializeField] SpriteRenderer rootRend;

    void Update() {
        
        if(Input.GetKeyDown(KeyCode.R)){

            currentRootSelection++;
            if(currentRootSelection == fadeRootsPrefabs.Count){
                currentRootSelection = 0;
            }
            
            rootRend.sprite = fadeRootsPrefabs[currentRootSelection];
        }

        if(Input.GetKeyDown(KeyCode.E) && rootCapacity > 0){

            GameObject go = Instantiate(realRootsPrefabs[currentRootSelection]);
            go.transform.position = this.transform.position;
        }
    }
}