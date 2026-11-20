using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000399 RID: 921
[fe("lemurianNagaProtector")]
public sealed class biz : am2
{
	// Token: 0x06001971 RID: 6513 RVA: 0x000867FC File Offset: 0x000849FC
	public biz(bm6 A_0) : base(A_0)
	{
		e1y e1y = Enumerable.Last<c96>(base.g(), new Func<c96, bool>(biz.a.a.b)) as e1y;
		if (e1y != null)
		{
			e1y.b = false;
			e7y e7y = Enumerable.First<c96>(e1y.g(), new Func<c96, bool>(biz.a.a.a)) as e7y;
			if (e7y != null)
			{
				e7y.c = 5;
				e7y.b = 8;
			}
		}
	}

	// Token: 0x0200039A RID: 922
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001974 RID: 6516 RVA: 0x000868AC File Offset: 0x00084AAC
		internal bool b(c96 A_0)
		{
			return A_0 is e1y;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000868B8 File Offset: 0x00084AB8
		internal bool a(c96 A_0)
		{
			return A_0 is e7y;
		}

		// Token: 0x04000E83 RID: 3715
		public static readonly biz.a a = new biz.a();

		// Token: 0x04000E84 RID: 3716
		public static Func<c96, bool> b;

		// Token: 0x04000E85 RID: 3717
		public static Func<c96, bool> c;
	}
}
