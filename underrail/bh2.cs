using System;
using System.Diagnostics;

// Token: 0x02002146 RID: 8518
[bmq("1.1.1.5_Jyt1WasteWaterPeekThroughFix", "1.1.1.5", "jyt1", false)]
public sealed class bh2 : fg
{
	// Token: 0x0600C8D1 RID: 51409 RVA: 0x0046DE40 File Offset: 0x0046C040
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("7f53bd7b-f081-4199-a44f-d0c9765e6e0f"), A_1.n("jyt1")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("frag_dun_wasteWater", new bool?(false)).Value)
			{
				c5x.w();
				c5x.an();
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
