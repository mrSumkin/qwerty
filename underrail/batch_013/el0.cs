using System;
using System.Diagnostics;

// Token: 0x0200215C RID: 8540
[bmq("1.1.0.15_Jy6_MakeGateLockpickable", "1.1.0.15", "jy6", false)]
public sealed class el0 : fg
{
	// Token: 0x0600C904 RID: 51460 RVA: 0x00470178 File Offset: 0x0046E378
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("28553775-ce24-4db7-a0c8-55f38a94be71"), A_1.n("jy6")).ao() as c5x;
			if (c5x != null)
			{
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null && !aspect.e())
				{
					aspect.a(true);
					aspect.a(70);
					aspect.b("key.jydepotA");
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
