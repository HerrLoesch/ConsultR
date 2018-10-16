namespace ConsultR.Publications.Logic
{
    using System.Collections.Generic;

    using ConsultR.Publications.Data;
    using ConsultR.Publications.Interfaces;

    public class PublicationManager : IPublicationManager
    {
        public IEnumerable<Publication> GetAllPublications()
        {
            return new List<Publication>() {new Publication() {Name = "Test"}};
        }
    }
}