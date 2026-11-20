using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

// Token: 0x02002128 RID: 8488
[bmq("1.1.2.2_FixDnDStairs", "1.1.2.2", "xpbl_ww_dragNDrop", true)]
public sealed class ajp : fg
{
	// Token: 0x0600C89C RID: 51356 RVA: 0x0046BF20 File Offset: 0x0046A120
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_ww_dragNDrop_l7") + ".uzl");
			A_1.a(a_, 99, null);
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == 99)
					{
						bool flag = false;
						using (List<ak1>.Enumerator enumerator3 = c5x.l.GetEnumerator())
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
							c5x.a(dm9.a);
						}
						c5x.Layer = aju.x;
					}
				}
			}
			d60 d = A_1.a();
			if (d != null)
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"xpbl_ww_DragNDrop_exit"
				})) as c5x;
				if (c5x2 != null && c5x2.s.b != null && c5x2.s.b.s().Count < 1)
				{
					c5x2.s.b.s().Add(new e68
					{
						Destination = new c2w(A_0.r().GetClassPropertyValue<string>("frag_xpbl_ww_dragNDrop_location"), "DnD_exit")
					});
					return true;
				}
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
