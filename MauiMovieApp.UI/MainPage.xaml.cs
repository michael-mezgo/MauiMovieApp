using Movie = MauiMovieApp.UI.Models.Movie;

namespace MauiMovieApp.UI;

public partial class MainPage
{
    public MainPage()
    {
        StackLayout stackLayout = new()
        {
            Padding = new Thickness(5)
        };
        
        stackLayout.Children.Add(new Image
        {
            Source = "popcorn.jpg",
            Aspect = Aspect.AspectFit,
        });
        
        foreach (Movie viewModelMovie in _viewModel.Movies)
        {
            Frame movieCard = new()
            {
                BorderColor = Colors.Gray,
                CornerRadius = 10,
                Margin = new Thickness(0, 10),
                Padding = new Thickness(10),
                Content = new StackLayout
                {
                    Children =
                    {
                        new Image {
                            Source = "movie_image.png",
                            Aspect = Aspect.AspectFit
                            },
                        new Label
                        {
                            Text = viewModelMovie.Title,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = 20,
                            TextColor = Colors.Black
                        },
                        new Label
                        {
                            Text = $"{viewModelMovie.Year} | {viewModelMovie.Rating} / 10",
                            FontSize = 14,
                            TextColor = Colors.Gray
                        },
                        new Label
                        {
                            Text = $"Genre: {viewModelMovie.Genre}",
                            FontSize = 14,
                            TextColor = Colors.Gray
                        },
                        new Label
                        {
                            Text = $"Directed by: {viewModelMovie.Director}",
                            FontSize = 14,
                            TextColor = Colors.Gray
                        },
                        new Label
                        {
                            Text = $"Actors: {viewModelMovie.Actors}",
                            FontSize = 14,
                            TextColor = Colors.Gray
                        },
                        new Label
                        {
                            Text = viewModelMovie.Plot,
                            FontSize = 14,
                            TextColor = Colors.Gray
                        }
                    }
                }
            };
            stackLayout.Children.Add(movieCard);
        }

        Content = new ScrollView
        {
            Content = stackLayout
        };
    }

    private readonly MainViewModel _viewModel = new();
}