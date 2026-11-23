using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003BF RID: 959
[fe("crab")]
public sealed class c8q : am2
{
	// Token: 0x06001A18 RID: 6680 RVA: 0x0008C690 File Offset: 0x0008A890
	public c8q(bm6 A_0) : base(A_0)
	{
		e1y e1y = Enumerable.Last<c96>(base.g(), new Func<c96, bool>(c8q.a.a.b)) as e1y;
		if (e1y != null)
		{
			e1y.b = false;
			e7y e7y = Enumerable.First<c96>(e1y.g(), new Func<c96, bool>(c8q.a.a.a)) as e7y;
			if (e7y != null)
			{
				e7y.c = 3;
				e7y.b = 5;
			}
		}
	}

	// Token: 0x020003C0 RID: 960
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A1B RID: 6683 RVA: 0x0008C740 File Offset: 0x0008A940
		internal bool b(c96 A_0)
		{
			return A_0 is e1y;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0008C74C File Offset: 0x0008A94C
		internal bool a(c96 A_0)
		{
			return A_0 is e7y;
		}

		// Token: 0x04000EB0 RID: 3760
		public static readonly c8q.a a = new c8q.a();

		// Token: 0x04000EB1 RID: 3761
		public static Func<c96, bool> b;

		// Token: 0x04000EB2 RID: 3762
		public static Func<c96, bool> c;
	}
}
