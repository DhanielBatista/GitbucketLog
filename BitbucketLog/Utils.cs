using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitbucketLog
{
    public static class Utils
    {
        public static string GetStringFromStream(Encoding encoding, Stream stream)
        {
            var streamReader = new StreamReader(stream, encoding);
            return streamReader.ReadToEnd();
        }
    }
}
