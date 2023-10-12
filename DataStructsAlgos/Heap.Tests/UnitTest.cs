using AlgoLibrary;
using FluentAssertions;
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
            _output.WriteLine("Expected Node list length: 1. Result: {0}", heap.List.Count);
            var count = heap.List.Count;

            // Assert
            //Assert.Equal(1, count);
            count.Should().Be(1);
        }

        [Fact]
        public void New_heap_should_initialize_with_a_zero_value_in_index_zero()
        {
            // Arrange
            var heap = new Heap();

            // Act
            _output.WriteLine("Expected heap[0] = 0. Result: {0}", heap.List[0]);

            // Assert
            //Assert.Equal(0, heap.nodeList[0]);
            heap.List[0].Should().Be(0);
        }

        [Fact]
        public void Push_value_into_new_heap_should_result_in_an_integer_in_index_one()
        { 
            // Arrange
            var heap = new Heap();

            // Act
            heap.Push(99);

            // Assert
            heap.List[1].Should().Be(99);
        }

        [Fact]
        public void New_values_pushed_to_heap_should_percolate_to_top_if_less_than_parent_value()
        {
            // Arrange
            var heap = new Heap();

            // Act
            heap.Push(99);
            heap.Push(1);

            // Assert
            heap.List[1].Should().Be(1);
        }
    }
}