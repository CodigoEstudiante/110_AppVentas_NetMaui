using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AppVenta.Utilidades
{
    public class BarcodeScannedMessage : ValueChangedMessage<BarcodeResult>
    {
        public BarcodeScannedMessage(BarcodeResult value) : base(value)
        {
        }
    }
}
