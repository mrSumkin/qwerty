using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A89 RID: 2697
[eiz("TCHSFIJ")]
[Serializable]
public sealed class ag1 : cze, ISerializable
{
	// Token: 0x06003F5D RID: 16221 RVA: 0x0017FD4C File Offset: 0x0017DF4C
	private ag1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x0017FD58 File Offset: 0x0017DF58
	public ag1()
	{
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x0017FD64 File Offset: 0x0017DF64
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_invasionStarted", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["loc_tch_invasionStarted"] = true;
			foreach (bfc bfc in serviceOrThrow.aq0().a())
			{
				if (!string.IsNullOrEmpty(bfc.Id) && bfc.Id.StartsWith("tch", StringComparison.OrdinalIgnoreCase))
				{
					serviceOrThrow.aqu().a(new bw0(bfc.Id, new un(), 1));
				}
			}
			serviceOrThrow.aqu().a(new bw0("tch-lib", new a9v(), 1));
			serviceOrThrow.aqu().a(new bw0("tch-ww1", new dy3(), 1));
			serviceOrThrow.aqu().a(new bw0("tch-ww4", new o4(), 1));
			serviceOrThrow.aqu().a(new bw0("tch-entry", new cfl(), 1));
			serviceOrThrow.aqu().a(new bw0("tch-util1", new cvp(), 1));
			serviceOrThrow.aqu().a(new bw0("tch-util2", new di9(), 1));
			serviceOrThrow.aqu().a(new bw0("tch-util3", new di9(), 1));
		}
	}
}
