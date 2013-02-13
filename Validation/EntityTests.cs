using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace Validation
{
    class Podcast : Entity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int? Test { get; set; }

        protected override void ValidateBusinessRules()
        {
            base.ValidateBusinessRules();
        }
    }

    [TestFixture]
    public class PodcastTests
    {
        [Test]
        public void Podcast_IsValid_should_return_false_when_Id_is_null()
        {
            //Arrange
            var pod = new Podcast();
            //Act
            pod.Validate();
            //Assert
            Assert.False(pod.IsValid);
        }
    }
}
