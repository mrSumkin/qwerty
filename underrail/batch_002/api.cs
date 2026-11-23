using System;
using System.Diagnostics;

// Token: 0x020021F7 RID: 8695
[bmq("1.0.0.2_RaiderCampVent", "1.0.0.2", "cv12", false)]
public sealed class api : fg
{
	// Token: 0x0600CA47 RID: 51783 RVA: 0x00479A64 File Offset: 0x00477C64
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("34880b8d-2348-4b03-9b64-e866afdd116b"), A_1.n("cv12")).ao() as c5x;
			if (c5x != null && !c5x.TileFormationModifiers.a(4))
			{
				c5x.TileFormationModifiers = new bjp(new byte[]
				{
					4
				});
				c5x.z();
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
