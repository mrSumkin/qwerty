using System;
using System.Diagnostics;

// Token: 0x02002097 RID: 8343
[bmq("1.2.0.9_Xphw_GunslingerFollowingFix", "1.2.0.9", "xphw_up, up-cc, LU-SouthGateStation, cc_cityEnter", false)]
public sealed class d21 : fg
{
	// Token: 0x0600C7A4 RID: 51108 RVA: 0x004655C0 File Offset: 0x004637C0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_meetAfterExobase", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_died", new bool?(false)).Value)
			{
				aud aud = null;
				if (!string.IsNullOrEmpty(A_1.y8()))
				{
					if (A_1.y8() == "xphw_up")
					{
						aud = A_1.n("xphw_up");
					}
					else if (A_1.y8() == "LU-SouthGateStation")
					{
						aud = A_1.n("LU-SouthGateStation");
					}
					else if (A_1.y8() == "cc_cityEnter")
					{
						aud = A_1.n("cc_cityEnter");
					}
					else
					{
						aud = A_1.n("up-cc");
					}
				}
				if (aud != null)
				{
					c5x c5x = new ar7(c29.a, aud).ao() as c5x;
					if (c5x != null && c5x.t.b != null)
					{
						c5x.t.b.y6().RemoveProperty(ddq.bz);
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
