using System;
using System.Diagnostics;

// Token: 0x0200211B RID: 8475
[bmq("1.1.2.5_Xpbl_G2PirateSniperPatrolFix", "1.1.2.5", "xpbl_g2", false)]
public sealed class c0n : fg
{
	// Token: 0x0600C884 RID: 51332 RVA: 0x0046B218 File Offset: 0x00469418
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("5f5ee990-9fbb-45dd-adc0-5f6a3a942a0a"), A_1.n("xpbl_g2")).ao() as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				c5x.t.b.y6().RemoveProperty(ddq.k);
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
