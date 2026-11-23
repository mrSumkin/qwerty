using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x02000C68 RID: 3176
[eiz("PHESC")]
[Serializable]
public sealed class ur : dnh
{
	// Token: 0x06004774 RID: 18292 RVA: 0x001D74E0 File Offset: 0x001D56E0
	private ur(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (PlayerHouseElement)A_0.GetValue("PHESC:E", typeof(PlayerHouseElement));
		this.b = A_0.GetString("PHESC:V");
		if (ell.a() >= 275)
		{
			this.c = A_0.GetBoolean("PHESC:I");
		}
	}

	// Token: 0x06004775 RID: 18293 RVA: 0x001D7548 File Offset: 0x001D5748
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHESC:E", this.a);
		info.AddValue("PHESC:V", this.b);
		info.AddValue("PHESC:I", this.c);
	}

	// Token: 0x06004776 RID: 18294 RVA: 0x001D7598 File Offset: 0x001D5798
	public PlayerHouseElement c()
	{
		return this.a;
	}

	// Token: 0x06004777 RID: 18295 RVA: 0x001D75A0 File Offset: 0x001D57A0
	public void a(PlayerHouseElement A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004778 RID: 18296 RVA: 0x001D75AC File Offset: 0x001D57AC
	public string a()
	{
		return this.b;
	}

	// Token: 0x06004779 RID: 18297 RVA: 0x001D75B4 File Offset: 0x001D57B4
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600477A RID: 18298 RVA: 0x001D75C0 File Offset: 0x001D57C0
	public bool b()
	{
		return this.c;
	}

	// Token: 0x0600477B RID: 18299 RVA: 0x001D75C8 File Offset: 0x001D57C8
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600477C RID: 18300 RVA: 0x001D75D4 File Offset: 0x001D57D4
	public ur()
	{
	}

	// Token: 0x0600477D RID: 18301 RVA: 0x001D75DC File Offset: 0x001D57DC
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bool flag = false;
		string text;
		if (serviceOrThrow.aqu() != null && d39.a(serviceOrThrow.aqu(), null).TryGetValue(this.a, out text))
		{
			flag = (text == this.b);
		}
		return this.c ^ flag;
	}

	// Token: 0x04001C99 RID: 7321
	private PlayerHouseElement a;

	// Token: 0x04001C9A RID: 7322
	private string b;

	// Token: 0x04001C9B RID: 7323
	private bool c;
}
