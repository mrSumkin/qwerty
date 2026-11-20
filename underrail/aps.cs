using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// Token: 0x02002147 RID: 8519
[bmq("1.1.1.5_WarehouseBlockAlphaBarrierFix", "1.1.1.5", "WarehouseBlockAlpha1", false)]
public sealed class aps : fg
{
	// Token: 0x0600C8D3 RID: 51411 RVA: 0x0046DEDC File Offset: 0x0046C0DC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("l_wba1_moved", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("ec8d8aea-30bf-4a07-9515-f183826097f8"), A_1.n("WarehouseBlockAlpha1")).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("523b109a-5320-4566-9744-f52e02d164a9"), A_1.n("WarehouseBlockAlpha1")).ao() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					List<cze> list = c5x.h.b.ay();
					edv edv = new edv();
					edv.a("l2");
					list.Add(edv);
				}
				else if (c5x2 != null)
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "WarehouseBlockAlpha1_l2") + ".uzl");
					A_1.a(a_, 99, null);
					foreach (aud aud in A_1.Areas)
					{
						foreach (b0b b0b in aud.Entities)
						{
							c5x c5x3 = (c5x)b0b;
							if (c5x3.Layer == 99)
							{
								bool flag = false;
								using (List<ak1>.Enumerator enumerator3 = c5x3.l.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										if (enumerator3.Current.a((long)((ulong)dm9.a)))
										{
											flag = true;
											break;
										}
									}
								}
								if (flag)
								{
									c5x3.a(dm9.a);
								}
								c5x3.Layer = aju.x;
							}
						}
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
