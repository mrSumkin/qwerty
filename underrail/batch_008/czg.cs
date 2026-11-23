using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// Token: 0x0200215F RID: 8543
[bmq("1.1.0.15_StationAlpha-Cc_Arena_LootLocker", "9.9.9.9", "cc_arena", true)]
public sealed class czg : fg
{
	// Token: 0x0600C90A RID: 51466 RVA: 0x00470478 File Offset: 0x0046E678
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_arena_l2") + ".uzl");
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
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_arena_rathoundsDefeated", new bool?(false)).Value)
			{
				c5x c5x2 = new ar7(new Guid("cffd6257-b28c-42d6-90e9-ba59dae40b45"), A_1.n("cc_arena_lower")).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.RemoveAspect<c3g>();
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
