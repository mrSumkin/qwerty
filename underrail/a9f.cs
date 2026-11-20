using System;
using System.Diagnostics;

// Token: 0x020020F4 RID: 8436
[bmq("1.1.4.0_Tch_Off_ModelReplacement", "1.1.4.0", "tch-off", false)]
public sealed class a9f : fg
{
	// Token: 0x0600C83C RID: 51260 RVA: 0x004696A8 File Offset: 0x004678A8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("a561cf47-a91c-4fc3-8e07-da062a8b3593"), A_1.n("tch-off")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.a(bln.ck);
				cgk cgk = c5x.h.b.aa().Gear.l().Item;
				if (cgk != null)
				{
					cgk.Stealable = false;
					cgk.Lootable = false;
				}
			}
			c5x c5x2 = new ar7(new Guid("cc600ffe-3d8b-46ab-94b3-b265bbff8728"), A_1.n("tch-off")).ao() as c5x;
			if (c5x2 != null && c5x2.h.b != null)
			{
				c5x2.h.b.a(bln.ck);
				cgk cgk2 = c5x2.h.b.aa().Gear.l().Item;
				if (cgk2 != null)
				{
					cgk2.Stealable = false;
					cgk2.Lootable = false;
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
