using System;
using System.Diagnostics;

// Token: 0x0200209F RID: 8351
[bmq("1.2.0.17_Lu_C5_DespawnBlockadeCorpses", "1.2.0.17", "lu-c5", false)]
public sealed class b5n : fg
{
	// Token: 0x0600C7B4 RID: 51124 RVA: 0x00465D5C File Offset: 0x00463F5C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("013c8aa7-dc6b-47fb-bfbd-894f1a3283a6"), A_1.n("lu-c5")).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				d60 d = A_1.a();
				if (d != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						"despawn_blockade"
					}))
					{
						b0b.w();
						b0b.an();
					}
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
