using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A2 RID: 4258
[eiz("TTRJ")]
[Serializable]
public sealed class b2t : cze, ISerializable
{
	// Token: 0x0600594B RID: 22859 RVA: 0x00269F90 File Offset: 0x00268190
	private b2t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("TTRJ:L");
		this.b = A_0.GetString("TTRJ:R");
	}

	// Token: 0x0600594C RID: 22860 RVA: 0x00269FBC File Offset: 0x002681BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TTRJ:L", this.a);
		info.AddValue("TTRJ:R", this.b);
	}

	// Token: 0x0600594D RID: 22861 RVA: 0x00269FE8 File Offset: 0x002681E8
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600594E RID: 22862 RVA: 0x00269FF0 File Offset: 0x002681F0
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600594F RID: 22863 RVA: 0x00269FFC File Offset: 0x002681FC
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005950 RID: 22864 RVA: 0x0026A004 File Offset: 0x00268204
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005951 RID: 22865 RVA: 0x0026A010 File Offset: 0x00268210
	public b2t()
	{
	}

	// Token: 0x06005952 RID: 22866 RVA: 0x0026A01C File Offset: 0x0026821C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = A_0 as c5x;
			c5x c5x2 = A_1 as c5x;
			if (c5x != null && c5x.IsPlayer && c5x2 != null && c5x2.GetAspect<bim>() is eh6)
			{
				serviceOrThrow.aqu().r()["Rift_TargetLocaleId"] = this.a;
				serviceOrThrow.aqu().r()["Rift_TargetRiftId"] = this.b;
				bpo.GetServiceOrThrow<ps>().am3("RiftTravel");
			}
		}
	}

	// Token: 0x040023E8 RID: 9192
	private new string a;

	// Token: 0x040023E9 RID: 9193
	private string b;
}
