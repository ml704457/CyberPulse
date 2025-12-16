using System.Collections.ObjectModel;
using CyberPulse.App.Models;
using CyberPulse.App.Services;

namespace CyberPulse.App.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly RssFeedService _rssService = new();

    public ObservableCollection<Article> Articles { get; } = new();

    private Article? _selectedArticle;
    public Article? SelectedArticle
    {
        get => _selectedArticle;
        set
        {
            _selectedArticle = value;
            OnPropertyChanged();
        }
    }

    public async Task LoadAsync()
    {
        Articles.Clear();

        var items = await _rssService.LoadAsync(
            "https://www.cert.ssi.gouv.fr/feed/"
        );

        foreach (var item in items)
            Articles.Add(item);
    }
}
