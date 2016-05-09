using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Infodinamica.Framework.Core.Extensions.IO
{
    /// <summary>
    /// Métodos utiles para streams
    /// </summary>
    public static class StreamMethods
    {
        /// <summary>
        /// Permite copiar de un stream a otro
        /// </summary>
        /// <seealso cref="http://stackoverflow.com/questions/5730863/how-to-use-stream-copyto-on-net-framework-3-5"/>
        /// <param name="input">Stream a copiar</param>
        /// <param name="output">Stream con los dos datos copiados</param>
        public static void CopyTo(this Stream input, Stream output)
        {
            byte[] buffer = new byte[16 * 1024]; // Fairly arbitrary size
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }
    }
}
