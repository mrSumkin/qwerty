using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02002182 RID: 8578
[bmq("1.0.3.2_HangingRatExpansion", "9.9.9.9", "lux-b11", false)]
public sealed class acp : fg
{
	// Token: 0x0600C953 RID: 51539 RVA: 0x00472164 File Offset: 0x00470364
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("c043c9db-8a2c-4014-81b7-a3cf5c170ada"), A_1.n("lux-b11")).ao() as c5x;
			if (c5x != null && c5x.t.b != null && c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay) == null)
			{
				c5x.t.b.y6()[ddq.ay] = new bt4("guard_joel");
			}
			if ((new ar7(new Guid("da2d7836-5648-4c41-9be0-864315ed7c71"), A_1.n("lux-b11")).ao() as c5x).Location.Y != 12f)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(A_1.n("lux-b11").Entities))
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2 != null && c5x2.Layer == aju.x && (c5x2.t.b == null || (c5x2.t.b != null && c5x2.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay) != null && !c5x2.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b().Contains("global"))))
					{
						c5x2.Location = new Vector3(c5x2.Location.X, c5x2.Location.Y + 5f, c5x2.Location.Z);
						c5x2.ah();
					}
				}
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "lux-b11_l" + 2.ToString()) + ".uzl");
			A_1.a(a_, 99, null);
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b2 in aud.Entities)
				{
					c5x c5x3 = (c5x)b0b2;
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
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
