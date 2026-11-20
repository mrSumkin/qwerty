using System;
using System.Diagnostics;

// Token: 0x0200213D RID: 8509
[bmq("1.1.2.0_Xpbl_SpawnDiagnosticAndConfigurationTool", "1.1.2.0", "xpbl_sc,xpbl_arch,xpbl_rf_sec", false)]
public sealed class drf : fg
{
	// Token: 0x0600C8BD RID: 51389 RVA: 0x0046D4E8 File Offset: 0x0046B6E8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = null;
			if (A_1.y8() == "xpbl_sc")
			{
				c5x = (new ar7(new Guid("d0e772a0-fd62-4aa6-ac28-84cfa81d3ff5"), A_1.n(A_1.y8())).ao() as c5x);
			}
			else if (A_1.y8() == "xpbl_rf_sec")
			{
				c5x = (new ar7(new Guid("000513cd-1617-4cc7-b904-350421e3d0ca"), A_1.n(A_1.y8())).ao() as c5x);
			}
			else if (A_1.y8() == "xpbl_arch")
			{
				c5x = (new ar7(new Guid("7449b140-ff5a-4389-9faa-1931c9c49e28"), A_1.n(A_1.y8())).ao() as c5x);
			}
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<dj3>("Plot\\Xpbl\\NagaProtectorDiagnosticAndConfigurationTool"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
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
