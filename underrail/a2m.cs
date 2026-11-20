using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200129C RID: 4764
[eiz("HGEA6")]
[Serializable]
public sealed class a2m : cry, ISerializable, chb, c98
{
	// Token: 0x06006812 RID: 26642 RVA: 0x002C0784 File Offset: 0x002BE984
	private a2m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006813 RID: 26643 RVA: 0x002C0790 File Offset: 0x002BE990
	public override string gv()
	{
		return "hiveGas";
	}

	// Token: 0x06006814 RID: 26644 RVA: 0x002C0798 File Offset: 0x002BE998
	public override bool gw()
	{
		return false;
	}

	// Token: 0x06006815 RID: 26645 RVA: 0x002C079C File Offset: 0x002BE99C
	public a2m(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06006816 RID: 26646 RVA: 0x002C07AC File Offset: 0x002BE9AC
	public override void gx(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0 && cuo.a.NextDouble() < 0.2)
		{
			this.a(A_0.h.b);
		}
	}

	// Token: 0x06006817 RID: 26647 RVA: 0x002C0864 File Offset: 0x002BEA64
	protected override void gy(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0)
		{
			this.a(A_0.h.b);
		}
	}

	// Token: 0x06006818 RID: 26648 RVA: 0x002C0904 File Offset: 0x002BEB04
	private void a(amc A_0)
	{
		List<zh> list = A_0.aa().StatusEffects.Get<zh>();
		if (list != null)
		{
			foreach (zh zh in list)
			{
				if (zh.b())
				{
					List<ak1> list2 = aw1.b(A_0.a8(), false);
					if (list2 != null && list2.Count > 0)
					{
						A_0.a8().c().a("Xpbl_StriderInfestationExpires");
						boj.a(A_0.a8(), "Xpbl_StriderInfestationBurst", 1, double.MaxValue, true, true, null, null, null, null, false);
						cwt cwt = new cwt();
						cwt.i = new ap9("Parasitic Infestation", null);
						cwt.f.Add(euf.a(zh.d, 1.0));
						cwt.l = true;
						cwt.p = true;
						cwt.r = false;
						cwt.b = true;
						cwt.w = true;
						A_0.aa().Defense.a(cwt);
						string text;
						if (A_0.aa().b(d8o.l))
						{
							text = "WaterStriderSpawn";
						}
						else
						{
							text = "StriderSpawn";
						}
						bt4 a_ = new bt4(A_0.a8().Area.y8(), list2[cuo.a.Next(list2.Count)].Location.a());
						c5x c5x = vq.a("Creatures\\Xpbl\\" + text, base.a8().Zone, a_, false);
						if (c5x != null)
						{
							if (text == "WaterStriderSpawn")
							{
								cya.b(c5x);
							}
							a0l.a(c5x, c5x.Area, c5x.Location, new HorizontalDirection?((HorizontalDirection)cuo.a.Next(8)), true);
						}
						A_0.aa().StatusEffects.d(zh);
					}
				}
			}
			A_0.aa().bl();
		}
	}
}
