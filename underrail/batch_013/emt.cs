using System;
using System.Diagnostics;

// Token: 0x02002203 RID: 8707
[bmq("1.0.0.11_Cc_ResChest", "1.0.0.11", "cc-res", false)]
public sealed class emt : fg
{
	// Token: 0x0600CA5F RID: 51807 RVA: 0x0047AAAC File Offset: 0x00478CAC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("359077cf-a864-4482-b6c1-8af3beb49f9f"), A_1.n("cc-res")).ao() as c5x;
			if (c5x != null && c5x.y8() != "Crate")
			{
				c5x.q("Crate");
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
