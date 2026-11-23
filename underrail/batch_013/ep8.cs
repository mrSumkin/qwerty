using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ouroboros.Playfield.Space;

// Token: 0x0200219B RID: 8603
[bmq("1.0.1.5_Tch_Mil_Wardrobe", "1.0.1.5", "tch-mil", false)]
public sealed class ep8 : fg
{
	// Token: 0x0600C98A RID: 51594 RVA: 0x00474340 File Offset: 0x00472540
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("748033a8-e581-4e07-b4b3-71603965d5c4"), A_1.n("tch-mil")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("388c4457-c579-4577-a69b-236075aad410"), A_1.n("tch-mil")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("75214b66-134b-448e-b1b5-94a0ecff408a"), A_1.n("tch-mil")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("9891e4cd-dedc-44e2-a7d1-f775979d7956"), A_1.n("tch-mil")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.t().Clear();
					c7j.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			if (c5x2 != null)
			{
				c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
				if (c7j2 != null)
				{
					c7j2.t().Clear();
					c7j2.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			if (c5x3 != null)
			{
				c7j c7j3 = c5x3.GetAspect<bim>() as c7j;
				if (c7j3 != null)
				{
					c7j3.t().Clear();
					c7j3.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			if (c5x4 != null)
			{
				c7j c7j4 = c5x4.GetAspect<bim>() as c7j;
				if (c7j4 != null)
				{
					c7j4.t().Clear();
					c7j4.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
