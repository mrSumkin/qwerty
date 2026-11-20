using System;

// Token: 0x02000EAA RID: 3754
[e79("Sgs_Intro2")]
public sealed class bxg : dgy
{
	// Token: 0x06004D99 RID: 19865 RVA: 0x00226660 File Offset: 0x00224860
	public bxg()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["introDone"] = true;
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Zone != null)
			{
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new di4(new c2w("StationAlpha-Level2", "tutorial"), false, null, 0, null, true, false, false)
				});
			}
		}
	}
}
