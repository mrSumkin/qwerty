using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020011EA RID: 4586
[eiz("ABT1")]
[Serializable]
public sealed class atm : cos, ISerializable
{
	// Token: 0x0600627D RID: 25213 RVA: 0x002A9224 File Offset: 0x002A7424
	private atm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 586)
		{
			this.a = A_0.GetBoolean("ABT1:A");
			return;
		}
		this.a = true;
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x002A9260 File Offset: 0x002A7460
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ABT1:A", this.a);
	}

	// Token: 0x0600627F RID: 25215 RVA: 0x002A927C File Offset: 0x002A747C
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x002A9284 File Offset: 0x002A7484
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x002A9290 File Offset: 0x002A7490
	protected override bool kr(c5x A_0, c5x A_1, bool A_2)
	{
		if (base.Area != null && base.Area.Zone != null && A_1 != null && A_1.l.Count > 0)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			ed2 ed = A_1.GetAspect<b4h>() as ed2;
			if (!A_2 && A_0 != null && A_0.h.b != null && ed != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(atm.a.a.a))) as c5x;
				if (c5x != null)
				{
					if (this.a)
					{
						c5x.c().a("activated", "ChemicalTrapActivate", 1f, c9z.a, false, false);
					}
					qy.ad().Add(new cw(A_1));
					qy.ad().Add(new bm3(dz6.b(500)));
				}
				bfq a_ = new bfq("AcidBlobBigHit");
				qy.ad().Add(new a4s(a_, null, new ar7(A_0), null));
				string a_2 = "acidSplash";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				a7j item = new a7j(A_0, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
				qy.ad().Add(item);
				if (A_0.h.b.aa().d(CharacterImmunities.Root))
				{
					if (ed.a() != null)
					{
						etm a_7 = new etm(new ap9(A_0.h.b.aa()), "обездвиживанию");
						bey.a(a_7, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
						anw item2 = new anw(a_7);
						qy.ad().Add(item2);
					}
					b8p item3 = new b8p(A_0, new ba0());
					qy.ad().Add(item3);
				}
				else if (euf.k(A_0.h.b.aa()))
				{
					bjq a_8 = new bjq(new ap9(A_0.h.b.aa()), null, "кислотного опутывания");
					bey.a(a_8, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_8);
					bmj.a(A_0, new bgj());
				}
				else
				{
					csk csk = euf.a(c18.l(c18.a(base.TrapItem)), 1.0);
					amd item4 = new amd(A_0.h.b, new els[]
					{
						new e32((ed.a() != null) ? ed.a().aa() : null, c18.bg * d0u.b, (int)Math.Max(1.0, (double)csk.Amount / (double)c18.bg))
					});
					qy.ad().Add(item4);
					qy.ad().Add(new aro(A_0.h.b));
					if (ed.a() != null)
					{
						vr a_9 = new vr(new ap9(A_0.h.b.aa()), null, "{0}: опутывание.", new Color?(adi.j), null);
						bey.a(a_9, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
						anw item5 = new anw(a_9);
						qy.ad().Add(item5);
					}
				}
				amc amc = base.f();
				if (amc != null && !A_0.h.b.aa().Passive && eir.a(A_0.Zone, A_0.h.b.aa().FactionId) != ZoneControlLevel.Uncontrolled)
				{
					qy.ad().Add(new a27(amc, A_0.h.b, false, false, false, false));
				}
			}
			qy.ad().Add(new c7(A_1, false, false, true, false));
			qy.ad().Add(new a4s(new dku(new edx(A_1.l[0]), new EntityAspectReference<amc, amc>(base.f()), false, true, false), null, null, null));
			base.Area.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return true;
		}
		return false;
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x002A974C File Offset: 0x002A794C
	public atm(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x040029B3 RID: 10675
	private new bool a = true;

	// Token: 0x020011EC RID: 4588
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006297 RID: 25239 RVA: 0x002A9B80 File Offset: 0x002A7D80
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040029B7 RID: 10679
		public static readonly atm.a a = new atm.a();

		// Token: 0x040029B8 RID: 10680
		public static Func<b0b, bool> b;
	}
}
