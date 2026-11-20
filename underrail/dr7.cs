using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001697 RID: 5783
[eiz("FA")]
[Serializable]
public sealed class dr7 : h3, ISerializable
{
	// Token: 0x06007E36 RID: 32310 RVA: 0x00357960 File Offset: 0x00355B60
	private dr7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<Guid>("FA:AE", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(dr7))
		{
			this.a = (List<Guid>)A_0.GetValue("_AffectedEntities", typeof(List<Guid>));
			return;
		}
		this.a = (List<Guid>)A_0.GetValue("FlashbangActuator+_AffectedEntities", typeof(List<Guid>));
	}

	// Token: 0x06007E37 RID: 32311 RVA: 0x003579F8 File Offset: 0x00355BF8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("FA:AE", this.a, info);
	}

	// Token: 0x06007E38 RID: 32312 RVA: 0x00357A14 File Offset: 0x00355C14
	public dr7()
	{
	}

	// Token: 0x06007E39 RID: 32313 RVA: 0x00357A2C File Offset: 0x00355C2C
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_2 = null;
		string a_3 = "GroundFlashOfLight";
		int a_4 = 1;
		double maxValue = double.MaxValue;
		float? a_5 = dz6.b();
		boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && c5x.h.b != null && !this.a.Contains(b0b.qe()))
					{
						this.a(c5x.h.b);
						this.a.Add(c5x.qe());
					}
				}
			}
		}
	}

	// Token: 0x06007E3A RID: 32314 RVA: 0x00357B64 File Offset: 0x00355D64
	private void a(amc A_0)
	{
		if (base.c() != null)
		{
			if (!A_0.a8().IsPlayer && !A_0.aa().Passive && !A_0.aa().c(d8o.e))
			{
				awq.a(base.c(), A_0, true, true, null, true, true, false, false);
			}
			A_0.u();
			if (!A_0.aa().Passive)
			{
				if (A_0.aa().d(CharacterImmunities.Incapacitation | CharacterImmunities.Blind) || A_0.aa().c(d8o.e))
				{
					etm a_ = new etm(new ap9(A_0.aa()), "воздействию светошумовой гранаты");
					bey.a(a_, A_0.aa(), A_0);
					a7v.a(a_);
					bmj.a(A_0.a8(), new ba0());
					return;
				}
				bool flag = A_0.aa().StatusEffects.a(ame.a);
				if (!flag && euf.f(c0p.c(), A_0.aa()))
				{
					c6f a_2 = new c6f(new ap9(A_0.aa()), null, "воздействию светошумовой гранаты");
					bey.a(a_2, A_0.aa(), A_0);
					a7v.a(a_2);
					bmj.a(A_0.a8(), new dym());
					return;
				}
				cjy a_3 = new cjy(c0p.b());
				A_0.aa().StatusEffects.a(a_3, false, false, false);
				A_0.aa().bl();
				if (!(A_0.aa() is e3q) && base.c() != null && base.c().aa() is e3q)
				{
					cxc.a(eyy.b0);
				}
				if (A_0.a8() != null && A_0.a8().t.b != null)
				{
					A_0.a8().t.b.ah();
				}
				vr a_4 = new vr(new ap9(A_0.aa()), null, "{0}: ошеломление.", new Color?(adi.j), null);
				bey.a(a_4, A_0.aa(), A_0);
				a7v.a(a_4);
				if (!A_0.aa().SpecialStates.a && !A_0.aa().SpecialStates.h)
				{
					a20.a(A_0.a8(), new ap9(base.c().aa()), new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Hit_Flashbang
					});
				}
				if (flag)
				{
					eok a_5 = new eok(c0p.a());
					A_0.aa().StatusEffects.a(a_5, false, false, false);
					A_0.aa().bl();
					vr a_6 = new vr(new ap9(A_0.aa()), null, "{0}: дезориентация.", new Color?(adi.j), null);
					bey.a(a_6, A_0.aa(), A_0);
					a7v.a(a_6);
				}
			}
		}
	}

	// Token: 0x0400321E RID: 12830
	private new List<Guid> a = new List<Guid>();
}
