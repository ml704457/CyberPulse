using System.Collections.ObjectModel;
using CyberPulse.App.Models;

namespace CyberPulse.App.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ObservableCollection<Article> Articles { get; } = new()
    {
        new Article
        {
            Title = "CERT-FR: Alerte sur une vulnérabilité critique",
            Source = "CERT-FR",
            Summary = "Une vulnérabilité critique impacte un composant largement déployé. Mesures recommandées: appliquer les correctifs et surveiller les IOC.",
            PublishedAt = DateTime.Now.AddHours(-1),
            Url = "https://www.cert.ssi.gouv.fr/"
        },
        new Article
        {
            Title = "Ransomware: nouvelle campagne ciblant les PME",
            Source = "Threat Intel",
            Summary = "Une campagne récente abuse d'identifiants compromis et de services exposés. Recommandations: MFA, durcissement RDP, sauvegardes immuables.",
            PublishedAt = DateTime.Now.AddHours(-3),
            Url = "https://example.com"
        },
        new Article
        {
            Title = "Cloud: mauvaises configurations et fuites de données",
            Source = "Security Blog",
            Summary = "Analyse des erreurs de configuration les plus fréquentes dans les stockages objets et IAM. Checklist de remédiation incluse.",
            PublishedAt = DateTime.Now.AddDays(-1),
            Url = "https://example.com"
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
