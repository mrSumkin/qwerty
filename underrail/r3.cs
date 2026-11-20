using System;
using System.Diagnostics;

// Token: 0x020020C5 RID: 8389
[bmq("1.1.5.0_BlackCrawlerOnDeathJobs", "1.1.5.0", "lu-b10u2", false)]
public sealed class r3 : fg
{
	// Token: 0x0600C7F5 RID: 51189 RVA: 0x00467778 File Offset: 0x00465978
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d1c256f8-8f4d-450f-999c-9b07c1833009"), A_1.n("lu-b10u2b")).ao() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Bag.b("Oddity.TranquilizerBoltSyringe") == null)
			{
				c5x.h.b.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<x2>("Oddities\\TranquilizerBoltSyringe"))
				{
					Stealable = false
				}, true);
				a6p aspect = c5x.GetAspect<a6p>();
				if (aspect != null)
				{
					aspect.d().Add("-inventory");
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
