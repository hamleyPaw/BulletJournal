using System;
using System.Configuration;
using HamleyPaw.BulletJournal.Models;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HamleyPaw.BulletJournal.Services.UnitTests
{
    [TestClass]
    public class ModelServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ModelService_CommitNewTopic_ThrowsExceptionIfTopicNull()
        {
            var mockedEntityService = new Mock<IEntityService>();

            var modelUnderTest = new ModelService(mockedEntityService.Object);

            modelUnderTest.CommitNewTopic(null);
        }

        [TestMethod]
        public void ModelService_CommitNewTopic_FailsWithExceptionIfCommitFails()
        {
            var mockedEntityService = new Mock<IEntityService>();

            var modelUnderTest = new ModelService(mockedEntityService.Object);


        }

        [TestMethod]
        public void ModelService_CommitNewTopic_SetsTopicIdIfCommitSucceeds()
        {
            var mockedEntityService = new Mock<IEntityService>();
            
            var modelUnderTest = new ModelService(mockedEntityService.Object);

            var mockedTopic = Mock.Of<ITopic>();

            modelUnderTest.CommitNewTopic(mockedTopic);

            Assert.IsNotNull(mockedTopic.TopicId);
            Assert.IsTrue(mockedTopic.TopicId > 0);
        }

    }
}
