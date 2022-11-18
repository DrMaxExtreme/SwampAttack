using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWave : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;
    [SerializeField] private Button _nextWaweButton;

    private void OnEnable()
    {
        foreach (var spawner in _spawners)
        {
            spawner.AllEnemySpawned += OnAllEnemySpawned;
        }

        _nextWaweButton.onClick.AddListener(OnNextWaveButtonClick);
    }

    private void OnDisable()
    {
        foreach (var spawner in _spawners)
        {
            spawner.AllEnemySpawned -= OnAllEnemySpawned;
        }

        _nextWaweButton.onClick.RemoveListener(OnNextWaveButtonClick);
    }

    public void OnAllEnemySpawned()
    {
        _nextWaweButton.gameObject.SetActive(true);
    }

    public void OnNextWaveButtonClick()
    {
        foreach (var spawner in _spawners)
        {
            spawner.NextWave();
        }

        _nextWaweButton.gameObject.SetActive(false);
    }
}
