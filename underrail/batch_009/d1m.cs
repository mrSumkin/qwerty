using System;
using System.Diagnostics;

// Token: 0x020021F8 RID: 8696
[bmq("1.0.0.2_FixEdgarsKey", "1.0.0.2", "cv16", false)]
public sealed class d1m : fg
{
	// Token: 0x0600CA49 RID: 51785 RVA: 0x00479AFC File Offset: 0x00477CFC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("a0959a39-e444-45ec-a51a-30b90f5580d7"), A_1.n("cv16")).ao() as c5x;
			if (c5x != null)
			{
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null && !string.IsNullOrEmpty(aspect.i()))
				{
					aspect.a(null);
					aspect.b("key.ch_edgarsKey");
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
