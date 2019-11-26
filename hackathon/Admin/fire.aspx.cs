using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

public partial class Admin_fire : System.Web.UI.Page
{
    
    static string SubscriptionKey = Environment.GetEnvironmentVariable("COMPUTER_VISION_SUBSCRIPTION_KEY");
    static string Endpoint = Environment.GetEnvironmentVariable("COMPUTER_VISION_ENDPOINT");
    private const string ANALYZE_URL_IMAGE = "https://dkhacahton.blob.core.windows.net/dkimaginecup/msp_logo.jpg";

    public static async Task AnalyzeImageUrl(ComputerVisionClient client, string imageUrl)
    {
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("bnbn");
        Console.WriteLine();

        List<VisualFeatureTypes> features = new List<VisualFeatureTypes>()
           {
               VisualFeatureTypes.Categories, VisualFeatureTypes.Description,
               VisualFeatureTypes.Faces, VisualFeatureTypes.ImageType,
               VisualFeatureTypes.Tags, VisualFeatureTypes.Adult,
               VisualFeatureTypes.Color, VisualFeatureTypes.Brands,
               VisualFeatureTypes.Objects
           };
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        ComputerVisionClient client = Authenticate(Endpoint, SubscriptionKey);

        AnalyzeImageUrl(client, ANALYZE_URL_IMAGE).Wait();
        
    }

        public static ComputerVisionClient Authenticate(string endpoint, string key)
    {
        ComputerVisionClient client =
            new ComputerVisionClient(new ApiKeyServiceClientCredentials(key))
            { Endpoint = endpoint };
        return client;
    }

    
}