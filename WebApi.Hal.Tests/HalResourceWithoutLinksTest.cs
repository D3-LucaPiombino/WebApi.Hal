using System.IO;
using System.Net.Http;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace WebApi.Hal.Tests
{
    [Collection("Hal")]
    public class HalNestedResourceWithNoLinks
    {
        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void representation_get_json__with_no_links_test()
        {
            RootRepresentation resourcesRepresentation = new RootRepresentation
            {
                items = new[]
                {
                    new NoLinkRepresentation {id = "aaaaa"},
                    new NoLinkRepresentation {id = "bbbbb"}
                }
            };

            JsonHalMediaTypeFormatter mediaFormatter = new JsonHalMediaTypeFormatter() { Indent = true };
            StringContent content = new StringContent(string.Empty);

            var type = resourcesRepresentation.GetType();

            using (var stream = new MemoryStream())
            {
                mediaFormatter.WriteToStreamAsync(type, resourcesRepresentation, stream, content, null).Wait();
                stream.Seek(0, SeekOrigin.Begin);
                string serialisedResult = new StreamReader(stream).ReadToEnd();

                Approvals.Verify(serialisedResult);
            }
        }

        public class NoLinkRepresentation : Representation
        {
            public string id { get; set; }
        }

        public class RootRepresentation : Representation
        {
            public NoLinkRepresentation[] items { get; set; }
        }
    }
}