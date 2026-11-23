using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001396 RID: 5014
[eiz("PBVHEA")]
[bs6("HFX:PoisonBurstVisual")]
[Serializable]
public sealed class b4y : cpl, ISerializable
{
	// Token: 0x06007153 RID: 29011 RVA: 0x002F92B0 File Offset: 0x002F74B0
	private b4y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007154 RID: 29012 RVA: 0x002F92BC File Offset: 0x002F74BC
	public b4y()
	{
	}

	// Token: 0x06007155 RID: 29013 RVA: 0x002F92C8 File Offset: 0x002F74C8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_ = base.b().a8();
		string a_2 = "PoisonBurst";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "PoisonBurst"), null, new ar7(base.b().a8()), null));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}
}
