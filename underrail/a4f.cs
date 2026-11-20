using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x0200073A RID: 1850
public sealed class a4f : km
{
	// Token: 0x06002FA7 RID: 12199 RVA: 0x00120828 File Offset: 0x0011EA28
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = Enumerable.FirstOrDefault<a2f>(Enumerable.Where<a2f>(A_2.b.a, new Func<a2f, bool>(a4f.a.a.a)));
		if (a2f != null)
		{
			int num = A_0.d() % 17;
			float num2;
			if (num < 8)
			{
				num2 = 0.5f + (float)num / 16f;
			}
			else if (num > 8)
			{
				num2 = 1f - (float)(num - 8) / 16f;
			}
			else
			{
				num2 = 1f;
			}
			if (a2f.h == null)
			{
				a2f.h = new float?(num2 * 0.7f);
			}
			else
			{
				a2f.h *= num2 * 0.7f;
			}
			a2f.e = new Color?(new Color(128, 195, 255, 180));
			a2f.q = false;
			a2f.s = true;
		}
	}

	// Token: 0x0200073B RID: 1851
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002FAB RID: 12203 RVA: 0x00120970 File Offset: 0x0011EB70
		internal bool a(a2f A_0)
		{
			return A_0.a == "b";
		}

		// Token: 0x04001A3B RID: 6715
		public static readonly a4f.a a = new a4f.a();

		// Token: 0x04001A3C RID: 6716
		public static Func<a2f, bool> b;
	}
}
