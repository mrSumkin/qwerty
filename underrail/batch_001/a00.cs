using System;
using System.Collections.Generic;

// Token: 0x02000494 RID: 1172
public static class a00
{
	// Token: 0x06001DFA RID: 7674 RVA: 0x000A65CC File Offset: 0x000A47CC
	public static int? a(string A_0)
	{
		int value;
		if (!string.IsNullOrEmpty(A_0) && a00.a.TryGetValue(A_0.ToLowerInvariant(), out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x000A660C File Offset: 0x000A480C
	public static string a(int A_0)
	{
		if (A_0 >= 0 && A_0 < a00.b.Length)
		{
			return a00.b[A_0];
		}
		return null;
	}

	// Token: 0x04001294 RID: 4756
	private static Dictionary<string, int> a = new Dictionary<string, int>
	{
		{
			"q",
			0
		},
		{
			"w",
			1
		},
		{
			"e",
			2
		},
		{
			"r",
			3
		},
		{
			"t",
			4
		},
		{
			"y",
			5
		}
	};

	// Token: 0x04001295 RID: 4757
	private static string[] b = new string[]
	{
		"q",
		"w",
		"e",
		"r",
		"t",
		"y"
	};
}
