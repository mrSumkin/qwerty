using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020006A6 RID: 1702
public sealed class e0j : bd3
{
	// Token: 0x06002C13 RID: 11283 RVA: 0x000FD430 File Offset: 0x000FB630
	public List<bj8> bz()
	{
		List<bj8> list = new List<bj8>();
		if (dk2.f())
		{
			for (int i = 0; i < 20; i++)
			{
				bj8 bj = new bj8();
				bj.a("SormirbarenRune" + i.ToString());
				bj.a().Add(new d8h("Xpbl_Plot", new Point(0, 4), 1f));
				bj.a().Add(new d8h("Xpbl_Plot", new Point(i % 10, 5 + i / 10), 0.8f));
				list.Add(bj);
			}
		}
		return list;
	}
}
