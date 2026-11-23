using System;
using System.Diagnostics;

// Token: 0x020021E6 RID: 8678
[bmq("1.0.0.9_GortsLocker", "1.0.0.9", "jy6", false)]
public sealed class akp : fg
{
	// Token: 0x0600CA25 RID: 51749 RVA: 0x00478C68 File Offset: 0x00476E68
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("332494c8-a010-43a3-b5fa-192868461f89"), A_1.n("jy6")).ao() as c5x;
			if (c5x != null && c5x.x)
			{
				c5x.x = false;
				c5x.ah();
				c5x.@as();
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
