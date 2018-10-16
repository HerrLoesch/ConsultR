namespace ConsultR.Publications.Interfaces
{
    using System.Collections.Generic;

    using ConsultR.Publications.Data;

    public interface IPublicationManager
    {
        IEnumerable<Publication> GetAllPublications();
    }
}