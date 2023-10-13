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

        [Fact]
        public void Popping_empty_heap_should_return_null()
        {
            // Arrange
            var heap = new Heap();

            // Act
            int? minVal = heap.Pop();

            // Assert
            minVal.Should().Be(null);
        }

        [Fact]
        public void Popping_heap_with_one_value_should_return_that_value()
        {
            // Arrange
            var heap = new Heap();
            heap.Push(99);

            // Act
            int? minVal = heap.Pop();

            // Assert
            minVal.Should().Be(99);
        }

        [Fact]
        public void Popping_heap_with_more_than_two_values_will_return_the_minimum_value()
        {
            // Arrange
            var heap = new Heap();
            heap.Push(99);
            heap.Push(1);
            heap.Push(22);

            // Act
            int? minVal = heap.Pop();

            // Assert
            minVal.Should().Be(1);
        }

        [Fact]
        public void Popping_heap_with_more_than_two_values_will_place_the_next_min_value_at_index_one()
        {
            // Arrange
            var heap = new Heap();
            heap.Push(99);
            heap.Push(1);
            heap.Push(77);
            heap.Push(22);
            heap.Push(55);

            // Act
            int? minVal = heap.Pop();

            // Assert
            heap.List[1].Should().Be(22);
        }
    }
}