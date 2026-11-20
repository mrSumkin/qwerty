using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013C3 RID: 5059
[bs6("HFX:SpewAcid")]
[eiz("ACX2")]
[Serializable]
public sealed class eqm : cpl, ISerializable
{
	// Token: 0x060071F7 RID: 29175 RVA: 0x002FDF7C File Offset: 0x002FC17C
	private eqm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071F8 RID: 29176 RVA: 0x002FDF88 File Offset: 0x002FC188
	public eqm()
	{
	}

	// Token: 0x060071F9 RID: 29177 RVA: 0x002FDF90 File Offset: 0x002FC190
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().a8() == null || base.ag0() == null)
		{
			return dc4.e;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() == null)
		{
			return dc4.e;
		}
		aud aud;
		Vector3 a_;
		base.ag0().a(serviceOrThrow.aqw(), out aud, out a_);
		if (aud == null)
		{
			return dc4.e;
		}
		ak1 ak = aud.a(a_.a());
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		bfq a_2 = new bfq("AcidFizz");
		dtb.ad().Add(new a4s(a_2, null, new ar7(base.b().a8()), null));
		if (base.agw() != null && base.agw().x == AmmoType.Vial_Acid_Corrosive)
		{
			List<auv> list = dtb.ad();
			c5x a_3 = base.b().a8();
			string a_4 = "CorrosiveAcidSplash";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			bool a_6 = true;
			bool a_7 = true;
			float? a_8 = dz6.b();
			list.Add(new a7j(a_3, a_4, a_5, maxValue, a_6, a_7, null, null, null, a_8, false, null));
			dtb.ad().Add(new amd(base.b(), new els[]
			{
				new deu(deu.c * d0u.b)
			}));
		}
		else if (base.agw() != null && base.agw().x == AmmoType.Vial_Acid_Rusting)
		{
			List<auv> list2 = dtb.ad();
			c5x a_9 = base.b().a8();
			string a_10 = "RustingAcidSplash";
			int a_11 = 1;
			double maxValue2 = double.MaxValue;
			bool a_12 = true;
			bool a_13 = true;
			float? a_8 = dz6.b();
			list2.Add(new a7j(a_9, a_10, a_11, maxValue2, a_12, a_13, null, null, null, a_8, false, null));
			dtb.ad().Add(new amd(base.b(), new els[]
			{
				new ce(ce.b * d0u.b)
			}));
		}
		else
		{
			List<auv> list3 = dtb.ad();
			c5x a_14 = base.b().a8();
			string a_15 = "AcidSplash";
			int a_16 = 1;
			double maxValue3 = double.MaxValue;
			bool a_17 = true;
			bool a_18 = true;
			float? a_8 = dz6.b();
			list3.Add(new a7j(a_14, a_15, a_16, maxValue3, a_17, a_18, null, null, null, a_8, false, null));
		}
		if (!base.agw().ad.GetPrimitivePropertyValue<bool>("SuppressAcidSpill", new bool?(false)).Value && ak != null)
		{
			if (base.agw() != null && base.agw().x == AmmoType.Vial_Acid_Corrosive)
			{
				dtb.ad().Add(new a4s(new b69(new edx(ak), base.agq()), null, null, null));
			}
			else if (base.agw() != null && base.agw().x == AmmoType.Vial_Acid_Rusting)
			{
				dtb.ad().Add(new a4s(new amg(new edx(ak), base.agq()), null, null, null));
			}
			else
			{
				dtb.ad().Add(new a4s(new dku(new edx(ak), base.agq(), false, true, false), null, null, null));
			}
		}
		serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}
}
