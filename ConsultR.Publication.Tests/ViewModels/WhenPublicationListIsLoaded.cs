namespace ConsultR.Publication.Tests.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;

    using ConsultR.Publications.Data;
    using ConsultR.Publications.Interfaces;
    using ConsultR.Publications.ViewModels;

    using DynamicSpecs.NUnit;

    using FakeItEasy;

    using FluentAssertions;
    using FluentAssertions.Events;

    using NUnit.Framework;

    using Tynamix.ObjectFiller;

    public class WhenPublicationListIsLoaded : Specifies<PublicationOverviewViewModel>
    {
        private IEnumerable<Publication> givenPublications;

        private IMonitor<PublicationOverviewViewModel> eventMonitor;

        public override void Given()
        {
            this.eventMonitor = this.SUT.Monitor();

            this.givenPublications = Randomizer<Publication>.Create(10);

            var publicationManager = this.GetInstance<IPublicationManager>();
            A.CallTo(() => publicationManager.GetAllPublications()).Returns(this.givenPublications);
        }

        public override void When()
        {
            this.SUT.Initialize();
        }

        [Test]
        public void ThenAllAvailablePublicationsShouldBeShown()
        {
            this.SUT.AvailablePublications.Should().BeSameAs(this.givenPublications);
            this.eventMonitor.Should().RaisePropertyChangeFor(x => x.AvailablePublications);
        }

        [Test]
        public void ThenTheFirstPublicationInTheListMustBeSelected()
        {
            var firstPublication = this.givenPublications.First();
            this.SUT.SelectedPublication.Name.Should().BeEquivalentTo(firstPublication.Name);
            this.SUT.SelectedPublication.Id.Should().Be(firstPublication.Id);

            this.eventMonitor.Should().RaisePropertyChangeFor(x => x.SelectedPublication);
        }
    }
}