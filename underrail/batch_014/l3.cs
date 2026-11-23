using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000AF6 RID: 2806
[eiz("XPBLGPSRSJ")]
[Serializable]
public sealed class l3 : cze, ISerializable
{
	// Token: 0x06004122 RID: 16674 RVA: 0x0018D9B4 File Offset: 0x0018BBB4
	private l3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004123 RID: 16675 RVA: 0x0018D9C0 File Offset: 0x0018BBC0
	public l3()
	{
	}

	// Token: 0x06004124 RID: 16676 RVA: 0x0018D9C8 File Offset: 0x0018BBC8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(bp5.l, new int?(0)).Value;
			dj3 dj = new dj3();
			dj.g("Нарисованная руна");
			dj.f("SormirbarenRune" + value.ToString());
			dj.i("Ингвар нарисовал на песке руну, передавая тем самым вам свою историю. Это кажется достаточно важным, чтобы записать.");
			mk mk = new mk();
			mk.GiveTo = bvl.d;
			mk.StaticItems.z3(new d48(new IndependentItemDefinitionProvider<dj3>(dj)), true);
			mk.PublishEventsForPlayer = true;
			mk.ym(null, null, null);
		}
	}
}
