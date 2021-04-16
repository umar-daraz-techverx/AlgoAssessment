﻿using System;
using System.Text;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
	    /* min value constraint */
	    private const int MinValue = 0;

	    /* max value constraint */
	    private const int MaxValue = 1000000000;

	    /* the thousands seperator character */
	    private const char ThousandsSeparator = ',';

	    public string Format(int value)
        {
	        /* ensure given value is within the constraints bounds */
	        if (value < MinValue || value > MaxValue)
	        {
		        throw new ArgumentOutOfRangeException();
	        }

            /* insert the thousands separator */
            var builder = new StringBuilder(value.ToString());

	        for (var i = builder.Length - 3; i > 0; i -= 3)
	        {
		        builder.Insert(i, ThousandsSeparator);
	        }

	        /* return the formatted string */
	        return builder.ToString();
        }
    }
}
