using Microsoft.Xna.Framework;
using Penumbra;

namespace Undine.MonoGame.Penumbra
{
    public class PenumbraLightSystem //: UnifiedSystem<PenumbraLightComponent>
    {
        public PenumbraComponent Penumbra { get; private set; }
        private Color _color;

        public PenumbraLightSystem(Game game,
            Color color)
        {
            Penumbra = new PenumbraComponent(game);
            Penumbra.Initialize();
            _color = color;
        }

        public void PenumbraBeginDraw()
        {
            Penumbra.BeginDraw();
            Penumbra.Game.GraphicsDevice.Clear(_color);
        }

        public void PenumbraDraw(GameTime gameTime)
        {
            Penumbra.Draw(gameTime);
        }

        //public HullComponent CreateHulls(float meterInPixels, VelcroPhysicsComponent tBody)
        //{
        //    HullComponent HullComponent = new HullComponent();//Modify this
        //    // Create Hulls from the fixtures of the body
        //    foreach (Fixture f in tBody.Body.FixtureList)
        //    {
        //        // Creating the Hull out of the Shape (respectively Vertices) of the fixtures of the physics body
        //        Hull h = new Hull((f.Shape).GetVertices());

        //        // We need to scale the Hull according to our "MetersInPixels-Simulation-Value"
        //        h.Scale = new Vector2(meterInPixels);

        //        // A Hull of Penumbra is set in Display space but the physics body is set in Simulation space
        //        // Thats why we need to convert the simulation units of the physics object to the display units
        //        // of the Hull object
        //        h.Position = ConvertUnits.ToDisplayUnits(tBody.Body.Position);

        //        // We are adding the new Hull to our physics body hull list
        //        // This is necessary to update the Hulls in the Update method (see below)
        //        HullComponent.Hulls = new System.Collections.Generic.List<Hull>();
        //        HullComponent.Hulls.Add(h);

        //        // Adding the Hull to Penumbra
        //        Penumbra.Hulls.Add(h);
        //    }
        //    return HullComponent;
        //}
    }
}