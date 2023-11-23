using DataStructureAndAlgo.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Data Structure and Algorithms!");

# region Array Manipulation
ArrayInsertionAndDeletion arrayInsAndDel = new ArrayInsertionAndDeletion(10);
arrayInsAndDel.Insert(25, 6);
arrayInsAndDel.Insert(99, 9);
arrayInsAndDel.Insert(13, 10);
arrayInsAndDel.Insert(17, 11);
arrayInsAndDel.Delete(7);
arrayInsAndDel.Delete(0);
arrayInsAndDel.Delete(1);
arrayInsAndDel.Delete(12);
arrayInsAndDel.Insert(99, 9);
arrayInsAndDel.Delete(9);
#endregion