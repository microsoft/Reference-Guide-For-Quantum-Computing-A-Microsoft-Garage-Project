namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;
	//Needed to call Range functions
	open Microsoft.Quantum.Extensions.RangeFunctions;

    operation DemoOperation () : ()
    {
        body
        {
			//Arrays start from 0
            mutable arr = [0;10;20;30];
			for(i in 0..Length(arr)-1)
			{
				Message(ToStringI(arr[i]));
			}

			//Appending two arrays
			set arr = arr + [40;50];
			for(i in 0..Length(arr)-1)
			{
				Message(ToStringI(arr[i]));
			}

			//Head returns the first element of the array
			Message(ToStringI(Head(arr)));

			//Tail returns the last element of the array
			Message(ToStringI(Tail(arr)));

			//Rest returns a new array by skipping the first element
			Message("Rest Demo:");
			mutable restArr = Rest(arr);
			for(i in 0..Length(Rest(restArr))-1)
			{
				Message(ToStringI(restArr[i]));
			}

			Message("Subarray Demo:");
			//Subarray picks only the items mentioned in the first list
			mutable newSubArr = Subarray([2;3;0],arr);
			for(i in 0..Length(newSubArr)-1)
			{
				Message(ToStringI(newSubArr[i]));
			}

			//Reverse Demo
			Message("Reverse Demo:");
			mutable reverseArr = Reverse(arr);
			for(i in 0..Length(reverseArr)-1)
			{
				Message(ToStringI(reverseArr[i]));
			}

			//Range Demo
			//The middle value is the step, default is 1
			Message("Range Demo1");
			for(i in 0..2..10)
			{
				Message(ToStringI(i));
			}	

			//Negative step
			Message("Range Demo2");
			for(i in 10..-2..0)
			{
				Message(ToStringI(i));
			}	

			//Range can be a variable
			Message("Range functions");
			let range = 1..5..100;
			Message(ToStringI(RangeStart(range)));
			Message(ToStringI(RangeStep(range)));
			Message(ToStringI(RangeEnd(range)));
        }
    }
}
