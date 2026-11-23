using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A55 RID: 2645
[eiz("SGSPHMBJ")]
[Serializable]
public sealed class bls : cze, ISerializable
{
	// Token: 0x06003E94 RID: 16020 RVA: 0x00179D98 File Offset: 0x00177F98
	private bls(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E95 RID: 16021 RVA: 0x00179DA4 File Offset: 0x00177FA4
	public bls()
	{
	}

	// Token: 0x06003E96 RID: 16022 RVA: 0x00179DB0 File Offset: 0x00177FB0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dun_lup-a_explorer_ready", new bool?(false)).Value)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dun_lup-a_explorer_haroldShouldMessage", new bool?(false)).Value)
			{
				d23 d = new d23();
				d.c("Гарольд");
				d.a("harold");
				d.d("messages\\Harold/minibot");
				d.b("Мини-робот");
				d.ym(A_0, A_1, null);
			}
			serviceOrThrow.aqu().a(new bw0("StationAlpha-Level7", new aw5(), 1));
			serviceOrThrow.aqu().r()["loc_dun_lup-a_explorer_ready"] = true;
		}
	}
}
