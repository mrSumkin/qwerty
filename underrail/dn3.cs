using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020004A9 RID: 1193
public sealed class dn3
{
	// Token: 0x06001E47 RID: 7751 RVA: 0x000A895C File Offset: 0x000A6B5C
	internal dn3()
	{
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x000A897C File Offset: 0x000A6B7C
	internal dn3(IEnumerable<av9> A_0)
	{
		czh.a(A_0, "lines");
		this.a.AddRange(A_0);
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x000A89B4 File Offset: 0x000A6BB4
	public void a(Point A_0, cp9 A_1, cne A_2 = null, float A_3 = 1f)
	{
		if (this.a == null)
		{
			return;
		}
		if (A_2 == null)
		{
			A_2 = bpo.GetService<cne>();
		}
		if (A_2 != null)
		{
			foreach (av9 av in this.a)
			{
				av.a(A_0, A_1, A_2, A_3);
			}
		}
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x000A8A30 File Offset: 0x000A6C30
	public ecs a()
	{
		ecs ecs = new ecs();
		if (this.a != null)
		{
			foreach (av9 av in this.a)
			{
				ecs.a.Add(av.a());
			}
		}
		return ecs;
	}

	// Token: 0x0400135A RID: 4954
	public List<av9> a = new List<av9>();

	// Token: 0x0400135B RID: 4955
	public esj b;

	// Token: 0x0400135C RID: 4956
	public List<string> c = new List<string>();
}
