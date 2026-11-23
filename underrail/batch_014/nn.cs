using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001519 RID: 5401
[eiz("CKS0")]
[Serializable]
public sealed class nn : d64, ISerializable
{
	// Token: 0x060078D0 RID: 30928 RVA: 0x00328AD0 File Offset: 0x00326CD0
	private nn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060078D1 RID: 30929 RVA: 0x00328ADC File Offset: 0x00326CDC
	public nn()
	{
	}

	// Token: 0x060078D2 RID: 30930 RVA: 0x00328AE8 File Offset: 0x00326CE8
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return false;
		}
		ak1 ak = base.vg().h() as ak1;
		if (ak != null)
		{
			double a_ = aw1.a(base.vg().q(), ak);
			int a_2 = euf.b(base.vg().e().b8(), base.vg().e().b8().Skills.Get<ct7>().g(), a_, 0.0);
			ak1 ak2 = awq.a(base.vg().q().t.b, ak, a_2, false);
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			dus dus = chp.a(base.vg().e().b8().Offense.u().TypedDefinition.w(), base.vg().e().b8().Offense.u().CurrentBullet);
			qy.ad().Add(new a4s(new bfq(dus.a), null, new ar7(base.vg().q()), null));
			b0b b0b = null;
			dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), dus.b, out b0b, null, null, true, 0.5f, null);
			if (b0b != null && b0b.Zone != null)
			{
				eym.a(qy, base.vg().q(), (double)dus.c);
				(b0b as c5x).ae = new float?(0f);
				List<auv> list = qy.ad();
				ch3 ch = new ch3();
				ch.a(null);
				list.Add(new a4s(ch, null, new ar7(b0b), null));
				qy.ad().Add(item);
				c7 c = new c7(b0b, false, false, true, false);
				c.a(true);
				qy.ad().Add(c);
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(nn.b.a.a))) as c5x;
				cd1 cd = base.vg().q().h.b.aa().Offense.u();
				bke bke = cd.TypedDefinition;
				if (c5x != null)
				{
					string a_3 = cf0.b(ai5.b, base.vg().e().b8().Offense.u().TypedDefinition.q());
					float num = cf0.a(ai5.b, base.vg().e().b8().Offense.u().TypedDefinition.q());
					string a_4 = cf0.c(ai5.b, base.vg().e().b8().Offense.u().TypedDefinition.q());
					bfq bfq = new bfq();
					bfq.b("BlobHit" + Guid.NewGuid().ToString());
					bfq.c(a_3);
					bfq.a(bvl.c);
					qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
					eym.a(qy, c5x, (double)num);
					qy.ad().Add(new a7j(c5x, a_4, 1, double.MaxValue, true, false, null, null, null, null, false, null));
					if (bke.ak() == AmmoType.Vial_Acid)
					{
						bfq a_5 = new bfq("AcidFizz");
						qy.ad().Add(new a4s(a_5, null, new ar7(c5x), null));
						if (cd.CurrentBullet == AmmoType.Vial_Acid_Corrosive)
						{
							List<auv> list2 = qy.ad();
							c5x a_6 = c5x;
							string a_7 = "CorrosiveAcidSplash";
							int a_8 = 1;
							double maxValue = double.MaxValue;
							bool a_9 = true;
							bool a_10 = true;
							float? a_11 = dz6.b();
							list2.Add(new a7j(a_6, a_7, a_8, maxValue, a_9, a_10, null, null, null, a_11, false, null));
							qy.ad().Add(new a4s(new b69(new edx(ak2), new EntityAspectReference<amc, amc>(base.vg().q().h.b)), null, null, null));
						}
						else if (cd.CurrentBullet == AmmoType.Vial_Acid_Rusting)
						{
							List<auv> list3 = qy.ad();
							c5x a_12 = c5x;
							string a_13 = "RustingAcidSplash";
							int a_14 = 1;
							double maxValue2 = double.MaxValue;
							bool a_15 = true;
							bool a_16 = true;
							float? a_11 = dz6.b();
							list3.Add(new a7j(a_12, a_13, a_14, maxValue2, a_15, a_16, null, null, null, a_11, false, null));
							qy.ad().Add(new a4s(new amg(new edx(ak2), new EntityAspectReference<amc, amc>(base.vg().q().h.b)), null, null, null));
						}
						else if (cd.CurrentBullet == AmmoType.Vial_Acid_Regular)
						{
							List<auv> list4 = qy.ad();
							c5x a_17 = c5x;
							string a_18 = "AcidSplash";
							int a_19 = 1;
							double maxValue3 = double.MaxValue;
							bool a_20 = true;
							bool a_21 = true;
							float? a_11 = dz6.b();
							list4.Add(new a7j(a_17, a_18, a_19, maxValue3, a_20, a_21, null, null, null, a_11, false, null));
							qy.ad().Add(new a4s(new dku(new edx(ak2), new EntityAspectReference<amc, amc>(base.vg().q().h.b), false, true, false), null, null, null));
						}
					}
				}
				ae8? a_22;
				if (cd.CurrentBullet == AmmoType.Vial_Incendiary)
				{
					a_22 = new ae8?(new ae8(Color.White, 1f, LightType.Increment));
				}
				else
				{
					a_22 = null;
				}
				awb awb = new awb(ak2, new nn.a(base.vg().q().h.b, cd.CurrentBullet), a_22, 1f, null, new float?((float)3), false);
				awb.r = true;
				if (bke.ak() == AmmoType.Vial_Cryogel)
				{
					awb.b(25.0);
				}
				qy.ad().Add(awb);
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return true;
		}
		return false;
	}

	// Token: 0x0200151B RID: 5403
	[eiz("CKS0a")]
	[Serializable]
	public new sealed class a : cci, ISerializable
	{
		// Token: 0x060078E0 RID: 30944 RVA: 0x003297AC File Offset: 0x003279AC
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			di7.ReadList<Guid>("CKS0a:AE", ref this.a, A_0);
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("CKS0a:AR", typeof(EntityAspectReference<amc, amc>));
			this.c = (AmmoType)A_0.GetValue("CKS0a:B", typeof(AmmoType));
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x0032981C File Offset: 0x00327A1C
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			di7.WriteList<Guid>("CKS0a:AE", this.a, info);
			info.AddValue("CKS0a:AR", this.b);
			info.AddValue("CKS0a:B", this.c);
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00329858 File Offset: 0x00327A58
		public a(amc A_0, AmmoType A_1)
		{
			this.b = new EntityAspectReference<amc, amc>(A_0);
			this.c = A_1;
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x00329880 File Offset: 0x00327A80
		public void cq(aud A_0, Point A_1, float A_2)
		{
			if (this.c == AmmoType.Vial_Cryogel)
			{
				Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_2 = null;
				string a_3 = "ColdHit";
				int a_4 = 1;
				double maxValue = double.MaxValue;
				float? a_5 = dz6.b();
				boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
			}
			else if (this.c == AmmoType.Vial_Incendiary)
			{
				Vector3 a_6 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_7 = null;
				string a_8 = "ScorchGround";
				int a_9 = 1;
				double maxValue2 = double.MaxValue;
				float? a_5 = dz6.b();
				boj.a(A_0, a_6, a_7, a_8, a_9, maxValue2, null, null, a_5, null);
			}
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				if (A_2 == 0f && this.c == AmmoType.Vial_Incendiary)
				{
					c5x a_10 = null;
					if (this.b != null && this.b.ao() != null)
					{
						a_10 = this.b.ao().a8();
					}
					eu8 a_11 = new eu8(a_10, d8o.g, ak, 6, d0u.b * 2, null);
					A_0.Zone.ActionManager.g9(a_11, atp.a);
					dz6.a(a_11);
				}
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null)
					{
						if (c5x.h.b != null && !this.a.Contains(b0b.qe()))
						{
							this.a(c5x.h.b, A_2);
							this.a.Add(c5x.qe());
						}
						if (this.c == AmmoType.Vial_Incendiary && c5x.y.b != null)
						{
							c5x.y.b.a(null);
							this.a.Add(c5x.qe());
						}
						if (this.c == AmmoType.Vial_Cryogel)
						{
							eks eks = c5x.s.b as eks;
							if (eks != null)
							{
								eks.p();
							}
						}
					}
				}
				if (this.c == AmmoType.Vial_Cryogel)
				{
					dd5.b(ak);
				}
			}
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00329B38 File Offset: 0x00327D38
		private void a(amc A_0, float A_1)
		{
			if (A_0 == null || A_0.a8() == null || this.b == null || this.b.ao() == null)
			{
				return;
			}
			if (!A_0.a8().IsPlayer)
			{
				awq.a(this.b.ao(), A_0, true, true, null, true, true, false, false);
			}
			this.b.ao().aa().Offense.u().TypedDefinition;
			cmn cmn = awq.a(this.b.ao(), A_0, null, new bool?(true));
			cmn.b += cks.a(this.b.ao().aa());
			cwt cwt = euf.a(this.b.ao().aa(), A_0.aa(), 0.0, cmn, 0.0, A_0.a8().l(), this.b.ao().aa().Darkvision, this.c, awq.f(this.b.ao()), 1.0, true, null, null, true, null);
			cwt.q = true;
			cwt.ad["SuppressAcidSpill"] = true;
			akg a_ = new akg(this.b.ao(), A_0, cwt, new vu(null), false);
			A_0.a8().Zone.ActionManager.g9(a_, atp.a);
			dz6.a(a_);
		}

		// Token: 0x04003076 RID: 12406
		private List<Guid> a = new List<Guid>();

		// Token: 0x04003077 RID: 12407
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003078 RID: 12408
		private AmmoType c;
	}

	// Token: 0x0200151C RID: 5404
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x060078E7 RID: 30951 RVA: 0x00329CE4 File Offset: 0x00327EE4
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04003079 RID: 12409
		public static readonly nn.b a = new nn.b();

		// Token: 0x0400307A RID: 12410
		public static Func<b0b, bool> b;
	}
}
