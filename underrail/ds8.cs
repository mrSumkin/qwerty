using System;
using System.Diagnostics;

// Token: 0x020020A5 RID: 8357
[bmq("1.2.0.15_Sgs_LibraryLevelUnhackableDoorFix", "1.2.0.15", "StationAlpha-Level4", false)]
public sealed class ds8 : fg
{
	// Token: 0x0600C7BD RID: 51133 RVA: 0x0046600C File Offset: 0x0046420C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("l4");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("f89d3662-8679-4769-9a48-3a0ba550d58a"), aud).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null && !aspect.e())
					{
						aspect.a(true);
						aspect.a(10);
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
