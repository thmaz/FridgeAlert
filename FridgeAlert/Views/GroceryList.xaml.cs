using FridgeAlert.Api;


namespace FridgeAlert.Views;

public partial class GroceryList : ContentPage
{
    public GroceryList()
    {
        InitializeComponent();
    }

    private async void GenerateBeerButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            var beers = await ApiLogic.GenerateUrlRandom();

            if (beers.Count > 0)
            {
                var firstBeer = beers[0];

                var beerDetailPage = new ContentPage
                {
                    Title = firstBeer.name
                };

                var beerImage = new Image
                {
                    Source = firstBeer.image_url,
                    HeightRequest = 200,
                    Aspect = Aspect.AspectFit,
                    Margin = new Thickness(0, 0, 0, 10)
                };

                var nameLabel = new Label { Text = $"Name: {firstBeer.name}", FontSize = 16 };
                var descriptionLabel = new Label { Text = $"Description: {firstBeer.description}", FontSize = 16 };
                var abvLabel = new Label { Text = $"ABV: {firstBeer.abv}", FontSize = 16 };
                var imageUrlLabel = new Label { Text = $"Image URL: {firstBeer.image_url}", FontSize = 16 };

                beerDetailPage.Content = new StackLayout
                {
                    Children = { beerImage, nameLabel, descriptionLabel, abvLabel, imageUrlLabel },
                    Padding = new Thickness(20),
                    Spacing = 10
                };

                await Navigation.PushAsync(beerDetailPage);

                // await DisplayAlert(firstBeer.name, $"Description: {firstBeer.description}\nABV: {firstBeer.abv}\nImage URL: {firstBeer.image_url}", "OK");
            }
            else
            {
                await DisplayAlert("Error", "No beer data available", "Ok");
            }
        } catch (Exception ex)
        {
            await DisplayAlert("Error", $"An error occurred: {ex.Message}", "Ok");
        }
    }
}