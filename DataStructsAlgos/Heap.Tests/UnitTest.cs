using AlgoLibrary;
using Xunit.Abstractions;

namespace HeapPractice.Tests
{
    public class UnitTests
    {
        private readonly ITestOutputHelper _output;

        public UnitTests(ITestOutputHelper output) 
        { 
            _output = output;
        }

        [Fact]
        public void New_heap_node_list_should_initialize_with_length_one()
        {
            // Arrange
            var heap = new Heap();

            // Act
            _output.WriteLine("Expected Node list length: 1. Result: {0}", heap.Length);

            // Assert
            Assert.Equal(1, heap.Length);
        }

        [Fact]
        public void New_heap_should_initialize_with_a_zero_value_in_index_zero()
        {
            // Arrange
            var heap = new Heap();

            // Act
            _output.WriteLine("Expected heap[0] = 0. Result: {0}", heap.nodeList[0]);
                
            // Assert
            Assert.Equal(0, heap.nodeList[0]);
        }
    }
}