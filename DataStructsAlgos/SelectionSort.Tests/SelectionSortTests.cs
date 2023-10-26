namespace SelectionSort.Tests;
using AlgoLibrary;
using static AlgoLibrary.MySelectionSort;
using FluentAssertions;
public class SelectionSortTests
{
    [Fact]
    public void Sorting_empty_list_should_return_empy_list()
    {
        // Arrange
        var unsortedList = new List<int>();
        
        // Act
        SelectionSortList(unsortedList);
    
        // Assert
        unsortedList.Should().BeEmpty();
    }

    [Fact]
    public void Sorted_list_should_be_same_sorted_list()
    {
        // Arrange
        var unsortedList = new List<int>() {1,2,3};
        var expectedList = new List<int>() {1,2,3};
        
        // Act
        SelectionSortList(unsortedList);
    
        // Assert
        unsortedList.Should().Equal(expectedList);
    }

    [Fact]
    public void Unsorted_list_should_become_sorted_list()
    {
        // Arrange
        var unsortedList = new List<int>() {9,2,10,7,1,3};
        var expectedList = new List<int>() {1,2,3,7,9,10};
        
        // Act
        SelectionSortList(unsortedList);

        PrintList(unsortedList);
        // Assert
        unsortedList.Should().Equal(expectedList);
    }
}