using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Represents a set of results to be displayed
public class ResultsPair
{
	public readonly string label; //The label of the results
	public readonly string result; //The actual results text

	//Constructs a new results pair
	public ResultsPair(string label, string result)
	{
		this.label = label;
		this.result = result;
	}
}

