namespace FR.BusinessObjects.Models.VietQR;

public class BankingResponse
{
    public string code { get; set; }
    public string desc { get; set; }
    public QRCode data { get; set; }
}