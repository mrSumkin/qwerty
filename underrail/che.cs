using System;
using System.Diagnostics;

// Token: 0x0200214C RID: 8524
[bmq("1.1.1.2_Cc22_ModelChange", "1.1.1.2", "cc22", false)]
public sealed class che : fg
{
	// Token: 0x0600C8DE RID: 51422 RVA: 0x0046E988 File Offset: 0x0046CB88
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("9474a0f8-1e28-4780-997b-b565fe0c338e"), A_1.n("cc22")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.a(bln.c0);
					aspect.aa().Gear.l().b(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\PraetorianHeavyArmorCaped")));
					aspect.aa().Gear.g().b(new k7(ez2.CreateDefinitonProvider<bqu>("armor\\PraetorianHeavyHelmet")));
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
