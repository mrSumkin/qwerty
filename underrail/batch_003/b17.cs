using System;
using System.Diagnostics;

// Token: 0x020021F2 RID: 8690
[bmq("1.0.0.3_Ojy_U2", "1.0.0.3", "ojy-u2", false)]
public sealed class b17 : fg
{
	// Token: 0x0600CA3D RID: 51773 RVA: 0x00479610 File Offset: 0x00477810
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("9fc49842-0a06-4931-ab99-5274207a7a70"), A_1.n("ojy-u2")).ao() as c5x;
			if (c5x != null && c5x.y8() != "Shelves")
			{
				c5x.q("Shelves");
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
