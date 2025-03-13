using GardenOfDreams.Grid.Cell.MonoBehaviours;
using UnityEngine;

namespace GardenOfDreams.Grid.ScriptableObjects
{
    [CreateAssetMenu(fileName = "World Settings", menuName = "Game/Grid")]
    public class WorldSettings : ScriptableObject
    {
        [field: SerializeField]
        public int GridSize { get; private set; }
        
        [field: SerializeField]
        public int CellSize { get; private set; }
        
        [field: SerializeField]
        public CellView CellPrefab { get; private set; }
    }
}