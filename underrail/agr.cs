using System;
using System.Diagnostics;

// Token: 0x020020B5 RID: 8373
[bmq("1.2.0.0_Xphw_Lux_A3_ImportLMG", "1.2.0.0", "lux-a3", true)]
public sealed class agr : t0
{
	// Token: 0x0600C7D7 RID: 51159 RVA: 0x00466704 File Offset: 0x00464904
	public agr() : base("lux-a3", 3)
	{
	}

	// Token: 0x0600C7D8 RID: 51160 RVA: 0x00466714 File Offset: 0x00464914
	public override bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (dk2.b("xphw"))
			{
				base.b5(A_0, A_1);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
