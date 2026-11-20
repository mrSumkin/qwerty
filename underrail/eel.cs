using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020003A8 RID: 936
[fe("giantWeaver")]
public class eel : am2
{
	// Token: 0x060019CC RID: 6604 RVA: 0x0008A258 File Offset: 0x00088458
	public eel(bm6 A_0) : base(A_0)
	{
		int num = base.g().IndexOf(Enumerable.First<aif>(Enumerable.OfType<aif>(base.g())));
		base.g().RemoveAt(num);
		base.a(num, new c96[]
		{
			new e1y("IdleMovement", new List<c96>
			{
				new e7y("IdleMoveToTile")
				{
					c = 0.75f,
					b = 5,
					c = 3
				},
				new aif("RestActivity")
			})
			{
				c = 0.5f
			}
		});
	}
}
