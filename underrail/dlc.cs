using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020020A8 RID: 8360
[bmq("1.2.0.14_Xphw_Exobase_Tun_VisibilityTriggerFix", "1.2.0.14", "xphw_exobase_tun", false)]
public sealed class dlc : fg
{
	// Token: 0x0600C7C3 RID: 51139 RVA: 0x00466278 File Offset: 0x00464478
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("xphw_exobase_tun");
			if (aud != null)
			{
				foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
				{
					if (ya.Name.Equals("RailcarVisibility") && ya.Id != new Guid("ccb2baf0-5197-44f8-a3b9-97de59e3428d"))
					{
						ya.o();
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
