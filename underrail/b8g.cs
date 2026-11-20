using System;

// Token: 0x02001252 RID: 4690
public sealed class b8g : cju
{
	// Token: 0x0600655A RID: 25946 RVA: 0x002B3150 File Offset: 0x002B1350
	public override cry mn(c5x A_0, string A_1, Guid? A_2)
	{
		return new d0t(A_0, A_1, A_2);
	}

	// Token: 0x0600655B RID: 25947 RVA: 0x002B315C File Offset: 0x002B135C
	public override float mo()
	{
		return 0.15f;
	}

	// Token: 0x0600655C RID: 25948 RVA: 0x002B3164 File Offset: 0x002B1364
	public override float mp()
	{
		return 0.125f;
	}

	// Token: 0x0600655D RID: 25949 RVA: 0x002B3170 File Offset: 0x002B1370
	public override bool aem(ak1 A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		if (A_0.Formation.c(33562624L))
		{
			return false;
		}
		foreach (b0b b0b in A_0.c.Values)
		{
			c5x c5x = (c5x)b0b;
			if (c5x.GetAspect<dd9>() != null)
			{
				return false;
			}
			eks eks = c5x.GetAspect<bim>() as eks;
			if (eks != null && (eks.i() == g0.b || eks.i() == g0.c))
			{
				return false;
			}
		}
		return true;
	}
}
