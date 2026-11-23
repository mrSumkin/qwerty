using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020013A7 RID: 5031
[eiz("ACY8")]
[bs6("HFX:pneumaticHammerVisualHit")]
[Serializable]
public sealed class ejc : cpl, ISerializable
{
	// Token: 0x0600718D RID: 29069 RVA: 0x002FA8EC File Offset: 0x002F8AEC
	private ejc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600718E RID: 29070 RVA: 0x002FA8F8 File Offset: 0x002F8AF8
	public ejc()
	{
	}

	// Token: 0x0600718F RID: 29071 RVA: 0x002FA904 File Offset: 0x002F8B04
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_ = base.b().a8();
		string a_2 = "PneumaticHit";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}
}
