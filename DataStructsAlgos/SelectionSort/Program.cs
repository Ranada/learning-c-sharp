using AlgoLibrary;
using static AlgoLibrary.MySelectionSort;

var list = new List<int>();
SelectionSortList(list);
PrintList(list);

var list2 = new List<int>() {1, 2, 3};
SelectionSortList(list2);
PrintList(list2);

var list3 = new List<int>() {3, 1, 9, 2, 7, 10};
SelectionSortList(list3);
PrintList(list3);