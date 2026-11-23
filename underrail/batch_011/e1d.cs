using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001260 RID: 4704
[eiz("BOL0")]
[Serializable]
public sealed class e1d : Aspect<c5x>, ISerializable, cmm
{
	// Token: 0x060065D3 RID: 26067 RVA: 0x002B5880 File Offset: 0x002B3A80
	private e1d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("BOL0:L");
		this.c = A_0.GetString("BOL0:O");
	}

	// Token: 0x060065D4 RID: 26068 RVA: 0x002B58BC File Offset: 0x002B3ABC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BOL0:L", this.b);
		info.AddValue("BOL0:O", this.c);
	}

	// Token: 0x060065D5 RID: 26069 RVA: 0x002B58E8 File Offset: 0x002B3AE8
	public double b()
	{
		return this.b;
	}

	// Token: 0x060065D6 RID: 26070 RVA: 0x002B58F0 File Offset: 0x002B3AF0
	public e1d(c5x A_0, string A_1) : base(A_0)
	{
		this.c = A_1;
	}

	// Token: 0x060065D7 RID: 26071 RVA: 0x002B5910 File Offset: 0x002B3B10
	public void a(double A_0)
	{
		this.b += A_0;
		this.a();
	}

	// Token: 0x060065D8 RID: 26072 RVA: 0x002B5928 File Offset: 0x002B3B28
	public void d()
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
					int num = (int)Math.Max(1.0, this.b * 1.5);
					if (d4n != null && d4n == service.ahe())
					{
						d4n.b(num, true);
						vr a_ = new vr(new ap9(c5x.h.b.aa()), null, "{0} потерянох20" + num.ToString() + " очков передвижения из-за попадания в липкое масло.", new Color?(adi.j), null);
						bey.a(a_, c5x.h.b.aa(), c5x.h.b);
						a7v.a(a_);
						bmj.a(c5x, new ccq(ScrollingCombatTextOptions.Damage, string.Format("-{0} очков передвижения (масло)", num), adi.j, null, false));
					}
					c5x.h.b.aa().StatusEffects.a(new eff(d0u.b * 2, (float)num * -0.1f), false, false, false);
				}
			}
		}
	}

	// Token: 0x060065D9 RID: 26073 RVA: 0x002B5B28 File Offset: 0x002B3D28
	public void a(c5x A_0)
	{
		if (A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().d(CharacterImmunities.Slow))
		{
			d02 service = bpo.GetService<d02>();
			d4n d4n = service.ahu(A_0.h.b.aa());
			int num = (int)Math.Max(1.0, this.b * 1.5);
			if (d4n != null && d4n == service.ahe())
			{
				d4n.b(num, true);
				vr a_ = new vr(new ap9(A_0.h.b.aa()), null, "{0} потерянох20" + num.ToString() + " очков передвижения из-за попадания в липкое масло.", new Color?(adi.j), null);
				bey.a(a_, A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ccq(ScrollingCombatTextOptions.Damage, string.Format("-{0} очков передвижения (масло)", num), adi.j, null, false));
			}
			A_0.h.b.aa().StatusEffects.a(new eff(d0u.b * 2, (float)num * -0.1f), false, false, false);
		}
	}

	// Token: 0x060065DA RID: 26074 RVA: 0x002B5C90 File Offset: 0x002B3E90
	public void c9(TimeSpan A_0)
	{
	}

	// Token: 0x060065DB RID: 26075 RVA: 0x002B5C94 File Offset: 0x002B3E94
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060065DC RID: 26076 RVA: 0x002B5C98 File Offset: 0x002B3E98
	public void r7(eds A_0)
	{
	}

	// Token: 0x060065DD RID: 26077 RVA: 0x002B5C9C File Offset: 0x002B3E9C
	private bool a()
	{
		if (this.b > 5.0)
		{
			this.b = 5.0;
		}
		if (this.b <= 0.0 && base.a8().Zone != null)
		{
			this.a(0);
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				List<ya> list = ak.a(typeof(avy));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						avy avy = ya as avy;
						if (avy != null && avy.a() != null && avy.a().ao() == this)
						{
							avy.o();
						}
					}
				}
			}
			c7 a_ = new c7(base.a8(), true, true, false, false);
			base.a8().Zone.ActionManager.g9(a_, atp.a);
			dz6.a(a_);
			return true;
		}
		int a_2 = (int)Math.Round(this.b, 0);
		this.a(a_2);
		return false;
	}

	// Token: 0x060065DE RID: 26078 RVA: 0x002B5DEC File Offset: 0x002B3FEC
	private void a(int A_0)
	{
		if (base.a8().o.b != null)
		{
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, A_0);
		}
	}

	// Token: 0x04002A59 RID: 10841
	private const double a = 5.0;

	// Token: 0x04002A5A RID: 10842
	private double b = 0.1;

	// Token: 0x04002A5B RID: 10843
	private string c;
}
