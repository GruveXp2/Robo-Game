using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RoboGame.Engine
{
    internal class Entity // en sprite som har koordinat, teksturfil, størrelse, og kanskje id i framtida
    {
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }
        private Texture2D Texture { get; set; }
        public Entity(Texture2D texture, Vector2 pos, Vector2 size) 
        {
            Position = pos;
            Texture = texture;
            Size = size;
        }

        public virtual void Update() // gjør sånn at man kan adde stuff her om man vil, feks vil en player entity ha logic her for å bevege seg
        {
            
        }

        public void Draw(SpriteBatch spriteBatch) // ikke gjør dette om du har satt entitien på en tilemap (denne draw funksjonen tegner det rett på skjermen)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, new Vector2(Size.X / 2, Size.Y / 2), Size, SpriteEffects.None, 0f);
        }
    }
}
