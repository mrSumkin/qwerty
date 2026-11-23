using System;
using System.Diagnostics;

// Token: 0x02002180 RID: 8576
[bmq("1.0.3.1_TchortistArmorDurabilityFix", "1.0.3.1", "tch-can,tch-dclift,tch-entry,tch-ew1,tch-ew2,tch-inv,tch-labche,tch-labgen,tch-labpsy,tch-lib,tch-loff,tch-lq,tch-mainhall,tch-mil,tch-off,tch-rit,tch-soff,tch-sq1,tch-sq2,tch-util1,tch-util2,tch-util3,tch-ww1", true)]
public sealed class dxm : fg
{
	// Token: 0x0600C94E RID: 51534 RVA: 0x00471F0C File Offset: 0x0047010C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.h.b != null && !c5x.IsPlayer && c5x.h.b != null && c5x.h.b.aa().Gear.l().Item != null && c5x.h.b.aa().Gear.l().Item.fu().e() == "tchsol")
					{
						c5x.h.b.aa().Gear.l().Item.Durability = (double)c5x.h.b.aa().Gear.l().Item.MaxDurability;
						c5x.h.b.aa().bl();
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
