using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Ucu.Poo.Twitter;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            EJERCICIO 1

            // Cargo foto en IPicture
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/luke.jpg");
            
            // PipeNull
            PipeNull pipeNull = new PipeNull();

            // FilterNegative y Pipe null: 
            // PipeSerial recibe la imagen y se la manda a FilterNegative, para luego enviarla a PipeNull
            FilterNegative filterNegative = new FilterNegative();
            PipeSerial pipeWithNegative = new PipeSerial(filterNegative, pipeNull);

            // PipeSerial y FilterGrayscale:
            // Pipe serial recibe la imagen, se la envia filter grayscale y luego a pipeWithNegative
            FilterGreyscale filterGreyscale = new FilterGreyscale();
            PipeSerial pipeWithGreyscale = new PipeSerial(filterGreyscale, pipeWithNegative);

            // Envio la foto a pipeWith grayscale para que aplique filtro negativo
            IPicture resultPicture = pipeWithGreyscale.Send(picture);

            // Guardo la imagen transformada
            provider.SavePicture(resultPicture, @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/lukefiltrado.jpg");

            
            -------------------------------------------------------------------------------------------------------------------------------------

            EJERCICIO 2

            PictureProvider provider = new PictureProvider();
            IPicture originalImage = provider.GetPicture("/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/luke.jpg");

            IFilter filterNegative = new FilterGreyscale();
            IFilter filterGreyscale = new FilterNegative();
            
            
            string intermediatePath = @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/Lukeintermediate.jpg";
            IFilter saveIntermediateFilter = new SavePictureFilter(intermediatePath, provider);

            // Aplicación de los filtros.
            IPicture negativeImage = filterNegative.Filter(originalImage);
            IPicture savedNegativeImage = saveIntermediateFilter.Filter(negativeImage); // Guarda y retorna la imagen intermedia.
            IPicture greyscaleImage = filterGreyscale.Filter(savedNegativeImage);

            // Guardado de la imagen final.
            string finalPath = @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/finalluke.jpg";
            provider.SavePicture(greyscaleImage, finalPath);

            -------------------------------------------------------------------------------------------------------------------------------------
            
            EJERCICIO 3

            PictureProvider provider = new PictureProvider();
            IPicture originalImage = provider.GetPicture("/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/luke.jpg");
            


            IFilter filterNegative = new FilterGreyscale();
            IFilter filterGreyscale = new FilterNegative();
            
            string intermediatePath = @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/Lukeintermediate.jpg";
            IFilter saveIntermediateFilter = new SavePictureFilter(intermediatePath, provider);
            
            // Aplicación de los filtros.
            IPicture negativeImage = filterNegative.Filter(originalImage);
            IPicture savedNegativeImage = saveIntermediateFilter.Filter(negativeImage); // Guarda y retorna la imagen intermedia.
            IPicture greyscaleImage = filterGreyscale.Filter(savedNegativeImage);

            // Guardado de la imagen final.
            string finalPath = @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/finalluke.jpg";
            provider.SavePicture(greyscaleImage, finalPath);
            
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("filtro 1", @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/Lukeintermediate.jpg"));
            Console.WriteLine(twitter.PublishToTwitter("filtro 2", @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/finalluke.jpg"));
            
            -------------------------------------------------------------------------------------------------------------------------------------

            EJERCICIO 4
            
            */

        }
    }
}
