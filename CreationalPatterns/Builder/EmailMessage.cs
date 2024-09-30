namespace CreationalPatterns.Builder;

public class EmailMessage
{
    public List<EmailAddress> To { get;   private set;}
    public EmailAddress Sender { get;  private set;}
    public List<EmailAddress> Bcc { get; private set;}
    public List<EmailAddress> Cc { get; private set;}
    public string Subject { get;  private set;}
    public string Body { get;  private set;}
    public string ContentType { get;  private set;}

    public static ISender Builder()
    {
        return new EmailMessageBuilder();
    }

    

    public override string ToString()
    {
        return
            $"{nameof(To)}: {To}, {nameof(Sender)}: {Sender}, {nameof(Bcc)}: {Bcc}, {nameof(Cc)}: {Cc}, {nameof(Subject)}: {Subject}, {nameof(Body)}: {Body}, {nameof(ContentType)}: {ContentType}";
    }

    private EmailMessage(List<EmailAddress> to, EmailAddress sender, List<EmailAddress> bcc, List<EmailAddress> cc, string subject, string body, string contentType)
    {
        To = to;
        Sender = sender;
        Bcc = bcc;
        Cc = cc;
        Subject = subject;
        Body = body;
        ContentType = contentType;
    }
    
    public interface ISender
    {
        ITo Sender(EmailAddress sender);
    }
    
    public interface ITo
    {
        EmailMessageBuilder AddTo(EmailAddress to);
    }

    public class EmailMessageBuilder: ISender, ITo
    {
        private List<EmailAddress> _to = new List<EmailAddress>();
        private List<EmailAddress>? _cc = null;
        private EmailAddress _sender;
        private string? _subject;
        private string? _body;
        private string? _contentType;

        public EmailMessageBuilder()
        {
            
        }

        public ITo Sender(EmailAddress sender)
        {
            _sender = sender;
            return this;
        }

        public EmailMessageBuilder Subject(string subject)
        {
            _subject = subject;
            return this;
        }

        public EmailMessageBuilder AddCc(EmailAddress cc)
        {
            if (_cc == null)
            {
                _cc = new();
            }
            _cc.Add(cc);
            return this;
        }

        public EmailMessage Build()
        {
            return new EmailMessage(_to, _sender, null,null, _subject, _body, _contentType);
        }

        public EmailMessageBuilder AddTo(EmailAddress to)
        {
            if (_to == null)
            {
                _to = new();
            }
            _to.Add(to);
            return this;
        }
    }
}