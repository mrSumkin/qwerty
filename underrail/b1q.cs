using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02002188 RID: 8584
[bmq("1.0.3.24_ForsakenIslandExpansion", "1.0.3.24", "jgi1", true)]
public sealed class b1q : fg
{
	// Token: 0x0600C961 RID: 51553 RVA: 0x00472848 File Offset: 0x00470A48
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("jgi1");
			if (aud != null && aud.Size.c != 59)
			{
				int num = 3;
				if (aud.Size.c == 55)
				{
					num = 4;
				}
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == 1 && (!c5x.IsPlayer || !ary.a.b))
					{
						c5x.Location += new Vector3((float)num, 0f, 0f);
						c5x.ah();
						bool flag = false;
						using (List<ak1>.Enumerator enumerator2 = c5x.l.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.a((long)((ulong)dm9.a)))
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
				foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
				{
					if (ya.Layer == 1)
					{
						ya.o();
						ya.Location = d05.a(ya.Location, new Point(num, 0), false);
						aud.b(ya);
					}
				}
				foreach (csd csd in A_1.Waypoints)
				{
					if (csd.Layer == 1 && csd.Area == aud)
					{
						csd.Location += new Vector3((float)num, 0f, 0f);
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
