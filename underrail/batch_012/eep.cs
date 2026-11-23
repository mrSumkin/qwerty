using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000BC5 RID: 3013
[euj]
public class eep
{
	// Token: 0x0600450A RID: 17674 RVA: 0x001C0F7C File Offset: 0x001BF17C
	[ayh("TCHMU2JSBO")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		aud aud = cze.a(null, A_0, A_1, A_2);
		if (aud != null && aud.Zone != null)
		{
			aud.Zone.a();
			foreach (Vector2 vector in new List<Vector2>
			{
				new Vector2(23f, 2f),
				new Vector2(27f, 2f),
				new Vector2(25f, 2f),
				new Vector2(30f, 4f),
				new Vector2(32f, 2f),
				new Vector2(38f, 2f),
				new Vector2(30f, 8f),
				new Vector2(30f, 11f),
				new Vector2(32f, 13f),
				new Vector2(34f, 12f),
				new Vector2(34f, 14f),
				new Vector2(34f, 18f),
				new Vector2(34f, 5f),
				new Vector2(35f, 3f),
				new Vector2(37f, 5f),
				new Vector2(38f, 2f),
				new Vector2(30f, 8f),
				new Vector2(20f, 9f),
				new Vector2(20f, 12f)
			})
			{
				new e3d(new edx(aud.b((int)vector.X, (int)vector.Y)), null, false, true).ym(A_0, A_1, A_2);
			}
		}
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x001C11AC File Offset: 0x001BF3AC
	[ayh("TCHMU2JDPH")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			A_0 = A_1;
		}
		if (A_0 != null)
		{
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.p = true;
			cwt.l = true;
			cwt.f.Add(new csk(DamageType.Mechanical, cuo.a.Next(100, 151)));
			cwt.y = "{2} получает ";
			string text = "";
			e3l aspect = A_0.GetAspect<e3l>();
			if (aspect.a[0].Contains("Gas"))
			{
				text = "tch_mu2_gasSource";
			}
			else if (aspect.a[0].Contains("Vent"))
			{
				text = "tch_mu2_ventSource";
			}
			else if (aspect.a[0].Contains("Upper"))
			{
				text = "tch_mu2_upperSource";
			}
			if (text.Length > 2)
			{
				c5x c5x = A_0.Zone.GetAddon<d60>().ab5(text) as c5x;
				if (c5x != null)
				{
					akg a_ = new akg(null, c5x.h.b, cwt, null, false);
					A_0.Zone.ActionManager.g9(a_, atp.a);
				}
			}
		}
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x001C12DC File Offset: 0x001BF4DC
	[ayh("TCHMU2ADB")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null)
		{
			A_1.h.b.aa().Passive = false;
			A_1.h.b.aa().FactionId = asp.eo;
		}
	}
}
