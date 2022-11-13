using Code_Quote.Modeles;
using Code_Quote.Services;
using DeepL;

namespace Code_Quote
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        private async void btnGenerateQuote_Clicked(object sender, EventArgs e)
        {
            var startColor = System.Drawing.Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            var endColor = System.Drawing.Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            var colors = ColorUtility.ColorControls.GetColorGradient(startColor, endColor, 6);

            float stopOffset = .0f;
            var stops = new GradientStopCollection();
            foreach (var c in colors)
            {
                stops.Add(new GradientStop(Color.FromArgb(c.Name), stopOffset));
                stopOffset += .2f;
            }

            var gradient = new LinearGradientBrush(stops,new Point(0,0),new Point(1,1));

            container.Background = gradient;


            var translator = new Translator("79133943-7bf5-4864-3f05-64af3b21dbc4:fx");


            Quote quote = new Quote();
            QuoteService quoteService = new QuoteService();
            quote = quoteService.GetRandomQuote().Result;
            var value = await translator.TranslateTextAsync(quote.content, LanguageCode.English, LanguageCode.French);
            lblQuote.Text = value.Text;
            lblAuthor.Text = quote.author;
        }
    }
}