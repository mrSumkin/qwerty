using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020004A8 RID: 1192
public sealed class av9
{
	// Token: 0x06001E43 RID: 7747 RVA: 0x000A883C File Offset: 0x000A6A3C
	internal av9()
	{
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x000A8850 File Offset: 0x000A6A50
	internal av9(IEnumerable<d51> A_0)
	{
		czh.a(A_0, "sections");
		this.a.AddRange(A_0);
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x000A887C File Offset: 0x000A6A7C
	public void a(Point A_0, cp9 A_1, cne A_2, float A_3)
	{
		if (this.a == null)
		{
			return;
		}
		foreach (d51 d in this.a)
		{
			d.a(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x000A88E4 File Offset: 0x000A6AE4
	public dl6 a()
	{
		dl6 dl = new dl6();
		if (this.a != null)
		{
			foreach (d51 d in this.a)
			{
				dl.a.Add(d.a());
			}
		}
		return dl;
	}

	// Token: 0x04001358 RID: 4952
	internal List<d51> a = new List<d51>();

	// Token: 0x04001359 RID: 4953
	public esj b;
}
