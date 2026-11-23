using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200162C RID: 5676
[eiz("TPA")]
[Serializable]
public sealed class dtm : a6k, ISerializable
{
	// Token: 0x06007CAE RID: 31918 RVA: 0x00349938 File Offset: 0x00347B38
	private dtm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007CAF RID: 31919 RVA: 0x00349944 File Offset: 0x00347B44
	public dtm()
	{
	}

	// Token: 0x06007CB0 RID: 31920 RVA: 0x0034994C File Offset: 0x00347B4C
	protected override dc4 dt()
	{
		if (!(base.vg().h() is c5x))
		{
			return dc4.e;
		}
		return dc4.b;
	}

	// Token: 0x06007CB1 RID: 31921 RVA: 0x0034996C File Offset: 0x00347B6C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		b0b b0b = null;
		dvv a_ = es2.a(base.vg().q(), c5x, "psi", 0.5f, null, out b0b, true, 0.5f);
		qy a_2 = new qy();
		this.a(a_2, base.vg().q(), c5x, a_, b0b);
		b0b.Zone.ActionManager.g9(a_2, atp.a);
		dz6.a(a_2);
		if (egy.a(base.vg().q(), c5x))
		{
			eg2 eg = egy.a(base.vg().q());
			egy.a(eg);
			eg.b();
			b0b b0b2 = null;
			dvv a_3 = es2.a(eg.a8(), c5x, "psi", 0.5f, null, out b0b2, false, 0.5f);
			qy qy = new qy();
			qy.ad().Add(new bm3(dz6.b(200)));
			this.a(qy, eg.a8(), c5x, a_3, b0b2);
			b0b2.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
		return dc4.c;
	}

	// Token: 0x06007CB2 RID: 31922 RVA: 0x00349AC8 File Offset: 0x00347CC8
	private void a(qy A_0, c5x A_1, c5x A_2, dvv A_3, b0b A_4)
	{
		A_0.b(false);
		A_0.c(false);
		c5x c5x = A_4 as c5x;
		if (c5x != null && c5x.Zone != null)
		{
			A_1.c().a("telekineticPunch" + Guid.NewGuid().ToString(), "TelekineticPunchLaunch", 1f, c9z.a, false, false);
			b4u aspect = c5x.GetAspect<b4u>();
			if (aspect != null)
			{
				aspect.b().Add(new dtm.a(c5x));
			}
			A_0.ad().Add(A_3);
			c7 item = new c7(A_4, false, false, true, false);
			A_0.ad().Add(item);
		}
		awq.a(A_0, base.vg().q(), A_2, true, true);
		if (A_2.h.b != null)
		{
			cwt a_ = this.b(base.vg().q().h.b.aa(), A_2.h.b.aa());
			akg item2 = new akg(base.vg().q().h.b, A_2.h.b, a_, null, false);
			A_0.ad().Add(item2);
			A_0.ad().Add(new duh(base.vg().q().h.b, new string[]
			{
				b0c.a
			}));
			bfq bfq = new bfq();
			bfq.b("telekineticPunch");
			bfq.c("TelekineticPunchHit");
			A_0.ad().Add(new a4s(bfq, null, new ar7(A_2), null));
			eym.a(A_0, A_2, (double)aju.bn);
			for (int i = 0; i < 5; i++)
			{
				string a_2 = "Psi";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				a7j a7j = new a7j(A_2, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
				a7j.a(new int?((i + 1) * 13));
				a7j.a(new float?((float)((byte)(100 + i * 15))));
				A_0.ad().Add(a7j);
			}
			if (!A_2.h.b.aa().c(d8o.e) && !A_2.h.b.aa().d(CharacterImmunities.Stun))
			{
				if (this.a(base.vg().q().h.b.aa(), A_2.h.b.aa()))
				{
					string str;
					amd item3 = new amd(A_2.h.b, new els[]
					{
						awq.a(A_2.h.b.aa(), dxh.f, out str)
					});
					A_0.ad().Add(item3);
					vr a_7 = new vr(new ap9(A_2.h.b.aa()), new ap9(base.vg().e().b8()), "{0}: " + str + ".", new Color?(adi.j), null);
					if (base.vg().q().IsPlayer && !A_2.IsPlayer)
					{
						cxc.a(eyy.by);
					}
					bey.a(a_7, base.vg().e().b8(), A_2.h.b.aa(), A_2.h.b);
					anw item4 = new anw(a_7);
					A_0.ad().Add(item4);
					return;
				}
				c6f a_8 = new c6f(new ap9(A_2.h.b.aa()), new ap9(base.vg().e().b8()), "оглушению");
				bey.a(a_8, base.vg().e().b8(), A_2.h.b.aa(), A_2.h.b);
				anw item5 = new anw(a_8);
				b8p item6 = new b8p(A_2, new dym());
				A_0.ad().Add(item5);
				A_0.ad().Add(item6);
				return;
			}
			else
			{
				etm a_9 = new etm(new ap9(A_2.h.b.aa()), "оглушению");
				bey.a(a_9, base.vg().e().b8(), A_2.h.b.aa(), A_2.h.b);
				anw item7 = new anw(a_9);
				b8p item8 = new b8p(A_2, new ba0());
				A_0.ad().Add(item7);
				A_0.ad().Add(item8);
			}
		}
	}

	// Token: 0x06007CB3 RID: 31923 RVA: 0x00349F94 File Offset: 0x00348194
	private cwt b(efk A_0, efk A_1)
	{
		bas bas = A_0.Offense.ag()[PsiSchool.Psychokinesis];
		a1q a_ = dxh.b(base.vg().e());
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(euf.a(bas, A_1)));
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.f = new List<csk>
		{
			euf.a(a_, (double)(1f + (cwt.e ? bas.g() : 0f)))
		};
		cwt.l = true;
		cwt.k = "Телекинетический удар";
		cwt.ad["PsionicSource"] = PsiSchool.Psychokinesis;
		return cwt;
	}

