using System;
using System.Diagnostics;

// Token: 0x020020B4 RID: 8372
[bmq("1.2.0.0_Xphw_Lux_B16_ImportLMG", "1.2.0.0", "lux-b16", true)]
public sealed class div : t0
{
	// Token: 0x0600C7D5 RID: 51157 RVA: 0x0046669C File Offset: 0x0046489C
	public div() : base("lux-b16", 2)
	{
	}

	// Token: 0x0600C7D6 RID: 51158 RVA: 0x004666AC File Offset: 0x004648AC
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
