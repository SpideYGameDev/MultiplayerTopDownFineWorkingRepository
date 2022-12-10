using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public VectorValue playerStorage;
    public Vector2 playerPosition;
    public string sceneToLoad;
    public bool loadSceneAtStart = false;
    private void Start()
    {
        Transform player = GameObject.FindWithTag("Player").transform;
        if(loadSceneAtStart)
        {
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);   
        }
        else
        {
            player.position = playerStorage.initialValue;
        }
    }

    private void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);   
        }
    }
}