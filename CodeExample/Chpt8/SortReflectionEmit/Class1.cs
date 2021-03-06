using System;
using System.Collections;
using SharedAssembly;

  
	class SortReflectionEmit
	{
		static void Main(string[] args)
		{
			ArrayList stockList = new ArrayList();
			StockData stkData1 = new StockData();
			stkData1.Symbol = "MSFT";

			stkData1.AskPrice = 10;
			stkData1.BidPrice = 12;

			StockData stkData2= new StockData();
			stkData2.Symbol = "IBM";
			stkData2.AskPrice = 12;
			stkData2.BidPrice = 9;

			StockData stkData3 = new StockData();
			stkData3.Symbol = "GE";
			stkData3.AskPrice = 13;
			stkData3.BidPrice = 10;

			stockList.Add(stkData1);
			stockList.Add(stkData2);
			stockList.Add(stkData3);

			while(true)
			{
				Console.WriteLine("Enter name of the field to sort on : ");
				string fldName = Console.ReadLine();
				SortByReflectionEmit sort = new SortByReflectionEmit(fldName);
				stockList.Sort(sort.GetComparer());
  
				Console.WriteLine(fldName +" -----------------------" );
				foreach(StockData stkData in stockList)
				{
					Console.WriteLine("Symbol {0} AskPrice {1} BidPrice {2} ",stkData.Symbol,stkData.AskPrice,stkData.BidPrice);
					}
				Console.WriteLine("-------------------------------");
			}
		}
	}
