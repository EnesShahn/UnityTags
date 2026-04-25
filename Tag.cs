using UnityEngine;

namespace EnesShahn.Tags
{
    [DefaultExecutionOrder(-9000)]
    public abstract class Tag<T> : MonoBehaviour where T : ITag
    {
        protected virtual void Awake()
        {
            TagsService.AddInstance<T>(this);
        }

        protected virtual void OnDestroy()
        {
            TagsService.RemoveInstance<T>(this);
        }
    }
}