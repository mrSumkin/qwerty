using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020017BA RID: 6074
[eiz("TDXA")]
[bs6("TemporalDistorsionExpiresAction")]
[Serializable]
public sealed class bos : bhv, ISerializable
{
	// Token: 0x060081BA RID: 33210 RVA: 0x003696BC File Offset: 0x003678BC
	private bos(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081BB RID: 33211 RVA: 0x003696CC File Offset: 0x003678CC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && !base.x2().aa().Dead && base.x2().a8() != null && base.x2().a8().j == cgy.b && base.x2().a8().Zone != null)
		{
			bha bha = base.xy() as bha;
			if (bha != null)
			{
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				int a_ = (int)(400.0 * cuo.a.NextDouble() * (double)dz6.b().GetValueOrDefault(1f));
				qy.ad().Add(new bm3(a_));
				bfq bfq = new bfq();
				bfq.b("xpbl_TemporalDistorsionHit" + Guid.NewGuid().ToString());
				bfq.c("xpbl_TemporalDistorsionHit");
				bfq.d.a = true;
				bfq.d.b = "temporalDistortion";
				bfq.d.c = 250;
				qy.ad().Add(new a4s(bfq, null, new ar7(base.x2().a8()), null));
				eym.a(qy, base.x2().a8(), (double)aju.bt);
				List<auv> list = qy.ad();
				c5x a_2 = base.x2().a8();
				string a_3 = "Xpbl_TemporalDistorsionDamage";
				int a_4 = 1;
				double maxValue = double.MaxValue;
				bool a_5 = true;
				bool a_6 = true;
				float? a_7 = dz6.b();
				list.Add(new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null));
				qy.ad().Add(new bm3((int)(500f * dz6.b().GetValueOrDefault(1f))));
				cwt cwt = new cwt();
				cwt.i = bha.e();
				cwt.j = new ap9(base.x2().aa());
				cwt.l = true;
				cwt.o = ed3.i;
				cwt.b = true;
				cwt.k = "Временное искажение";
				cwt.h = ImpactSpeed.VeryHigh;
				cwt.ad["PsionicSource"] = PsiSchool.TemporalManipulation;
				foreach (a1q a_8 in new a1q[]
				{
					bha.a(),
					bha.c()
				})
				{
					cwt.f.Add(euf.a(a_8, bha.b()));
				}
				qy.ad().Add(new akg(base.x2(), base.x2(), cwt, null, false));
				if (bha.f())
				{
					d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
					cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow2.aqu() != null)
					{
						foreach (d4n d4n in serviceOrThrow.ahl())
						{
							if (d4n.b != null && d4n.b != base.x2() && d4n.b.a8() != null && d4n.b.a8().t.b != null && d4n.b.aa().FactionId != bha.e().b && d4n.b.aa().a(serviceOrThrow2.aqu().ac(), bha.e().b) == h.a && !d4n.b.aa().d(CharacterImmunities.TemporalEffects) && aw1.b(d4n.b.a8(), base.x2().a8()) <= 5.0)
							{
								bool flag = false;
								foreach (ak1 a_9 in base.x2().a8().l)
								{
									if (d4n.b.a8().t.b.a(a_9))
									{
										flag = true;
										break;
									}
								}
								if (flag && cuo.a.NextDouble() < bha.d())
								{
									qy.ad().Add(new bm3(a_));
									bfq a_10 = new bfq();
									bfq.b("xpbl_TemporalDistorsionApply" + Guid.NewGuid().ToString());
									bfq.c("xpbl_TemporalDistorsionApply");
									bfq.d.a = true;
									bfq.d.b = "temporalDistortion";
									bfq.d.c = 100;
									qy.ad().Add(new a4s(a_10, null, new ar7(d4n.b.a8()), null));
									c5x a_11 = d4n.b.a8();
									string a_12 = "Xpbl_TemporalDistorsionApply";
									int a_13 = 1;
									double maxValue2 = double.MaxValue;
									bool a_14 = true;
									bool a_15 = true;
									a_7 = dz6.b();
									a7j item = new a7j(a_11, a_12, a_13, maxValue2, a_14, a_15, null, null, null, a_7, false, null);
									qy.ad().Add(item);
									qy.ad().Add(new e2t(new EntityAspectReference<amc, amc>(d4n.b), bha.e(), bha.a(), bha.c()));
								}
							}
						}
					}
				}
				base.x2().a8().Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x060081BC RID: 33212 RVA: 0x00369CFC File Offset: 0x00367EFC
	public bos()
	{
	}
}
