using System;
using System.Collections.Generic;

// Token: 0x020011B4 RID: 4532
public static class dxr
{
	// Token: 0x06006090 RID: 24720 RVA: 0x002A33FC File Offset: 0x002A15FC
	public static List<string> d()
	{
		return dxr.a("", dxr.b);
	}

	// Token: 0x06006091 RID: 24721 RVA: 0x002A3410 File Offset: 0x002A1610
	public static List<string> c()
	{
		return dxr.a("amp", dxr.c);
	}

	// Token: 0x06006092 RID: 24722 RVA: 0x002A3424 File Offset: 0x002A1624
	public static List<string> b()
	{
		return dxr.a("rs", dxr.d);
	}

	// Token: 0x06006093 RID: 24723 RVA: 0x002A3438 File Offset: 0x002A1638
	public static List<string> a()
	{
		return dxr.a("ds", dxr.e);
	}

	// Token: 0x06006094 RID: 24724 RVA: 0x002A344C File Offset: 0x002A164C
	private static List<string> a(string A_0, string[][] A_1)
	{
		List<string> list = new List<string>(A_1[cuo.a.Next(A_1.Length)]);
		List<string> list2 = new List<string>(list.Count);
		while (list.Count > 0)
		{
			int index = cuo.a.Next(list.Count);
			list2.Add(string.Format("Xpbl_Sonocaster_{0}_{1}", A_0, list[index]));
			list.RemoveAt(index);
		}
		return list2;
	}

	// Token: 0x04002922 RID: 10530
	public static readonly int a = 4;

	// Token: 0x04002923 RID: 10531
	private static readonly string[][] b = new string[][]
	{
		new string[]
		{
			"c3",
			"e3",
			"g3",
			"c4"
		},
		new string[]
		{
			"e3",
			"g#3",
			"b3",
			"e4"
		},
		new string[]
		{
			"g#4",
			"c5",
			"d#4",
			"c4"
		},
		new string[]
		{
			"d5",
			"f#3",
			"a3",
			"d4"
		},
		new string[]
		{
			"g2",
			"b4",
			"d4",
			"g3"
		},
		new string[]
		{
			"a3",
			"c#4",
			"e4",
			"e3"
		},
		new string[]
		{
			"f3",
			"a4",
			"c4",
			"c3"
		}
	};

	// Token: 0x04002924 RID: 10532
	private static readonly string[][] c = new string[][]
	{
		new string[]
		{
			"d2",
			"a2",
			"d3",
			"f3"
		},
		new string[]
		{
			"a3",
			"c3",
			"e3",
			"e4"
		},
		new string[]
		{
			"b1",
			"f#2",
			"b3",
			"c#4"
		},
		new string[]
		{
			"g3",
			"d2",
			"a#4",
			"d4"
		},
		new string[]
		{
			"e3",
			"e2",
			"g3",
			"b4"
		},
		new string[]
		{
			"c3",
			"g3",
			"d#2",
			"d#4"
		},
		new string[]
		{
			"d2",
			"f3",
			"a3",
			"d4"
		}
	};

	// Token: 0x04002925 RID: 10533
	private static readonly string[][] d = new string[][]
	{
		new string[]
		{
			"b1",
			"b2",
			"b3",
			"b4"
		},
		new string[]
		{
			"f#3",
			"c#4",
			"f#4",
			"c#5"
		},
		new string[]
		{
			"d2",
			"d3",
			"d4",
			"d5"
		},
		new string[]
		{
			"c3",
			"g3",
			"c4",
			"g4"
		},
		new string[]
		{
			"g2",
			"g3",
			"g4",
			"g5"
		},
		new string[]
		{
			"e2",
			"a2",
			"b3",
			"e4"
		},
		new string[]
		{
			"a2",
			"a3",
			"a4",
			"a5"
		},
		new string[]
		{
			"g2",
			"g3",
			"g4",
			"g5"
		},
		new string[]
		{
			"d#3",
			"a#3",
			"d#4",
			"a#5"
		}
	};

	// Token: 0x04002926 RID: 10534
	private static readonly string[][] e = new string[][]
	{
		new string[]
		{
			"e3",
			"g3",
			"a#3",
			"c#4"
		},
		new string[]
		{
			"c#3",
			"e4",
			"g2",
			"a#4"
		},
		new string[]
		{
			"b1",
			"d3",
			"g#4",
			"f5"
		},
		new string[]
		{
			"f#5",
			"a4",
			"c3",
			"d#2"
		},
		new string[]
		{
			"d3",
			"d#4",
			"d2",
			"b4"
		},
		new string[]
		{
			"a2",
			"d#3",
			"c2",
			"a#4"
		},
		new string[]
		{
			"g2",
			"c#3",
			"d4",
			"g#3"
		},
		new string[]
		{
			"c2",
			"c#4",
			"f#5",
			"g3"
		}
	};
}
