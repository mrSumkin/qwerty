using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001366 RID: 4966
[eiz("BPSHY")]
[bs6("HFX:burnPsi")]
[Serializable]
public sealed class al3 : cpl, ISerializable
{
	// Token: 0x060070AA RID: 28842 RVA: 0x002F4C10 File Offset: 0x002F2E10
	private al3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070AB RID: 28843 RVA: 0x002F4C1C File Offset: 0x002F2E1C
	public al3()
	{
	}

	// Token: 0x060070AC RID: 28844 RVA: 0x002F4C24 File Offset: 0x002F2E24
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		c5x c5x = base.b().a8();
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		if (!c5x.h.b.aa().Passive && !c5x.h.b.aa().c(d8o.e))
		{
			if (c5x.h.b.aa().d(CharacterImmunities.MindAffecting) || !c5x.h.b.aa().Feats.Contains<c3v>())
			{
				etm a_ = new etm(new ap9(c5x.h.b.aa()), "пси сжиганию");
				bey.a(a_, base.a().aa(), c5x.h.b.aa(), c5x.h.b);
				a7v.a(a_);
				bmj.a(c5x, new ba0());
			}
			else
			{
				c5x a_2 = c5x;
				string a_3 = "MindBurn";
				int a_4 = 1;
				double maxValue = double.MaxValue;
				bool a_5 = true;
				bool a_6 = true;
				Vector3? a_7 = new Vector3?(new Vector3(0f, 0f, c5x.Size.Z * 0.3f));
				float? a_8 = dz6.b();
				a7j item = new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, a_7, null, null, a_8, false, null);
				qy.ad().Add(item);
				bfq bfq = new bfq();
				bfq.b("MindBurn" + Guid.NewGuid().ToString());
				bfq.c("MindBurn");
				bfq.a(bvl.c);
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				qy.ad().Add(new bea(new EntityAspectReference<amc, amc>(c5x.h.b), -base.agu().Power, true));
			}
		}
		qy.ad().Add(new buc(new EntityAspectReference<amc, amc>(c5x.h.b)));
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}
}
