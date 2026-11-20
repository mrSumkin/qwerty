using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001200 RID: 4608
[eiz("EWX")]
[Serializable]
public sealed class ba9 : cos, ISerializable, enp
{
	// Token: 0x06006301 RID: 25345 RVA: 0x002AC52C File Offset: 0x002AA72C
	private ba9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 632)
		{
			this.a = A_0.GetInt32("EWX:S");
		}
	}

	// Token: 0x06006302 RID: 25346 RVA: 0x002AC558 File Offset: 0x002AA758
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EWX:S", this.a);
	}

	// Token: 0x06006303 RID: 25347 RVA: 0x002AC574 File Offset: 0x002AA774
	public ba9(c5x A_0, int A_1) : base(A_0, null)
	{
		this.a = A_1;
	}

	// Token: 0x06006304 RID: 25348 RVA: 0x002AC588 File Offset: 0x002AA788
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null)
		{
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			if (A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ba9.a.a.a)), new Func<csk, int>(ba9.a.a.b)) > 0)
				{
					if (A_0 != null && A_0.aa().Feats.Contains<e59>())
					{
						A_1.aa().StatusEffects.a(new cyi(A_0.aa()), false, false, false);
					}
					if (A_1.aa().Passive || (A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.ShortCircuiting)) || (!A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.Stun)))
					{
						etm a_;
						if (A_1.aa().c(d8o.e))
						{
							a_ = new etm(new ap9(A_1.aa()), "короткому замыканию");
						}
						else
						{
							a_ = new etm(new ap9(A_1.aa()), "оглушению");
						}
						bey.a(a_, null, A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
					}
					else
					{
						els els;
						if (A_1.aa().c(d8o.e))
						{
							els = new clt(ehf.f * d0u.b);
						}
						else
						{
							els = awq.a(A_1.aa(), ehf.f * d0u.b);
						}
						dtb.ad().Add(new amd(A_1, new els[]
						{
							els
						}));
					}
				}
			}
			A_1.a8().Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}
	}

	// Token: 0x06006305 RID: 25349 RVA: 0x002AC790 File Offset: 0x002AA990
	protected override bool kr(c5x A_0, c5x A_1, bool A_2)
	{
		if (base.Area != null && base.Area.Zone != null && A_1 != null && A_1.l.Count > 0)
		{
			ed2 ed = A_1.GetAspect<b4h>() as ed2;
			if (A_0 != null && A_0.h.b != null && ed != null)
			{
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				amc amc = base.f();
				cwt cwt = new cwt();
				a1q a_;
				if (amc != null)
				{
					cwt.i = new ap9(amc.aa());
					a_ = ehf.a(new eoj(amc.aa(), null, null));
				}
				else
				{
					a_ = ehf.a(this.a);
				}
				cwt.j = new ap9(A_0.h.b.aa());
				cwt.l = true;
				cwt.f.Add(euf.a(a_, 1.0));
				cwt.v = "электрокинетический отпечаток";
				cwt.b = true;
				cwt.h = ImpactSpeed.VeryHigh;
				akg item = new akg(ed.a(), A_0.h.b, cwt, this, false);
				qy.ad().Add(item);
				qy.ad().Add(new aro(A_0.h.b));
				if (amc != null && !A_0.h.b.aa().Passive && eir.a(A_0.Zone, A_0.h.b.aa().FactionId) != ZoneControlLevel.Uncontrolled)
				{
					qy.ad().Add(new a27(amc, A_0.h.b, false, false, false, false));
				}
				qy.ad().Add(new aro(A_0.h.b));
				List<auv> list = qy.ad();
				string a_2 = "Electricity";
				int maxValue = int.MaxValue;
				double a_3 = (double)dz6.b(300);
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				list.Add(new a7j(A_0, a_2, maxValue, a_3, a_4, a_5, null, null, null, a_6, false, null));
				qy.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(A_0), null));
				eym.a(qy, A_0, (double)aju.bf);
				qy.ad().Add(new c7(A_1, false, false, true, false));
				base.Area.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
			return true;
		}
		return false;
	}

	// Token: 0x040029C8 RID: 10696
	public new int a;

	// Token: 0x02001201 RID: 4609
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006308 RID: 25352 RVA: 0x002ACA58 File Offset: 0x002AAC58
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x002ACA64 File Offset: 0x002AAC64
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040029C9 RID: 10697
		public static readonly ba9.a a = new ba9.a();

		// Token: 0x040029CA RID: 10698
		public static Func<csk, bool> b;

		// Token: 0x040029CB RID: 10699
		public static Func<csk, int> c;
	}
}
