using System;
using Ucu.Poo.Twitter;
namespace CompAndDel
{
    public class TwitterPublisher : IFilter
    {
        private string text;
        
        public TwitterPublisher(string text)
        {
            this.text = text;
        }

        public IPicture Filter(IPicture image)
        {
            // Convertir la IPicture a un archivo temporal para publicar
            string tempFilePath = System.IO.Path.GetTempFileName() + ".png";
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, tempFilePath);

            // Publicar en Twitter
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(this.text, tempFilePath));

            // Eliminar el archivo temporal (opcional pero recomendado)
            System.IO.File.Delete(tempFilePath);

            // Devolver la imagen original, sin modificaciones
            return image;
        }
    }
}
