using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine.Events;

namespace Infrastructure.Factories.Interfaces
{
    public interface IEnemyFactory : IFactory
    {
        void SpawnEnemy();
    }
}
