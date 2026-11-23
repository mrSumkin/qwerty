using System;
using System.Diagnostics;

// Token: 0x0200220E RID: 8718
[bmq("1.0.0.11_Tch_LockerRobe", "1.0.0.11", "tch-sq2", false)]
public sealed class apl : fg
{
	// Token: 0x0600CA75 RID: 51829 RVA: 0x0047B7A0 File Offset: 0x004799A0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("266749df-bffa-4521-a246-52b186a973d9"), A_1.n("tch-sq2")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedTchortistRobe", new bool?(false)).Value)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c8d c8d = new c8d(ez2.CreateDefinitonProvider<c43>("armor\\Robe"));
					if (c8d != null)
					{
						c7j.ItemContainer.z3(c8d, true);
						A_0.r()["patch_placedTchortistRobe"] = true;
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
