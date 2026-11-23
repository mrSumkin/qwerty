using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020021A5 RID: 8613
[bmq("1.0.1.5_Cc16GangBroadcast", "1.0.1.5", "cc16", false)]
public sealed class bez : fg
{
	// Token: 0x0600C99E RID: 51614 RVA: 0x00475124 File Offset: 0x00473324
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_1.n("cc16").Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId == asp.dl && c5x.h.b.aa().HostilityBroadcastMode == c2n.b)
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
