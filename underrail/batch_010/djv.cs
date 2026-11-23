using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003B7 RID: 951
[fe("lemurianStrongman")]
public sealed class djv : am2
{
	// Token: 0x060019F4 RID: 6644 RVA: 0x0008B4CC File Offset: 0x000896CC
	public djv(bm6 A_0) : base(A_0)
	{
		e1y e1y = Enumerable.Last<c96>(base.g(), new Func<c96, bool>(djv.a.a.b)) as e1y;
		if (e1y != null)
		{
			e1y.b = false;
			e7y e7y = Enumerable.First<c96>(e1y.g(), new Func<c96, bool>(djv.a.a.a)) as e7y;
			if (e7y != null)
			{
				e7y.c = 5;
				e7y.b = 8;
			}
		}
	}

	// Token: 0x020003B8 RID: 952
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060019F7 RID: 6647 RVA: 0x0008B57C File Offset: 0x0008977C
		internal bool b(c96 A_0)
		{
			return A_0 is e1y;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0008B588 File Offset: 0x00089788
		internal bool a(c96 A_0)
		{
			return A_0 is e7y;
		}

		// Token: 0x04000EA1 RID: 3745
		public static readonly djv.a a = new djv.a();

		// Token: 0x04000EA2 RID: 3746
		public static Func<c96, bool> b;

		// Token: 0x04000EA3 RID: 3747
		public static Func<c96, bool> c;
	}
}
