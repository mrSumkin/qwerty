using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000769 RID: 1897
public sealed class dj6 : km
{
	// Token: 0x0600300D RID: 12301 RVA: 0x00123B94 File Offset: 0x00121D94
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = Enumerable.FirstOrDefault<a2f>(Enumerable.Where<a2f>(A_2.b.a, new Func<a2f, bool>(dj6.a.a.a)));
		if (a2f != null)
		{
			a2f.e = new Color?(new Color(10, 10, 255) * 0.5f);
		}
		a2f a2f2 = A_1.b(A_0, "Objects\\Natural\\IceBlock", Point.Zero, null, true);
		if (a2f2 != null && a2f2.d != null)
		{
			els els = A_3 as els;
			if (els != null && els.i < 1000.0)
			{
				a2f2.h = new float?((float)(0.6000000238418579 * (els.i / 1000.0)));
			}
			else
			{
				a2f2.h = new float?(0.6f);
			}
			A_2.b.a(a2f2);
		}
	}

	// Token: 0x0200076A RID: 1898
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003011 RID: 12305 RVA: 0x00123CAC File Offset: 0x00121EAC
		internal bool a(a2f A_0)
		{
			return A_0.a == "b";
		}

		// Token: 0x04001A46 RID: 6726
		public static readonly dj6.a a = new dj6.a();

		// Token: 0x04001A47 RID: 6727
		public static Func<a2f, bool> b;
	}
}
