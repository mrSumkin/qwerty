using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x0200073C RID: 1852
public sealed class b3r : km
{
	// Token: 0x06002FAC RID: 12204 RVA: 0x00120984 File Offset: 0x0011EB84
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = Enumerable.FirstOrDefault<a2f>(Enumerable.Where<a2f>(A_2.b.a, new Func<a2f, bool>(b3r.a.a.a)));
		if (a2f != null)
		{
			Random random = new Random((int)((double)A_0.d() / 1.5) + A_3.GetHashCode());
			for (int i = random.Next(0, 15); i < 2; i++)
			{
				a2f a2f2 = a2f.f5();
				a2f2.a = "d";
				a2f2.h = new float?(0.3f);
				a2f2.e = new Color?(new Color(255, 0, 0, 100));
				a2f a2f3 = a2f2.f5();
				a2f3.e = new Color?(new Color(0, 0, 255, 100));
				a2f.e = new Color?(new Color(0, 255, 0, 100));
				int num = random.Next(18);
				int num2 = random.Next(18);
				a2f2.j += new Vector2((float)(-7 + num), (float)(-7 + num2));
				a2f3.j -= new Vector2((float)(-7 + num), (float)(-7 + num2));
				A_2.b.a(a2f2);
				A_2.b.a(a2f3);
			}
		}
	}

	// Token: 0x0200073D RID: 1853
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002FB0 RID: 12208 RVA: 0x00120B10 File Offset: 0x0011ED10
		internal bool a(a2f A_0)
		{
			return A_0.a == "b";
		}

		// Token: 0x04001A3D RID: 6717
		public static readonly b3r.a a = new b3r.a();

		// Token: 0x04001A3E RID: 6718
		public static Func<a2f, bool> b;
	}
}
