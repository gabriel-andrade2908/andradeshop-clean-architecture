using AndradeShop.Core.Domain.Helperrs.Exceptions;
using System.Text.Json;

namespace AndradeShop.Core.Infrastructure.Out.Kafta
{
    internal class KafkaTransferDataDTO<TData>
    {
        public KafkaTransferDataDTO(TData data)
        {
            Topic = typeof(TData).Name;
            try
            {
                MessageContent = JsonSerializer.Serialize(data);
            }
            catch (Exception jsonError)
            {
                throw new ApplicationCoreException($"don't possible convert '{Topic}' to json data", jsonError);
            }
        }
        public string Topic { get; set; }
        public string MessageContent { get; set; }
    }
}
