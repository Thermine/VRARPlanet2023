using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderController : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private float timeMultiplier;

    public bool _activeSlider = false;

    public static SliderController Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
        if (_activeSlider)
        {
            FillController();
            FullSlider();
        }
        return;
    }
    public void FillController()
    {
        _activeSlider = true;
        _slider.value -= Time.deltaTime * timeMultiplier;
    }
    public void FullSlider()
    {
        if (_slider.value == 0)
        {
            
            _activeSlider = false;
            SceneManager.LoadScene(2, LoadSceneMode.Single);

        }
        return;
    }

    public void DestroyTimer()
    {
        Destroy(this.gameObject);
    }
}
