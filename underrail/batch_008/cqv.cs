using System;
using System.Diagnostics;

// Token: 0x020021AB RID: 8619
[bmq("1.0.1.14_TithonusCells", "1.0.1.14", "dc-tl", false)]
public sealed class cqv : fg
{
	// Token: 0x0600C9AB RID: 51627 RVA: 0x00475684 File Offset: 0x00473884
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("cff026b3-7f92-45e8-933f-e2cf798a83ca"), A_1.n("dc-tl")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("a78cc5d0-a907-4b8f-8e62-86a9fdeedae2"), A_1.n("dc-tl")).ao() as c5x;
			if (c5x != null)
			{
				i aspect = c5x.GetAspect<i>();
				if (aspect != null && aspect.f() != "cmn4")
				{
					aspect.a("cmn4");
				}
			}
			if (c5x2 != null)
			{
				i aspect2 = c5x2.GetAspect<i>();
				if (aspect2 != null && aspect2.f() != "rg1")
				{
					aspect2.a("rg1");
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
