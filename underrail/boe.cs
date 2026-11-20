using System;
using System.Diagnostics;

// Token: 0x0200213E RID: 8510
[bmq("1.1.2.0_Xpbl_F1_FixKatyasCaveEntranceTraversibility", "1.1.2.0", "xpbl_f1", false)]
public sealed class boe : fg
{
	// Token: 0x0600C8BF RID: 51391 RVA: 0x0046D620 File Offset: 0x0046B820
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("b4eb6752-5d16-475a-921d-b3c6e466f87b"), A_1.n("xpbl_f1")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d9249ce8-53db-486c-94c2-a5455d6d8907"), A_1.n("xpbl_f1")).ao() as c5x;
			if (c5x != null)
			{
				b4h aspect = c5x.GetAspect<b4h>();
				if (aspect != null)
				{
					if (aspect.j())
					{
						c5x.TileFormationModifiers.s3(7);
					}
					else
					{
						aspect.i().s3(7);
					}
				}
			}
			if (c5x2 != null)
			{
				b4h aspect2 = c5x2.GetAspect<b4h>();
				if (aspect2 != null)
				{
					if (aspect2.j())
					{
						c5x2.TileFormationModifiers.s3(7);
					}
					else
					{
						aspect2.i().s3(7);
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
