using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B34 RID: 2868
[eiz("S34")]
[Serializable]
public sealed class dlt : cze, ISerializable
{
	// Token: 0x0600420F RID: 16911 RVA: 0x00199764 File Offset: 0x00197964
	private dlt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x00199770 File Offset: 0x00197970
	public dlt()
	{
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x0019977C File Offset: 0x0019797C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = bpo.GetServiceOrThrow<cnk>().aqu().v().b() as c5x;
		if (c5x != null && c5x.Area != null)
		{
			c5x.Area;
			a0l.a(c5x, "playerWake", true);
			c5x c5x2 = new ar7(new Guid("8fdc3e39-d1bd-409b-9e82-1fb459155f17"), c5x.Area).ao() as c5x;
			if (c5x2 != null)
			{
				a0l.a(c5x2, "doctorWake", true);
			}
			bpo.GetServiceOrThrow<ps>().amr(true, null, false);
		}
	}
}
