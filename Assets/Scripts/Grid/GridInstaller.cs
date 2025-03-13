using GardenOfDreams.Extensions;
using GardenOfDreams.Grid.ScriptableObjects;
using UnityEngine;
using Zenject;

namespace GardenOfDreams.Grid
{
    public class GridInstaller : MonoInstaller
    {
        [SerializeField] private WorldSettings _worldSettings;

        public override void InstallBindings()
        {
            Container.BindScriptableObject(_worldSettings);
        }
    }
}