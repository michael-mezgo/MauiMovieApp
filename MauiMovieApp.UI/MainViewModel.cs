using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiMovieApp.UI.Models;

namespace MauiMovieApp.UI;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Movie> _movies;

    public MainViewModel()
    {
        _movies = new ObservableCollection<Movie>();
        foreach (Movie movie in Movie.GetMovies())
        {
            _movies.Add(movie);
        }
    }
}