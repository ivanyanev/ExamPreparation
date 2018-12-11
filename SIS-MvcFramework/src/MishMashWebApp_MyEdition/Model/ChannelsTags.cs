using MishMashWebApp_MyEdition.Model;

public class ChannelsTags
{
    public int Id { get; set; }

    public int TagId { get; set; }
    public virtual Tag Tag { get; set; }

    public int ChannelId { get; set; }
    public virtual Channel Channel { get; set; }
}