using System;
using System.Runtime.Serialization;

// Token: 0x0200051E RID: 1310
[eiz("FCFSE")]
[Serializable]
public sealed class eoa : c47, ISerializable
{
	// Token: 0x060021BC RID: 8636 RVA: 0x000B3DD0 File Offset: 0x000B1FD0
	private eoa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("FCFSE:CFI");
			this.b = A_0.GetString("FCFSE:SFI");
			this.c = A_0.GetString("FCFSE:TFI");
			this.d = (h)A_0.GetValue("FCFSE:A", typeof(h));
			return;
		}
		if (base.GetType() == typeof(eoa))
		{
			this.a = A_0.GetString("_CallerFactionId");
			this.b = A_0.GetString("_SupporterFactionId");
			this.c = A_0.GetString("_TargetFactionId");
			this.d = (h)A_0.GetValue("_Attitude", typeof(h));
			return;
		}
		this.a = A_0.GetString("FactionCallForSupportEvent+_CallerFactionId");
		this.b = A_0.GetString("FactionCallForSupportEvent+_SupporterFactionId");
		this.c = A_0.GetString("FactionCallForSupportEvent+_TargetFactionId");
		this.d = (h)A_0.GetValue("FactionCallForSupportEvent+_Attitude", typeof(h));
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x000B3F04 File Offset: 0x000B2104
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FCFSE:CFI", this.a);
		info.AddValue("FCFSE:SFI", this.b);
		info.AddValue("FCFSE:TFI", this.c);
		info.AddValue("FCFSE:A", this.d);
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x000B3F64 File Offset: 0x000B2164
	public string c()
	{
		return this.c;
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x000B3F6C File Offset: 0x000B216C
	public string e()
	{
		return this.b;
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x000B3F74 File Offset: 0x000B2174
	public string d()
	{
		return this.a;
	}

	// Token: 0x060021C1 RID: 8641 RVA: 0x000B3F7C File Offset: 0x000B217C
	public h f()
	{
		return this.d;
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x000B3F84 File Offset: 0x000B2184
	public eoa(string A_0, string A_1, string A_2, h A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x0400145E RID: 5214
	private string a;

	// Token: 0x0400145F RID: 5215
	private string b;

	// Token: 0x04001460 RID: 5216
	private string c;

	// Token: 0x04001461 RID: 5217
	private h d;
}
