using System;
using StackAndQueue.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestStackPush()
        {
            Stack s = new Stack();
            s.Push(1);

            Assert.Equal(1, s.Peek().Value);
        }

        [Fact]
        public void TestQueueEnqueue()
        {
            Queue q = new Queue();
            q.Enqueue(1);

            Assert.Equal(1, q.Peek().Value);
        }

        [Fact]
        public void TestStackPopAndEmptyAfter()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Pop();

            Assert.Null(s.Peek());
        }

        [Fact]
        public void TestQueueDequeueAndEmptyAfter()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Dequeue();

            Assert.Null(q.Peek());
        }

        [Fact]
        public void TestStackPop()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Pop();

            Assert.Equal(1, s.Peek().Value);
        }

        [Fact]
        public void TestQueueDequeue()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Dequeue();

            Assert.Equal(2, q.Peek().Value);
        }

        [Fact]
        public void TestStackPushMultiple()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);

            Assert.Equal(2, s.Peek().Value);
        }

        [Fact]
        public void TestQueueEnqueueMultiple()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);

            Assert.Equal(1, q.Peek().Value);
        }

        [Fact]
        public void TestStackPeek()
        {
            Stack s = new Stack();
            s.Push(1);

            Assert.Equal(1, s.Peek().Value);
        }

        [Fact]
        public void TestQueuePeek()
        {
            Queue q = new Queue();
            q.Enqueue(1);

            Assert.Equal(1, q.Peek().Value);
        }

        [Fact]
        public void TestStackEmpty()
        {
            Stack s = new Stack();

            Assert.Null(s.Peek());
        }

        [Fact]
        public void TestQueueEmpty()
        {
            Queue q = new Queue();

            Assert.Null(q.Peek());
        }

        [Fact]
        public void TestStackQueueEnqueue()
        {
            Queue q = new Queue();
            q.StackEnqueue(1);

            Assert.Equal(1, q.StackPeek().Value);
        }

        [Fact]
        public void TestStackQueueDequeueAndEmptyAfter()
        {
            Queue q = new Queue();
            q.StackEnqueue(1);
            q.StackDequeue();

            Assert.Null(q.StackPeek());
        }

        [Fact]
        public void TestStackQueueDequeue()
        {
            Queue q = new Queue();
            q.StackEnqueue(1);
            q.StackEnqueue(2);
            q.StackDequeue();

            Assert.Equal(2, q.StackPeek().Value);
        }

        [Fact]
        public void TestStackQueueEnqueueMultiple()
        {
            Queue q = new Queue();
            q.StackEnqueue(1);
            q.StackEnqueue(2);

            Assert.Equal(1, q.StackPeek().Value);
        }

        [Fact]
        public void TestStackQueuePeek()
        {
            Queue q = new Queue();
            q.StackEnqueue(1);

            Assert.Equal(1, q.StackPeek().Value);
        }

        [Fact]
        public void TestStackQueueEmpty()
        {
            Queue q = new Queue();

            Assert.Null(q.StackPeek());
        }
    }
}
