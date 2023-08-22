using AppVenta.DTOs;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.Utilidades
{
    class ProductoVentaMessage : ValueChangedMessage<ProductoDTO>
    {
        public ProductoVentaMessage(ProductoDTO value) : base(value)
        {
        }
    }
}
