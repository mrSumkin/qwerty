using System;
using Microsoft.Xna.Framework;

// Token: 0x02000732 RID: 1842
public sealed class c8p : km
{
	// Token: 0x06002F97 RID: 12183 RVA: 0x00120148 File Offset: 0x0011E348
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		for (int i = A_2.b.a.Count - 1; i >= 0; i--)
		{
			a2f a2f = A_2.b.a[i];
			if (a2f.a == "b")
			{
				a2f.e = new Color?(new Color(new Vector4(0.2f, 0.2f, 0.2f, 1f)));
				a2f.h = new float?(1f);
				return;
			}
		}
	}
}
