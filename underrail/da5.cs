using System;
using System.Runtime.Serialization;

// Token: 0x02000C67 RID: 3175
[eiz("POHIC")]
[Serializable]
public sealed class da5 : dnh
{
	// Token: 0x0600476E RID: 18286 RVA: 0x001D7444 File Offset: 0x001D5644
	private da5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("POHIC:I");
	}

	// Token: 0x0600476F RID: 18287 RVA: 0x001D7460 File Offset: 0x001D5660
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("POHIC:I", this.a);
	}

	// Token: 0x06004770 RID: 18288 RVA: 0x001D747C File Offset: 0x001D567C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06004771 RID: 18289 RVA: 0x001D7484 File Offset: 0x001D5684
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004772 RID: 18290 RVA: 0x001D7490 File Offset: 0x001D5690
	public da5()
	{
	}

	// Token: 0x06004773 RID: 18291 RVA: 0x001D749C File Offset: 0x001D569C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (this.a != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				return d39.a(serviceOrThrow.aqu()).Contains(this.a);
			}
		}
		return false;
	}

	// Token: 0x04001C98 RID: 7320
	private string a;
}
