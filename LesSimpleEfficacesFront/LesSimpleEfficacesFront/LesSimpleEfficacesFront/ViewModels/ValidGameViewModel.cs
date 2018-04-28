using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LesSimpleEfficacesFront.Interfaces;
using Xamarin.Forms;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class ValidGameViewModel : BaseViewModel
    {

        #region Private Properties

        private readonly Page _page;
        private INavigation _navigation;
        private Image _image;

        private string _imageFilePath;

        private const string _subscriptionKey = "3bc000e5908249049952d169a09c9de0";
        private const string _uriBase = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/President_Barack_Obama.jpg/1200px-President_Barack_Obama.jpg";

        #endregion

        #region CTOR

        public ValidGameViewModel(INavigation navigation, Page page)
        {
            _navigation = navigation;
            _page = page;

            _imageFilePath =
                "http://md1.libe.com/photo/975697-le-president-americain-barack-obama-le-16-decembre-2016-a-la-maison-blanche-a-washington.jpg?modified_at=1483098948&width=960";

            MakeAnalysisRequest(_imageFilePath);
        }

        #endregion

        #region Properties



        #endregion

        #region Commands



        #endregion

        #region Private Functions

        private async Task<Image> TakePicture()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await _page.DisplayAlert("Erreur", "La caméra n'est pas disponible", "OK");
                return null;
            }

            MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                Directory = "HackatonDiiage",
                Name = "picGame.jpg"
            });

            if (file == null)
                return null;

            await _page.DisplayAlert("File Location", file.Path, "OK");

            _image.Source = ImageSource.FromStream(() =>
            {
                Stream stream = file.GetStream();
                return stream;
            });

            return _image;
        }

        private static async void MakeAnalysisRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);

            // Request parameters. A third optional parameter is "details".
            const string requestParameters = "visualFeatures=Categories,Description,Color&language=en";

            // Assemble the URI for the REST API Call.
            const string uri = _uriBase + "?" + requestParameters;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json" and "multipart/form-data".
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                HttpResponseMessage response = await client.PostAsync(uri, content);

                // Get the JSON response.
                string contentString = await response.Content.ReadAsStringAsync();

                // Display the JSON response.
                Console.WriteLine("\nResponse:\n");
                Console.WriteLine(DependencyService.Get<IRecognisingService>().JsonPrettyPrint(contentString));
            }
        }


        /// <summary>
            /// Returns the contents of the specified file as a byte array.
            /// </summary>
            /// <param name="imageFilePath">The image file to read.</param>
            /// <returns>The byte array of the image data.</returns>
        private static byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int) fileStream.Length);
        }
        
        
        #endregion

    }
}
