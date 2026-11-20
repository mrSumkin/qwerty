using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020018BA RID: 6330
public static class ao5
{
	// Token: 0x06008659 RID: 34393 RVA: 0x0037B3B4 File Offset: 0x003795B4
	public static void a(string A_0, string A_1, int A_2, int A_3, string A_4)
	{
		eei value = new eei(A_0, A_1, A_2, A_3, A_4);
		ao5.a.Add(A_1.ToLowerInvariant(), value);
	}

	// Token: 0x0600865A RID: 34394 RVA: 0x0037B3E0 File Offset: 0x003795E0
	public static eei a(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		eei result;
		ao5.a.TryGetValue(A_0.ToLowerInvariant(), out result);
		return result;
	}

	// Token: 0x0600865B RID: 34395 RVA: 0x0037B40C File Offset: 0x0037960C
	public static int b()
	{
		return Enumerable.Sum<eei>(ao5.a.Values, new Func<eei, int>(ao5.a.a.b));
	}

	// Token: 0x0600865C RID: 34396 RVA: 0x0037B440 File Offset: 0x00379640
	public static int a()
	{
		return Enumerable.Sum<eei>(ao5.a.Values, new Func<eei, int>(ao5.a.a.a));
	}

	// Token: 0x04003385 RID: 13189
	public static Dictionary<string, eei> a = new Dictionary<string, eei>();

	// Token: 0x020018BB RID: 6331
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06008660 RID: 34400 RVA: 0x0037B494 File Offset: 0x00379694
		internal int b(eei A_0)
		{
			return A_0.ClassicExperience;
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x0037B49C File Offset: 0x0037969C
		internal int a(eei A_0)
		{
			return A_0.OddityExperience;
		}

		// Token: 0x04003386 RID: 13190
		public static readonly ao5.a a = new ao5.a();

		// Token: 0x04003387 RID: 13191
		public static Func<eei, int> b;

		// Token: 0x04003388 RID: 13192
		public static Func<eei, int> c;
	}
}
