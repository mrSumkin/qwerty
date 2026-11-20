using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x02000B8E RID: 2958
[eiz("CCSHESJ")]
[Serializable]
public sealed class dhi : cze, ISerializable
{
	// Token: 0x06004365 RID: 17253 RVA: 0x001A5EBC File Offset: 0x001A40BC
	private dhi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (PlayerHouseElement)A_0.GetValue("CCSHESJ:E", typeof(PlayerHouseElement));
		this.b = A_0.GetString("CCSHESJ:V");
	}

	// Token: 0x06004366 RID: 17254 RVA: 0x001A5EF8 File Offset: 0x001A40F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCSHESJ:E", this.a);
		info.AddValue("CCSHESJ:V", this.b);
	}

	// Token: 0x06004367 RID: 17255 RVA: 0x001A5F2C File Offset: 0x001A412C
	public PlayerHouseElement b()
	{
		return this.a;
	}

	// Token: 0x06004368 RID: 17256 RVA: 0x001A5F34 File Offset: 0x001A4134
	public void a(PlayerHouseElement A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004369 RID: 17257 RVA: 0x001A5F40 File Offset: 0x001A4140
	public string a()
	{
		return this.b;
	}

	// Token: 0x0600436A RID: 17258 RVA: 0x001A5F48 File Offset: 0x001A4148
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600436B RID: 17259 RVA: 0x001A5F54 File Offset: 0x001A4154
	public dhi()
	{
	}

	// Token: 0x0600436C RID: 17260 RVA: 0x001A5F5C File Offset: 0x001A415C
	public dhi(PlayerHouseElement A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600436D RID: 17261 RVA: 0x001A5F78 File Offset: 0x001A4178
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d39.a(serviceOrThrow.aqu(), null)[this.a] = this.b;
			HashSet<string> hashSet = d39.a(serviceOrThrow.aqu());
			if (!string.IsNullOrEmpty(this.b))
			{
				hashSet.Add(this.b);
			}
		}
	}

	// Token: 0x04001C41 RID: 7233
	private new PlayerHouseElement a;

	// Token: 0x04001C42 RID: 7234
	private string b;
}
