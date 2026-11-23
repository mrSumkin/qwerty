using System;
using System.Diagnostics;

// Token: 0x020020A6 RID: 8358
[bmq("1.2.0.14_Xpbl_Md_FixLockpickableDoor", "1.2.0.14", "xpbl_md", false)]
public sealed class bq : fg
{
	// Token: 0x0600C7BF RID: 51135 RVA: 0x004660A4 File Offset: 0x004642A4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("xpbl_md");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("7082989e-10e7-4661-ae7e-4f87c2fecdbc"), aud).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null)
					{
						aspect.a(false);
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
