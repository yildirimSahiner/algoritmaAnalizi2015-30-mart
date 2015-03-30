using System;

public class Test
{
	public static void Main()
	{
	    LinkedList<int> theList = new LinkedList<int>();
        LinkedListIterator<int> theItr;
        int i;

        theItr = theList.Zeroth( );
        PrintList( theList );

        for( i = 0; i < 10; i++ )
        {
            theList.Insert(i, theItr);
            PrintList(theList);
            theItr.Advance();
        }
        Console.WriteLine("uzunluk: " + ListSize(theList));
        for( i = 0; i < 10; i += 2 )
            theList.Remove( i );

        for( i = 0; i < 10; i++ )
            if((i % 2 == 0) == ( theList.Find( i ).IsValid()))
                Console.WriteLine( "bulunamadi" );

        Console.WriteLine( "silme islemi tamamlandi" );
        PrintList(theList);
	}
	   public static void PrintList<AnyType>(LinkedList<AnyType> theList)
    {
        if( theList.IsEmpty())
            Console.WriteLine( "Bos liste" );
        else
        {
            LinkedListIterator<AnyType> itr = theList.First();

            for( ; itr.IsValid(); itr.Advance())
                Console.Write(itr.Retrieve() + " ");
        }

        Console.WriteLine();
    }

    public static int ListSize<AnyType>(LinkedList<AnyType> theList)
    {
        LinkedListIterator<AnyType> itr;
        int size = 0;
        for( itr = theList.First(); itr.IsValid(); itr.Advance())
            size++;

        return size;
    }

}
