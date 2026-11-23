using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200127D RID: 4733
[eiz("SGRWEA")]
[Serializable]
public sealed class e6o : Aspect<c5x>, ISerializable, cmm, bwt
{
	// Token: 0x060066D2 RID: 26322 RVA: 0x002BAC80 File Offset: 0x002B8E80
	private e6o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060066D3 RID: 26323 RVA: 0x002BAC8C File Offset: 0x002B8E8C
	public e6o(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066D4 RID: 26324 RVA: 0x002BAC98 File Offset: 0x002B8E98
	public void a()
	{
		ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
		if (ak != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && !c5x.h.b.aa().Passive && !c5x.h.b.aa().d(CharacterImmunities.Slow) && c5x.aj().a() == ak.Location)
				{
					d02 service = bpo.GetService<d02>();
					d4n d4n = service.ahu(c5x.h.b.aa());
					int num = 5;
					if (d4n != null && d4n == service.ahe())
					{
						d4n.b(num, true);
						vr a_ = new vr(new ap9(c5x.h.b.aa()), null, "{0} потерянох20" + num.ToString() + " очков передвижения из-за попадания в липкую паутину.", new Color?(adi.j), null);
						bey.a(a_, c5x.h.b.aa(), c5x.h.b);
						a7v.a(a_);
						bmj.a(c5x, new ccq(ScrollingCombatTextOptions.Damage, string.Format("-{0} очков передвижения (паутина)", num), adi.j, null, false));
					}
					c5x.h.b.aa().StatusEffects.a(new anq(d0u.b * 2, (float)num * -0.1f), false, false, false);
				}
			}
		}
	}

	// Token: 0x060066D5 RID: 26325 RVA: 0x002BAE78 File Offset: 0x002B9078
	public void a(c5x A_0)
	{
		if (A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().d(CharacterImmunities.Slow))
		{
			d02 service = bpo.GetService<d02>();
			d4n d4n = service.ahu(A_0.h.b.aa());
			int num = 5;
			if (d4n != null && d4n == service.ahe())
			{
				d4n.b(num, true);
				vr a_ = new vr(new ap9(A_0.h.b.aa()), null, "{0} потерянох20" + num.ToString() + " очков передвижения из-за попадания в липкую паутину.", new Color?(adi.j), null);
				bey.a(a_, A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ccq(ScrollingCombatTextOptions.Damage, string.Format("-{0} очков передвижения (паутина)", num), adi.j, null, false));
			}
			A_0.h.b.aa().StatusEffects.a(new anq(d0u.b * 2, (float)num * -0.1f), false, false, false);
		}
	}

	// Token: 0x060066D6 RID: 26326 RVA: 0x002BAFC0 File Offset: 0x002B91C0
	public void c9(TimeSpan A_0)
	{
	}

	// Token: 0x060066D7 RID: 26327 RVA: 0x002BAFC4 File Offset: 0x002B91C4
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060066D8 RID: 26328 RVA: 0x002BAFC8 File Offset: 0x002B91C8
	public void r7(eds A_0)
	{
	}

	// Token: 0x060066D9 RID: 26329 RVA: 0x002BAFD0 File Offset: 0x002B91D0
	public ya av8()
	{
		if (base.a8() != null && base.a8().Area != null)
		{
			foreach (ak1 ak in base.a8().l)
			{
				List<ya> list = ak.a(typeof(dkn));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						dkn dkn = ya as dkn;
						if (dkn != null && dkn.a() != null && dkn.a().ao() == this)
						{
							return dkn;
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060066DA RID: 26330 RVA: 0x002BB0D8 File Offset: 0x002B92D8
	public static c5x a(ak1 A_0)
	{
		if (A_0 == null || A_0.Area == null || aw1.a(A_0, true, null, l9.a))
		{
			return null;
		}
		using (IEnumerator<b0b> enumerator = A_0.c.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((c5x)enumerator.Current).GetAspect<e6o>() != null)
				{
					return null;
				}
			}
		}
		c5x c5x = new c5x();
		c5x.Layer = aju.x;
		c5x.Location = A_0.Location.a();
		c5x.Size = new Vector3(1f, 1f, 0.1f);
		c5x.IsGround = true;
		c5x.VisualPriority = 1;
		c5x.SetAspect<cd0>(new cd0(c5x)
		{
			a = "Floor\\xpbl_SpitSpiderWebGround",
			b = new Point(cuo.a.Next(8), 0)
		});
		e6o e6o = new e6o(c5x);
		c5x.SetAspect<e6o>(e6o);
		ef9 aspect = new ef9(c5x);
		c5x.SetAspect<ce1>(aspect);
		A_0.Area.a(c5x);
		dkn dkn = new dkn(e6o);
		dkn.Layer = aju.x;
		dkn.Location = A_0.Location;
		dkn.Size = new esj(1, 1);
		A_0.Area.b(dkn);
		return c5x;
	}
}
