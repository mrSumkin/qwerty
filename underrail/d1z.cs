using System;
using System.Diagnostics;

// Token: 0x020021DB RID: 8667
[bmq("1.0.1.13_GauntletRunners", "1.0.1.13", "cc_enterGauntlet", false)]
public sealed class d1z : fg
{
	// Token: 0x0600CA0D RID: 51725 RVA: 0x00478370 File Offset: 0x00476570
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("0794099b-0a9d-4999-9c3a-e9a2c93e385f"), A_1.n("cc_enterGauntlet")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d84dacbd-19f5-4acb-b18b-ac868fcb2362"), A_1.n("cc_enterGauntlet")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null && aspect.aa().FactionId != "coreCity")
				{
					aspect.aa().FactionId = "coreCity";
					aspect.aa().HostilityBroadcastMode = c2n.d;
				}
			}
			if (c5x2 != null)
			{
				amc aspect2 = c5x2.GetAspect<amc>();
				if (aspect2 != null && aspect2.aa().FactionId != "coreCity")
				{
					aspect2.aa().FactionId = "coreCity";
					aspect2.aa().HostilityBroadcastMode = c2n.d;
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
