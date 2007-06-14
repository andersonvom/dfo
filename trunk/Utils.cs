
using System;
using System.Collections;

	public class Utils
	{
		public static string GetTagString(ArrayList tagslist) {
		  return String.Join(" ", (string[]) tagslist.ToArray(typeof(string)));
		}
		
		public static ArrayList GetIntersection(ArrayList src, ArrayList dst) {
		  ArrayList intersectedlist = new ArrayList();
		  foreach (object s in src) {
		    if (dst.Contains(s)) intersectedlist.Add(s);
		  }
		  return intersectedlist;
		}
	}