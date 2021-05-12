namespace Quantum._10_Demo_Array_Functions {

    open Microsoft.Quantum.Canon;
    // Import this library to use Range Functions.
    open Microsoft.Quantum.Core;
    open Microsoft.Quantum.Intrinsic;
    // Import this library to work with Arrays.
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Convert as Convert;

    
    @EntryPoint()
    operation Demo_Array_Functions () : Unit {
        // Arrays start from 0th index.
        mutable arr = [10, 11, 36, 49];
        for i in IndexRange(arr)
        {
            Message(Convert.IntAsString(arr[i]));
        }

        // Appending two arrays.
        set arr = arr + [40, 50];
        for i in IndexRange(arr)
        {
            Message(Convert.IntAsString(arr[i]));
        }

        // Head returns the first element of the array.
        Message("Head of the array: " + Convert.IntAsString(Head(arr)));

        // Tail returns the last element of the array.
        Message("Tail of the array: " + Convert.IntAsString(Tail(arr)));

        // Rest returns a new array by skipping the first element
        Message("Rest Demo:");
        mutable restArr = Rest(arr);
        Message("Head of the Rest array: " + Convert.IntAsString(Head(restArr)));
        for i in IndexRange(restArr)
        {
            Message(Convert.IntAsString(restArr[i]));
        }

        // Subarray picks only the items mentioned as indexes in the first array.
        Message("Subarray Demo:");
        mutable newSubArr = Subarray([2, 3, 0], arr);
        for i in IndexRange(newSubArr)
        {
            Message(Convert.IntAsString(newSubArr[i]));
        }

        // Reverse Array Demo.
        Message("Reverse Array Demo:");
        mutable reverseArr = Reversed(arr);
        for i in IndexRange(reverseArr)
        {
            Message(Convert.IntAsString(reverseArr[i]));
        }

        // Range Demo
        // The three integers indicate start..step..stop. The default value of step is 1.
        Message("Range Demo: Positive Step");
        for i in 0..2..10
        {
            Message(Convert.IntAsString(i));
        }	

        // Negative step
        Message("Range Demo: Negative Step");
        for i in 10..-2..0
        {
            Message(Convert.IntAsString(i));
        }	

        // Range Functions are present in Microsoft.Quantum.Core library and they can be used as variables.
        Message("Range functions demo");
        let range = 1..5..100;
        Message(Convert.IntAsString(RangeStart(range)));
        Message(Convert.IntAsString(RangeStep(range)));
        Message(Convert.IntAsString(RangeEnd(range)));
    }
}
