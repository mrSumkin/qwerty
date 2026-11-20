using System;
using System.Diagnostics;
using Ouroboros.Playfield.References;

// Token: 0x02002172 RID: 8562
[bmq("1.0.4.18_LowerJunkyardEmbassyDoorDifficulties", "1.0.4.18", "jye1", false)]
public sealed class d8d : fg
{
	// Token: 0x0600C92E RID: 51502 RVA: 0x004713DC File Offset: 0x0046F5DC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (string g in new string[]
			{
				"c50db025-2d1c-408e-86aa-24612d434c9c",
				"4435d0b4-d382-4ed0-a9d9-00102fc6dd8d"
			})
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(A_1.n("jye1"), new Guid(g)).ao();
				if (d2b != null)
				{
					d2b.a(40);
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
