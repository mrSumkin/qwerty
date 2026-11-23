using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x0200075B RID: 1883
public sealed class ay8 : km
{
	// Token: 0x06002FEF RID: 12271 RVA: 0x00122EA4 File Offset: 0x001210A4
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = Enumerable.FirstOrDefault<a2f>(Enumerable.Where<a2f>(A_2.b.a, new Func<a2f, bool>(ay8.a.a.a)));
		if (a2f != null)
		{
			a2f.e = new Color?(new Color(255, 40, 40));
			for (int i = 0; i < 6; i++)
			{
				int num = (A_0.d() + i) % 6;
				a2f a2f2 = A_1.b(A_0, "Effects\\Smoke", new Point(num, 0), null, true);
				if (a2f2 != null && a2f2.d != null)
				{
					float num2 = (float)(-15.0 + 30.0 * new Random(i).NextDouble());
					float num3 = (float)(-20 + num * 7 - 20 + i * 2);
					a2f2.j = new Vector2(a2f2.j.X + num2, a2f2.j.Y + num3);
					eyc.a(a2f2, A_2, 1.0);
					a2f2.s = true;
					a2f2.h = new float?(0.4f - 0.05f * (float)num);
					A_2.b.a(0, a2f2);
				}
			}
		}
	}

	// Token: 0x0200075C RID: 1884
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002FF3 RID: 12275 RVA: 0x00123000 File Offset: 0x00121200
		internal bool a(a2f A_0)
		{
			return A_0.a == "b";
		}

		// Token: 0x04001A41 RID: 6721
		public static readonly ay8.a a = new ay8.a();

		// Token: 0x04001A42 RID: 6722
		public static Func<a2f, bool> b;
	}
}
