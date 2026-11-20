using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02000AE8 RID: 2792
[eiz("XPBLMJSADJC")]
[Serializable]
public sealed class rd : cze, ISerializable
{
	// Token: 0x060040F0 RID: 16624 RVA: 0x0018C140 File Offset: 0x0018A340
	private rd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040F1 RID: 16625 RVA: 0x0018C14C File Offset: 0x0018A34C
	public rd()
	{
	}

	// Token: 0x060040F2 RID: 16626 RVA: 0x0018C154 File Offset: 0x0018A354
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		amc b = (A_0 as c5x).h.b;
		if (aud != null && b != null)
		{
			for (int i = 20; i <= 26; i++)
			{
				for (int j = 23; j <= 27; j++)
				{
					ak1 ak = aud.b(i, j);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							wv wv = ((c5x)b0b).GetAspect<bim>() as wv;
							if (wv != null && wv.g().b(b.aa()))
							{
								awx awx = new awx();
								awx.a(m7.b);
								awx.a(false);
								awx.ad().Add(new kp(wv, b));
								awx.ad().Add(new a4s(new bfq("climb", "ClimbRocks"), null, null, null));
								(A_0 as c5x).i.b.b(awx, atp.a);
								return;
							}
						}
					}
				}
			}
		}
		bmj.a(A_0 as c5x, new ccq(ScrollingCombatTextOptions.Mandatory, "Вам нужно корыто, на который можно спуститься.", adi.l, null, false));
		a7v.a(new h0("Вам нужно корыто, на который можно спуститься.", new Color?(adi.l)));
	}
}
