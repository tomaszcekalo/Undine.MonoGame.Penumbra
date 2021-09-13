using Penumbra;
using Undine.Core;

namespace Undine.MonoGame.Penumbra
{
    public class HullSystem : UnifiedSystem<HullComponent, TransformComponent>
    {
        public override void ProcessSingleEntity(int entityId,
            ref HullComponent a, ref TransformComponent b)
        {
            foreach (Hull h in a.Hulls)
            {
                h.Rotation = b.Rotation;
                h.Position = b.Position;
            }
        }
    }
}