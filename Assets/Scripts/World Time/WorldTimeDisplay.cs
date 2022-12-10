using TMPro;
using UnityEngine;
using System;
[RequireComponent(typeof(TMP_Text))]
public class WorldTimeDisplay : MonoBehaviour
{

    [SerializeField]
    private WorldTime _worldTime;
    private TMP_Text _text;

    void Start()
    {
      
    }

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        _worldTime.WorldTimeChanged += OnWorldTimeChanged;    
    }

    private void OnDestroy()
    {
                _worldTime.WorldTimeChanged -= OnWorldTimeChanged;    
    }
    private void OnWorldTimeChanged(object sender, TimeSpan newTime)
    {
        _text.SetText("DAY" + " " + newTime.ToString("%d") + " " + newTime.ToString(@"hh\:mm"));
    }
    
}
