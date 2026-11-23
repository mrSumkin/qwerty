using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x0200115D RID: 4445
public static class yh
{
	// Token: 0x06005F24 RID: 24356 RVA: 0x002858A8 File Offset: 0x00283AA8
	public static void a(aud A_0, Vector3 A_1, string A_2, string A_3, float A_4 = 1f, c9z A_5 = c9z.a)
	{
		if (A_0 != null && !string.IsNullOrEmpty(A_3))
		{
			if (string.IsNullOrEmpty(A_2))
			{
				A_2 = Guid.NewGuid().ToString();
			}
			Point a_ = A_1.a();
			ak1 ak = A_0.a(a_);
			if (ak != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.c.Values, new Func<b0b, bool>(yh.a.a.a))) as c5x;
				if (c5x != null)
				{
					c5x.c().a(A_2, A_3, A_4, A_5, false, false);
				}
			}
		}
	}

	// Token: 0x0200115E RID: 4446
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005F27 RID: 24359 RVA: 0x00285968 File Offset: 0x00283B68
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040025DC RID: 9692
		public static readonly yh.a a = new yh.a();

		// Token: 0x040025DD RID: 9693
		public static Func<b0b, bool> b;
	}
}
