using System;
using System.Runtime.Serialization;

// Token: 0x02000F54 RID: 3924
[eiz("XPHWGMPSUC")]
[Serializable]
public sealed class fw : dnh, ISerializable
{
	// Token: 0x06004F79 RID: 20345 RVA: 0x0023CE88 File Offset: 0x0023B088
	private fw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPHWGMPSUC:M");
	}

	// Token: 0x06004F7A RID: 20346 RVA: 0x0023CEA4 File Offset: 0x0023B0A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGMPSUC:M", this.a);
	}

	// Token: 0x06004F7B RID: 20347 RVA: 0x0023CEC0 File Offset: 0x0023B0C0
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F7C RID: 20348 RVA: 0x0023CEC8 File Offset: 0x0023B0C8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F7D RID: 20349 RVA: 0x0023CED4 File Offset: 0x0023B0D4
	public fw()
	{
	}

	// Token: 0x06004F7E RID: 20350 RVA: 0x0023CEE0 File Offset: 0x0023B0E0
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			aud a_ = service.aqu().v().b().Area;
			c5x c5x = new ar7(c29.a, a_).ao() as c5x;
			if (c5x != null && c5x.t.b != null && c5x.t.b.y6().HasProperty(c29.d))
			{
				flag = c5x.t.b.y6().GetPrimitivePropertyValue<bool>(c29.d, null).Value;
			}
		}
		return flag == this.a;
	}

	// Token: 0x06004F7F RID: 20351 RVA: 0x0023CF98 File Offset: 0x0023B198
	public string a()
	{
		return "Стрелок соответствует использованию щиту игрока.";
	}

	// Token: 0x0400208F RID: 8335
	private bool a;
}
