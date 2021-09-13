using Undine.Core;

namespace Undine.MonoGame.Penumbra
{
    public class LightPositionSystem : UnifiedSystem<PenumbraLightComponent, TransformComponent>
    {
        public LightPositionSystem()
        {
        }

        public override void ProcessSingleEntity(int entityId,
            ref PenumbraLightComponent a,
            ref TransformComponent b)
        {
            a.Light.Position = b.Position;
        }
    }
}