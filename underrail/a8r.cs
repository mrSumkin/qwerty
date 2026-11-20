using System;
using System.Diagnostics;

// Token: 0x020020B1 RID: 8369
[bmq("1.2.0.0_Lu_A2_TurretHostilityBroadcastFix", "1.2.0.0", "lu-a2", false)]
public sealed class a8r : fg
{
	// Token: 0x0600C7D0 RID: 51152 RVA: 0x0046655C File Offset: 0x0046475C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("lu-a2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("b4bcb578-f0c5-4f74-9ec2-c8c9e82c076f"), aud).ao() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					c5x.h.b.aa().HostilityBroadcastMode = c2n.c;
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
