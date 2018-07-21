using System;
using System.Net;

namespace DownloadFile
{
    class Program
    {
        static void Main()
        {
            WebClient download = new WebClient();
            try
            {
                string fileName = "NinjaImage.png";
                Uri uri = new Uri("https://my.telerikacademy.com/content/Images/news-img01.png");
                //Нуждаем се от този клас, за да го използваме в download.DownloadFileAsync(Uri, string) метода.
                download.DownloadFileAsync(uri, fileName);
                while (download.IsBusy)
                {
                    //Този цикъл е необходим, защото иначе действащата нишка продължава без да изчака допълнителната да завърши изтеглянето.
                }
            }//This method does not block the calling thread while the resource is being downloaded.
            catch (ArgumentNullException)
            {
                Console.WriteLine("The adress or file parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("Error occurred while downloading the resource.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The local file specified by fileName is in use by another thread.");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Invalid URI.");
            }
            finally
            {
                download.Dispose();
            }

            //using (WebClient download = new WebClient())//Тази конструкция автомчтично ни освобождава ресурсите след приключване на работата
            //    try
            //    {
            //        string fileName = "NinjaImage.png";
            //        download.DownloadFile("https://my.telerikacademy.com/content/Images/news-img01.png", fileName);
            //    }//This method blocks while downloading the resource.
            //    catch (ArgumentNullException)
            //    {
            //        Console.WriteLine("The adress or file parameter is null.");
            //    }
            //    catch (WebException)
            //    {
            //        Console.WriteLine("Error occurred while downloading the resource.");
            //    }
            //    catch (NotSupportedException)
            //    {
            //        Console.WriteLine("The method has been called simultaneously on multiple thread.");
            //    }
        }
    }
}
