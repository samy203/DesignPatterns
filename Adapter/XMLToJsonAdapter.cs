using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class XMLToJsonAdapter : IXMLToJsonAdapter
    {
        private readonly XMLConverter _xmlConverter;
        public XMLToJsonAdapter(XMLConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }
        public void Convert()
        {
            var manufacturers = _xmlConverter.GetXML()
                    .Element("Manufacturers")
                    .Elements("Manufacturer")
                    .Select(m => new Manufacturer
                    {
                        City = m.Attribute("City").Value,
                        Name = m.Attribute("Name").Value,
                    });
            new JsonConverter(manufacturers)
                .ConvertToJson();
        }
    }
}
