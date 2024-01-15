using FridgeAlert.Api;
using FridgeAlert.Models;

namespace FridgeAlert.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void GenerateBeerButton_Clicked(object sender, EventArgs e)
    {
        var beers = await ApiLogic.GenerateUrlRandom();

        if (beers.Count > 0)
        {
            var firstBeer = beers[0];

            // Create a new page to display beer details
            var beerDetailPage = new ContentPage
            {
                Title = firstBeer.name
            };

            // Create an image for the beer
            var beerImage = new Image
            {
                Source = firstBeer.image_url,
                HeightRequest = 200,
                Aspect = Aspect.AspectFit,
                Margin = new Thickness(0, 0, 0, 10)
            };

            // Create a label for each detail
            var nameLabel = new Label { Text = $"Name: {firstBeer.name}", FontSize = 16 };
            var descriptionLabel = new Label { Text = $"Description: {firstBeer.description}", FontSize = 16 };
            var abvLabel = new Label { Text = $"ABV: {firstBeer.abv}", FontSize = 16 };
            var imageUrlLabel = new Label { Text = $"Image URL: {firstBeer.image_url}", FontSize = 16 };

            // Add the controls to the page
            beerDetailPage.Content = new StackLayout
            {
                Children = { beerImage, nameLabel, descriptionLabel, abvLabel, imageUrlLabel },
                Padding = new Thickness(20),
                Spacing = 10
            };

            // Display the beer details page
            await Navigation.PushAsync(beerDetailPage);

           // await DisplayAlert(firstBeer.name, $"Description: {firstBeer.description}\nABV: {firstBeer.abv}\nImage URL: {firstBeer.image_url}", "OK");
        }
    }
}