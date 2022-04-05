using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.III
{
    public class ConvertFacade : IXmlConverter, IJsonCoverter, IByteArrayConverter
    {
        private IXmlConverter xmlConverter;
        private IJsonCoverter jsonCoverter;
        private IByteArrayConverter byteArrayConverter;

        public ConvertFacade(IXmlConverter xmlConverter, IJsonCoverter jsonCoverter, IByteArrayConverter byteArrayConverter)
        {
            this.xmlConverter = xmlConverter;
            this.jsonCoverter = jsonCoverter;
            this.byteArrayConverter = byteArrayConverter;
        }

        public byte[] ToByteArray()
        {
            return byteArrayConverter.ToByteArray();
        }

        public string ToJson()
        {
            return jsonCoverter.ToJson();
        }

        public string ToXml()
        {
            return xmlConverter.ToXml();
        }
    }
}
