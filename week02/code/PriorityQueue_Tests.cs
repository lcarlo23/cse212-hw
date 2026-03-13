using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: An item is being added to the queue correctly
    // Expected Result: [Bob (Pri:2), Tim (Pri:1), Sue (Pri:3)]
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 3);

        string expectedList = "[Bob (Pri:2), Tim (Pri:1), Sue (Pri:3)]";

        Assert.AreEqual(expectedList, priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: The item with highest priority is being dequeued first
    // Expected Result: Sue
    // Defect(s) Found: The loop to find the highest priority skipped the last enqueued item because loop condition was index < _queue.Count - 1, it should be <= _queue.Count -1 or < _queue.Count instead
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 3);

        var dequeuedItem = priorityQueue.Dequeue();

        string expectedItem = "Sue";

        Assert.AreEqual(expectedItem, dequeuedItem);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: The item with highest priority and first in queue is being dequeued first
    // Expected Result: Tim
    // Defect(s) Found: The dequeue function returns last item added even if it has the same priority of another added first, the comparison should check only if there are higher priority items
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 3);

        var dequeuedItem = priorityQueue.Dequeue();

        string expectedItem = "Tim";

        Assert.AreEqual(expectedItem, dequeuedItem);
    }

    [TestMethod]
    // Scenario: If the queue is empty an error exception should be thrown
    // Expected Result: The message "The queue is empty" should be displayed
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            var dequeuedItem = priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}