using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data_Struct
{
    internal class WebSocketClient
    {
        private ClientWebSocket _webSocket;

        public async Task Connect(string url)
        {
            _webSocket = new ClientWebSocket();
            await _webSocket.ConnectAsync(new Uri(url), CancellationToken.None);
        }

        public async Task SendMessage(string message)
        {
            var buffer = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes(message));

            Thread.Sleep(5000);
            await _webSocket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public async Task<string> ReceiveMessage()
        {
            var buffer = new ArraySegment<byte>(new byte[4096]);
            var result = await _webSocket.ReceiveAsync(buffer, CancellationToken.None);
            return System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
        }

        public async Task Close()
        {
            await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing connection", CancellationToken.None);
        }
    }
}
