using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B41 RID: 2881
[eiz("SGSLRCJ")]
[Serializable]
public sealed class b1f : cze, ISerializable
{
	// Token: 0x06004240 RID: 16960 RVA: 0x0019AA84 File Offset: 0x00198C84
	private b1f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004241 RID: 16961 RVA: 0x0019AA90 File Offset: 0x00198C90
	public b1f()
	{
	}

	// Token: 0x06004242 RID: 16962 RVA: 0x0019AA9C File Offset: 0x00198C9C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_sgs_tutorial_lockpickingRoomExitOpened", new bool?(false)).Value)
		{
			d2b d2b = new EntityAspectReference<d2b, d2b>(A_1.Area, new Guid("96635531-ba59-4a56-ab02-b14f96d87281")).ao();
			d2b d2b2 = new EntityAspectReference<d2b, d2b>(A_1.Area, new Guid("f9dc0c07-f896-4dde-b9f1-d5ed7940adbd")).ao();
			if (d2b != null && !d2b.n() && d2b2 != null && !d2b2.n())
			{
				serviceOrThrow.aqu().r()["loc_sgs_tutorial_lockpickingRoomExitOpened"] = true;
				crx crx = new crx();
				crx.a("sa2");
				crx.c().Add(new Guid("03c4b948-571e-417f-84d5-9acfccb4d850"));
				crx.a(bbo.b);
				crx.ym(A_0, A_1, null);
			}
		}
	}
}
