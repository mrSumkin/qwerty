using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02002102 RID: 8450
[s3("1.1.3.1_PlayerMutantHostilityFix", "1.1.3.1")]
public sealed class e5h : cwo
{
	// Token: 0x0600C852 RID: 51282 RVA: 0x00469FD4 File Offset: 0x004681D4
	public bool ee(cyt A_0)
	{
		try
		{
			if (d8s.b())
			{
				bv9 bv = A_0.ac() as bv9;
				foreach (string a_ in Enumerable.Where<string>(bv.abr().Keys, new Func<string, bool>(e5h.a.a.a)))
				{
					bv.a(asp.a, a_, h.a, null, true, false, false);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x02002103 RID: 8451
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C856 RID: 51286 RVA: 0x0046A0C4 File Offset: 0x004682C4
		internal bool a(string A_0)
		{
			return A_0 != asp.a2 && A_0 != asp.a && A_0 != asp.d && A_0 != asp.d5 && A_0 != asp.gm && A_0 != asp.gn && A_0 != asp.gl && A_0 != asp.du && A_0 != asp.fm;
		}

		// Token: 0x040049FE RID: 18942
		public static readonly e5h.a a = new e5h.a();

		// Token: 0x040049FF RID: 18943
		public static Func<string, bool> b;
	}
}
