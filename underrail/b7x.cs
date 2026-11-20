using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200140D RID: 5133
[eiz("OHE")]
[Serializable]
public sealed class b7x : enp
{
	// Token: 0x06007345 RID: 29509 RVA: 0x00309348 File Offset: 0x00307548
	private b7x(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("OHE:I", typeof(enp)) as enp);
	}

	// Token: 0x06007346 RID: 29510 RVA: 0x00309370 File Offset: 0x00307570
	public void a(SerializationInfo A_0, StreamingContext A_1)
	{
		A_0.AddValue("OHE:I", this.a);
	}

	// Token: 0x06007347 RID: 29511 RVA: 0x00309384 File Offset: 0x00307584
	public b7x(enp A_0 = null)
	{
		this.a = A_0;
	}

	// Token: 0x06007348 RID: 29512 RVA: 0x00309398 File Offset: 0x00307598
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_1.a8().Zone != null && A_2 != null)
		{
			d2v a_ = new d2v(A_2, new EntityAspectReference<amc, amc>(A_0), new EntityAspectReference<amc, amc>(A_1), A_3);
			A_1.a8().Zone.ActionManager.g9(a_, atp.a);
			dz6.a(a_);
			if (A_0 != null && A_0.a8() != null)
			{
				if (A_3 != null && A_3.c && A_0.aa().Feats.Contains<bjg>())
				{
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						d4n d4n = service.ahu(A_0.aa());
						if (d4n != null && service.ahe() == d4n)
						{
							bm1 bm = Enumerable.FirstOrDefault<bm1>(A_0.aa().StatusEffects.Get<bm1>());
							int num = bjg.a(A_0.aa(), (bm != null) ? bm.Stacks : 0);
							if (d4n.d < (double)A_0.aa().Offense.m() && d4n.d < (double)num)
							{
								int num2 = Math.Min(A_0.aa().Offense.m(), num) - (int)d4n.d;
								d4n.d = (double)Math.Min(A_0.aa().Offense.m(), num);
								if (num2 >= 1)
								{
									bmj.a(A_0.a8(), new d53(string.Format("+{0} ед. передвижения{1}", num2, (num2 > 1) ? "" : ""), adi.ao, "HitAndRun", false));
									vr a_2 = new vr(new ap9(A_0.aa()), null, string.Concat(new string[]
									{
										"{0} восстановлено ",
										num2.ToString(),
										" ед. передвижения",
										(num2 > 1) ? "" : "",
										" благодаря тактике «бей и беги»."
									}), new Color?(adi.ao), null);
									bey.a(a_2, A_0.aa(), A_0);
									a7v.a(a_2);
									A_0.aa().StatusEffects.a(new bm1(), false, false, false);
								}
							}
						}
					}
				}
				if (A_3 != null && A_3.c && A_2 != null && A_2.ae != null && euf.a(A_2.ae.Value, WeaponAggregateSubtype.HeavyGun) && A_0.aa().Feats.Contains<ap6>())
				{
					crt a_3 = new crt(ap6.b(A_0.aa()), ap6.c(A_0.aa()), ap6.a(A_0.aa()));
					A_0.aa().StatusEffects.a(a_3, false, false, false);
				}
				if (A_2.b && A_0.aa().Feats.Contains<aq0>() && A_2.z && A_3.c && !A_1.aa().Passive && !A_1.aa().c(d8o.e))
				{
					int num3 = 1;
					ezn microfeat = A_0.aa().GetMicrofeat<ezn>();
					if (microfeat != null && cuo.a.NextDouble() < microfeat.a())
					{
						num3++;
					}
					dd dd = new dd(aq0.c * d0u.b);
					dd.Stacks = num3;
					A_0.aa().StatusEffects.a(dd, false, false, false);
				}
			}
		}
		if (this.a != null)
		{
			this.a.af(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x04002F22 RID: 12066
	private enp a;
}
