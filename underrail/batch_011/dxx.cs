using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B73 RID: 2931
[eiz("FOCOPCJ")]
[Serializable]
public sealed class dxx : cze, ISerializable
{
	// Token: 0x0600430B RID: 17163 RVA: 0x001A3058 File Offset: 0x001A1258
	private dxx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600430C RID: 17164 RVA: 0x001A3064 File Offset: 0x001A1264
	public dxx()
	{
	}

	// Token: 0x0600430D RID: 17165 RVA: 0x001A3070 File Offset: 0x001A1270
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (A_2 != null && A_2.TryGetValue("CameraDestroyed", out obj) && obj is bool && (bool)obj)
		{
			return;
		}
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_prison_cameraRecordingDisabled", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["loc_fo_prison_caughtOnCamera"] = true;
		}
	}
}
