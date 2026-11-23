using System;
using System.Diagnostics;

// Token: 0x020020C7 RID: 8391
[bmq("1.1.5.0_MotionerStatusEffect", "1.1.5.0", "cc1,cc_passage,up2,lup-a11,tch-entry", true)]
public sealed class bje : fg
{
	// Token: 0x0600C7F9 RID: 51193 RVA: 0x004679E0 File Offset: 0x00465BE0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (!c5x.IsPlayer && c5x.h.b != null && !c5x.h.b.aa().StatusEffects.a(y4.h) && (c5x.y8() == "Motioner" || (A_1.y8() == "tch-entry" && c5x.y8() == "Maurice")))
					{
						y4 y = new y4(0);
						y.Stacks = cuo.a.Next(1, 5) * 5;
						c5x.h.b.aa().StatusEffects.a(y, false, false, false);
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
