using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
  [SerializeField]string _nextLevelName;
  
  MonsterP[] _monsters;
  
  void OnEnable()
  {
      _monsters = FindObjectsOfType<MonsterP>();
  }



    // Update is called once per frame
    void Update()
    {
     if (MonstersAreAllDead())
            GoToNextLevel();
    }
    void GoToNextLevel()
    {
        Debug.Log ("Go To Level" + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

    bool MonstersAreAllDead()
    {
        foreach (var MonsterP in _monsters)
        {   
            if (MonsterP.gameObject.activeSelf)
            return false;
        }
            return true;
    }

}
