using CET212_Assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

[TestClass]
public class PCQueueTests
{
    [TestMethod]
    public void EnqueueItemAndDequeueItem_WithUnboundedCapacity_ShouldSucceed()
    {
        // Arrange
        var queue = new PCQueue();

        var work1 = new Work(new ConfigRecord(), new MockJourneyFileReader());
        var work2 = new Work(new ConfigRecord(), new MockJourneyFileReader());

        // Act
        queue.enqueueItem(work1);
        queue.enqueueItem(work2);

        var dequeuedWork1 = queue.dequeueItem();
        var dequeuedWork2 = queue.dequeueItem();

        // Assert
        Assert.AreEqual(work1, dequeuedWork1);
        Assert.AreEqual(work2, dequeuedWork2);
    }

    [TestMethod]
    public void EnqueueItemAndDequeueItem_WithBoundedCapacity_ShouldSucceed()
    {
        // Arrange
        var queue = new PCQueue(capacity: 1);

        var work1 = new Work(new ConfigRecord(), new MockJourneyFileReader());
        var work2 = new Work(new ConfigRecord(), new MockJourneyFileReader());

        // Act
        queue.enqueueItem(work1);

        // Enqueuing the second item should block until the first item is dequeued
        Task.Factory.StartNew(() =>
        {
            Task.Delay(500).Wait();
            queue.enqueueItem(work2);
        });

        var dequeuedWork1 = queue.dequeueItem();
        var dequeuedWork2 = queue.dequeueItem();

        // Assert
        Assert.AreEqual(work1, dequeuedWork1);
        Assert.AreEqual(work2, dequeuedWork2);
    }

    [TestMethod]
    public void DequeueItem_WhenQueueIsEmpty_ShouldBlock()
    {
        // Arrange
        var queue = new PCQueue();

        var work = new Work(new ConfigRecord(), new MockJourneyFileReader());

        // Act
        Task.Factory.StartNew(() =>
        {
            Task.Delay(500).Wait();
            queue.enqueueItem(work);
        });

        // The dequeue should block until an item is enqueued
        var dequeuedWork = queue.dequeueItem();

        // Assert
        Assert.AreEqual(work, dequeuedWork);
    }


    //Mock class for IJourney
    private class MockJourneyFileReader : IJourneyFileReader
    {
        public Journey ReadJourneyDataFromFile(ConfigRecord configRecord)
        {
            return new Journey("Test Journey");
        }
    }
}
