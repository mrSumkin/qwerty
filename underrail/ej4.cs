using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020012CB RID: 4811
[eiz("ZMG")]
[Serializable]
public sealed class ej4 : cry, ISerializable, chb, c98
{
	// Token: 0x06006A3C RID: 27196 RVA: 0x002CC56C File Offset: 0x002CA76C
	private ej4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006A3D RID: 27197 RVA: 0x002CC578 File Offset: 0x002CA778
	public override string gv()
	{
		return "zombieMutagenGas";
	}

	// Token: 0x06006A3E RID: 27198 RVA: 0x002CC580 File Offset: 0x002CA780
	public override bool gw()
	{
		return false;
	}

	// Token: 0x06006A3F RID: 27199 RVA: 0x002CC584 File Offset: 0x002CA784
	public ej4(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06006A40 RID: 27200 RVA: 0x002CC590 File Offset: 0x002CA790
	public override void gx(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive)
		{
			if ((A_0.h.b.aa().b(d8o.b) || A_0.h.b.am() == "dog") && !A_0.h.b.am().StartsWith("mgh") && !A_0.h.b.am().StartsWith("mutated_human") && !A_0.h.b.aa().b(d8o.t))
			{
				if (A_0.h.b.aa().Gear.l().Item != null && A_0.h.b.aa().Gear.l().Item.Definition.a5() == "biohazardSuit")
				{
					return;
				}
				if (!A_0.h.b.aa().StatusEffects.a(dal.a))
				{
					A_0.h.b.aa().StatusEffects.a(new dal(), false, false, false);
					return;
				}
			}
			else
			{
				if (A_0.h.b.am() == "cat")
				{
					this.a(A_0);
					return;
				}
				if (A_0.h.b.aa().b(d8o.i))
				{
					if (A_0.h.b.aa().Defense.q().zo() <= A_0.h.b.aa().Defense.q().zm() / 4f)
					{
						this.a(A_0);
						return;
					}
					cwt cwt = new cwt();
					cwt.b = true;
					cwt.p = true;
					cwt.l = true;
					cwt.f.Add(new csk(DamageType.Bio, (int)(A_0.h.b.aa().Defense.q().zm() / 8f)));
					cwt.y = "{2} получает ";
					akg a_ = new akg(null, A_0.h.b, cwt, null, false);
					A_0.Zone.ActionManager.g9(a_, atp.a);
				}
			}
		}
	}

	// Token: 0x06006A41 RID: 27201 RVA: 0x002CC828 File Offset: 0x002CAA28
	private void a(c5x A_0)
	{
		ak1 a_ = A_0.Area.a(A_0.aj().a());
		dtb dtb = new dtb();
		bfq bfq = new bfq("AcidFizz");
		bfq.a(0.5f);
		bfq a_2 = bfq;
		dtb.ad().Add(new a4s(a_2, null, new ar7(A_0), null));
		List<auv> list = dtb.ad();
		string a_3 = "AcidSplash";
		int a_4 = 1;
		double maxValue = double.MaxValue;
		bool a_5 = true;
		bool a_6 = true;
		float? a_7 = dz6.b();
		list.Add(new a7j(A_0, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null));
		dtb.ad().Add(new a4s(new dku(new edx(a_), new EntityAspectReference<amc, amc>(A_0.h.b), false, true, false), null, null, null));
		A_0.Zone.ActionManager.g9(dtb, atp.a);
		A_0.h.b.aa().a(null, null, false);
	}

	// Token: 0x06006A42 RID: 27202 RVA: 0x002CC930 File Offset: 0x002CAB30
	protected override void gy(c5x A_0)
	{
		this.gx(A_0);
		if (A_0 != null && A_0.h.b != null)
		{
			efk efk = A_0.h.b.aa();
			etc microfeat = efk.GetMicrofeat<etc>();
			if (microfeat != null)
			{
				microfeat.a(efk, base.f());
			}
		}
	}
}
