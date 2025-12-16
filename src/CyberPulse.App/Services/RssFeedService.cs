using System.ServiceModel.Syndication;
using System.Xml;
using CyberPulse.App.Models;

namespace CyberPulse.App.Services;

public class RssFeedService
{
    public async Task<List<Article>> LoadAsync(string feedUrl)
    {
        return await Task.Run(() =>
        {
            using var reader = XmlReader.Create(feedUrl);
            var feed = SyndicationFeed.Load(reader);

            return feed.Items.Select(item => new Article
            {
                Title = item.Title.Text,
                Source = feed.Title.Text,
                Summary = item.Summary?.Text ?? "",
                PublishedAt = item.PublishDate.DateTime,
                Url = item.Links.FirstOrDefault()?.Uri.ToString() ?? ""
            }).ToList();
        });
    }
}
