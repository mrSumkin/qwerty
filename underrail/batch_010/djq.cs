using System;
using System.Runtime.Serialization;

// Token: 0x02001A10 RID: 6672
[eiz("SBAFE")]
[Serializable]
public sealed class djq : dts, bdr, ISerializable
{
	// Token: 0x06009025 RID: 36901 RVA: 0x003998EC File Offset: 0x00397AEC
	private djq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SBAFE:BAN");
	}

	// Token: 0x06009026 RID: 36902 RVA: 0x00399908 File Offset: 0x00397B08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBAFE:BAN", this.a);
	}

	// Token: 0x06009027 RID: 36903 RVA: 0x00399924 File Offset: 0x00397B24
	public string a()
	{
		return this.a;
	}

	// Token: 0x06009028 RID: 36904 RVA: 0x0039992C File Offset: 0x00397B2C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009029 RID: 36905 RVA: 0x00399938 File Offset: 0x00397B38
	public override bool ae5()
	{
		return base.c() < 3;
	}

	// Token: 0x0600902A RID: 36906 RVA: 0x00399944 File Offset: 0x00397B44
	public djq()
	{
	}

	// Token: 0x0600902B RID: 36907 RVA: 0x0039994C File Offset: 0x00397B4C
	public djq(string A_0, int A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x0600902C RID: 36908 RVA: 0x00399960 File Offset: 0x00397B60
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (!string.IsNullOrWhiteSpace(this.a) && A_0.a() != null)
		{
			to to = A_0.a().BaseAbilities.a(this.a);
			if (to != null)
			{
				to.b(base.c());
			}
		}
	}

	// Token: 0x0600902D RID: 36909 RVA: 0x003999BC File Offset: 0x00397BBC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((djq)A_0).a = this.a;
	}

	// Token: 0x0600902E RID: 36910 RVA: 0x003999D8 File Offset: 0x00397BD8
	public override d3e b3()
	{
		djq djq = new djq();
		this.xx(djq);
		return djq;
	}

	// Token: 0x0600902F RID: 36911 RVA: 0x003999F4 File Offset: 0x00397BF4
	public override string b2()
	{
		return string.Format("{0} установлен на {1}", this.a, base.c());
	}

	// Token: 0x04003803 RID: 14339
	private new string a;
}
