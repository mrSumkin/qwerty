using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001249 RID: 4681
public sealed class c9q : cju
{
	// Token: 0x06006521 RID: 25889 RVA: 0x002B2E80 File Offset: 0x002B1080
	public override cry mn(c5x A_0, string A_1, Guid? A_2)
	{
		return new hg(A_0, A_1, A_2);
	}

	// Token: 0x06006522 RID: 25890 RVA: 0x002B2E8C File Offset: 0x002B108C
	public override float mo()
	{
		return 0.25f;
	}

	// Token: 0x06006523 RID: 25891 RVA: 0x002B2E94 File Offset: 0x002B1094
	public override float mp()
	{
		return 0.15f;
	}

	// Token: 0x06006524 RID: 25892 RVA: 0x002B2E9C File Offset: 0x002B109C
	public override bjp ms()
	{
		return new bjp(16384L);
	}

	// Token: 0x06006525 RID: 25893 RVA: 0x002B2EAC File Offset: 0x002B10AC
	public override int? mr()
	{
		return new int?(16);
	}

	// Token: 0x06006526 RID: 25894 RVA: 0x002B2EB8 File Offset: 0x002B10B8
	public override float? afv()
	{
		return new float?(0.5f);
	}

	// Token: 0x06006527 RID: 25895 RVA: 0x002B2EC4 File Offset: 0x002B10C4
	public override bool afx()
	{
		return false;
	}

	// Token: 0x06006528 RID: 25896 RVA: 0x002B2ECC File Offset: 0x002B10CC
	public override List<cd0> afw(c5x A_0, bool A_1)
	{
		if (!A_1)
		{
			List<cd0> list = new List<cd0>();
			int num = cuo.a.Next(2) + 1;
			for (int i = 0; i < num; i++)
			{
				etz etz = new etz(A_0);
				etz.a = "Effects\\StarGlitter";
				etz.b = new Point(0, cuo.a.Next(4));
				etz.g = new float?(0.8f);
				etz.d = new float?(0.8f);
				etz.a(true);
				etz.c(11);
				list.Add(etz);
			}
			return list;
		}
		return null;
	}
}