	// Token: 0x06007CB4 RID: 31924 RVA: 0x0034A070 File Offset: 0x00348270
	private bool a(efk A_0, efk A_1)
	{
		return !A_1.Passive && !euf.e(dxh.a(base.vg().e()), A_1);
	}

	// Token: 0x0200162D RID: 5677
	[eiz("LTH")]
	[Serializable]
	private new class a : aig, ISerializable
	{
		// Token: 0x06007CB5 RID: 31925 RVA: 0x0034A098 File Offset: 0x00348298
		public a(b0b A_0)
		{
			this.b = new ar7(A_0);
		}

		// Token: 0x06007CB6 RID: 31926 RVA: 0x0034A0B0 File Offset: 0x003482B0
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.c += A_3) >= 0.1f)
			{
				this.c -= 0.1f;
				if (this.b != null && this.b.ao() != null && this.b.ao().Area != null)
				{
					aud a_ = this.b.ao().Area;
					HorizontalDirection? a_2 = null;
					string a_3 = "Psi";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? a_5 = dz6.b();
					c5x c5x = boj.a(a_, A_1, a_2, a_3, a_4, maxValue, null, null, a_5, null);
					e4o e4o = new e4o(c5x);
					e4o.a(100);
					e4o.b(0);
					e4o.a(dz6.a(0.4));
					qy qy = new qy();
					qy.ad().Add(e4o);
					qy.ad().Add(new c7(c5x, false, false, true, false));
					c5x.Zone.ActionManager.g9(qy, atp.a);
				}
			}
			return false;
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x0034A1E0 File Offset: 0x003483E0
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() != 0)
			{
				this.b = (ar7)A_0.GetValue("LTH:ER", typeof(ar7));
				this.c = A_0.GetSingle("LTH:DC");
				return;
			}
			if (base.GetType() == typeof(dtm.a))
			{
				this.b = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
				this.c = A_0.GetSingle("_DistanceCache");
				return;
			}
			this.b = (ar7)A_0.GetValue("LeaveTrailHandler+_EntityRef", typeof(ar7));
			this.c = A_0.GetSingle("LeaveTrailHandler+_DistanceCache");
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x0034A2AC File Offset: 0x003484AC
		public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LTH:ER", this.b);
			info.AddValue("LTH:DC", this.c);
		}

		// Token: 0x0400318B RID: 12683
		private const float a = 0.1f;

		// Token: 0x0400318C RID: 12684
		private ar7 b;

		// Token: 0x0400318D RID: 12685
		private float c;
	}
}
