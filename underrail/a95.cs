using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000764 RID: 1892
public sealed class a95 : km
{
	// Token: 0x06003002 RID: 12290 RVA: 0x001235E8 File Offset: 0x001217E8
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = Enumerable.FirstOrDefault<a2f>(Enumerable.Where<a2f>(A_2.b.a, new Func<a2f, bool>(a95.a.a.a)));
		if (a2f != null)
		{
			Random random = new Random((int)((double)A_0.d() / 1.5) + A_3.GetHashCode());
			if (a2f.h == null)
			{
				a2f.h = new float?(0.7f);
			}
			else
			{
				a2f.h *= 0.7f;
			}
			for (int i = 0; i < 2; i++)
			{
				a2f a2f2 = a2f.f5();
				by8 by = a2f2.d as by8;
				if (by != null)
				{
					by.a();
				}
				a2f2.a = "d";
				a2f2.h = new float?(0.3f);
				a2f2.j += new Vector2((float)(-7 + random.Next(14)), (float)(-7 + random.Next(14)));
				A_2.b.a(a2f2);
			}
		}
	}

	// Token: 0x02000765 RID: 1893
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x00123764 File Offset: 0x00121964
		internal bool a(a2f A_0)
		{
			return A_0.a == "b";
		}

		// Token: 0x04001A44 RID: 6724
		public static readonly a95.a a = new a95.a();

		// Token: 0x04001A45 RID: 6725
		public static Func<a2f, bool> b;
	}
}
