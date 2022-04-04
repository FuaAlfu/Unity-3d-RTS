using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// 2022.4.2
/// </summary>
public class BuildSystem : MonoBehaviour
{
    public static BuildSystem Instance;
    public GridLayout gridLayout;

    public GameObject prefabe1;
    public GameObject prefabe2;


    [SerializeField]
    private TileBase tile;

    [SerializeField]
    private Tilemap mainTilemap;

    private Grid grid;

    
    private void Awake()
    {
        if(Instance != null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
