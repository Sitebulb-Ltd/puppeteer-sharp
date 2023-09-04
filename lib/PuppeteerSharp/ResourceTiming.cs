using System;
using System.Collections.Generic;
using System.Text;

namespace PuppeteerSharp
{
    /// <summary>
    /// Resource iiming events.
    /// </summary>
    public class ResourceTiming
    {
        /// <summary>
        /// Gets or sets Timing's requestTime is a baseline in seconds, while the other numbers are ticks in milliseconds relatively to this requestTime.
        /// </summary>
        public double RequestTime { get; set; }

        /// <summary>
        /// Gets or sets Started resolving proxy.
        /// </summary>
        public double ProxyStart { get; set; }

        /// <summary>
        /// Gets or sets Finished resolving proxy.
        /// </summary>
        public double ProxyEnd { get; set; }

        /// <summary>
        /// Gets or sets Started DNS address resolve.
        /// </summary>
        public double DnsStart { get; set; }

        /// <summary>
        /// Gets or sets Finished DNS address resolve.
        /// </summary>
        public double DnsEnd { get; set; }

        /// <summary>
        /// Gets or sets Started connecting to the remote host.
        /// </summary>
        public double ConnectStart { get; set; }

        /// <summary>
        /// Gets or sets Connected to the remote host.
        /// </summary>
        public double ConnectEnd { get; set; }

        /// <summary>
        /// Gets or sets Started SSL handshake.
        /// </summary>
        public double SslStart { get; set; }

        /// <summary>
        /// Gets or sets Finished SSL handshake.
        /// </summary>
        public double SslEnd { get; set; }

        /// <summary>
        /// Gets or sets Started running ServiceWorker.
        /// </summary>
        public double WorkerStart { get; set; }

        /// <summary>
        /// Gets or sets Finished Starting ServiceWorker.
        /// </summary>
        public double WorkerReady { get; set; }

        /// <summary>
        /// Gets or sets Started sending request.
        /// </summary>
        public double SendStart { get; set; }

        /// <summary>
        /// Gets or sets Finished sending request.
        /// </summary>
        public double SendEnd { get; set; }

        /// <summary>
        /// Gets or sets Time the server started pushing request.
        /// </summary>
        public double PushStart { get; set; }

        /// <summary>
        /// Gets or sets Time the server finished pushing request.
        /// </summary>
        public double PushEnd { get; set; }

        /// <summary>
        /// Gets or sets Finished receiving response headers.
        /// </summary>
        public double ReceiveHeadersEnd { get; set; }
    }
}
