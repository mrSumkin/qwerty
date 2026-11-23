using System;
using System.Diagnostics;

// Token: 0x020021AD RID: 8621
[bmq("1.0.1.14_Fo_MarcosModel", "1.0.1.14", "fom1", false)]
public sealed class aq : fg
{
	// Token: 0x0600C9AF RID: 51631 RVA: 0x00475980 File Offset: 0x00473B80
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2acef4b9-d31f-4756-80a5-8926ff38cddb"), A_1.n("fom1")).ao() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.h.b.am() != "wrkmn2")
			{
				c5x.h.b.a("wrkmn2");
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
