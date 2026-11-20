using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000727 RID: 1831
public sealed class bz0 : km
{
	// Token: 0x06002F7F RID: 12159 RVA: 0x0011FA60 File Offset: 0x0011DC60
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = Enumerable.FirstOrDefault<a2f>(Enumerable.Where<a2f>(A_2.b.a, new Func<a2f, bool>(bz0.a.a.a)));
		if (a2f != null)
		{
			a2f.e = new Color?(new Color(40, 40, 225));
		}
	}

	// Token: 0x02000729 RID: 1833
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002F86 RID: 12166 RVA: 0x0011FAEC File Offset: 0x0011DCEC
		internal bool a(a2f A_0)
		{
			return A_0.a == "b";
		}

		// Token: 0x04001A39 RID: 6713
		public static readonly bz0.a a = new bz0.a();

		// Token: 0x04001A3A RID: 6714
		public static Func<a2f, bool> b;
	}
}
