
namespace CompAndDel
{
    public class SavePictureFilter : IFilter
    {
        public PictureProvider pictureProvider;
        private string path;

        public SavePictureFilter(string path, PictureProvider pictureProvider)
        {
            this.path = path;
            this.pictureProvider = pictureProvider;
        }

        public IPicture Filter(IPicture image)
        {
            pictureProvider.SavePicture(image, path);
            return image;  // Devuelve la imagen sin modificarla.
        }
    }

}
