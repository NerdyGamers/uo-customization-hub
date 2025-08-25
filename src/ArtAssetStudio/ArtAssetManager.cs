using System.Drawing;
using Ultima;

namespace ArtAssetStudio
{
    public class ArtAssetManager
    {
        public Bitmap? GetStaticArt(int id)
        {
            return Art.GetStatic(id);
        }

        public void ReplaceStaticArt(int id, Bitmap image)
        {
            Art.ReplaceStatic(id, image);
        }

        public void RemoveStaticArt(int id)
        {
            Art.RemoveStatic(id);
        }

        public bool IsValidStatic(int id)
        {
            return Art.IsValidStatic(id);
        }

        public void Save(string path)
        {
            Art.Save(path);
        }
    }
}
