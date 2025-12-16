using System.Collections.ObjectModel;
using CyberPulse.App.Models;

namespace CyberPulse.App.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ObservableCollection<Article> Articles { get; } = new()
    {
        new Article
        {
            Title = "Critical RCE in widely used VPN appliance",
            Source = "CERT-FR",
            Summary = "A critical remote code execution vulnerability has been disclosed...",
            PublishedAt = DateTime.UtcNow
        },
        new Article
        {
            Title = "New ransomware group targets European hospitals",
            Source = "BleepingComputer",
            Summary = "A new ransomware operation has been observed targeting healthcare...",
            PublishedAt = DateTime.UtcNow.AddHours(-2)
        }
    };

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
}
