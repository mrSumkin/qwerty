using System;
using System.Diagnostics;

// Token: 0x02002155 RID: 8533
[bmq("1.1.0.15_Cc18_HarlanModelChange", "1.1.0.15", "cc18", false)]
public sealed class ab8 : fg
{
	// Token: 0x0600C8F6 RID: 51446 RVA: 0x0046F9DC File Offset: 0x0046DBDC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("8b023371-abc2-4915-9d0f-f792588684e2"), A_1.n("cc18")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.a(bln.c6);
					c8d c8d = new c8d(ez2.CreateDefinitonProvider<c43>("armor\\CoretechTacticalVest"));
					if (c8d.fu().ba() != null)
					{
						c8d.Battery = (double)c8d.fu().ba().Value;
					}
					aspect.aa().Gear.l().a(c8d, true);
					aspect.aa().Gear.g().b(new k7(ez2.CreateDefinitonProvider<bqu>("armor\\CoretechMask")));
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
