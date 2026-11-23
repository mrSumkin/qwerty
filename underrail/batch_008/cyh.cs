using System;
using System.Diagnostics;

// Token: 0x020021FE RID: 8702
[bmq("1.0.0.11_Cc_SewerSwitch", "1.0.0.11", "cc_s3", false)]
public sealed class cyh : fg
{
	// Token: 0x0600CA55 RID: 51797 RVA: 0x0047A35C File Offset: 0x0047855C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("f38d8316-65eb-42a2-bb12-3cb6ce0eb306"), A_1.n("cc_s3")).ao() as c5x;
			if (c5x != null)
			{
				b0e b0e = c5x.GetAspect<bim>() as b0e;
				if (b0e != null && !b0e.af1())
				{
					b0e.af2(true);
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
