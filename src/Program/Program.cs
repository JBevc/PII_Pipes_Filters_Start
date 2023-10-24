using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
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
            provider.SavePicture(resultPicture, @"/Users/jbevc/Desktop/prog2/PII_Pipes_Filters_Start/src/Program/lukeFiltrado.jpg");
        }
    }
}
