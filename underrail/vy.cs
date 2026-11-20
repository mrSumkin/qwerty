using System;
using System.Runtime.Serialization;

// Token: 0x02000F53 RID: 3923
[eiz("XPHWGAEEC")]
[Serializable]
public sealed class vy : dnh, ISerializable
{
	// Token: 0x06004F72 RID: 20338 RVA: 0x0023CD74 File Offset: 0x0023AF74
	private vy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPHWGAEEC:AEE");
	}

	// Token: 0x06004F73 RID: 20339 RVA: 0x0023CD90 File Offset: 0x0023AF90
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGAEEC:AEE", this.a);
	}

	// Token: 0x06004F74 RID: 20340 RVA: 0x0023CDAC File Offset: 0x0023AFAC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06004F75 RID: 20341 RVA: 0x0023CDB4 File Offset: 0x0023AFB4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F76 RID: 20342 RVA: 0x0023CDC0 File Offset: 0x0023AFC0
	public vy()
	{
	}

	// Token: 0x06004F77 RID: 20343 RVA: 0x0023CDC8 File Offset: 0x0023AFC8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			aud a_ = service.aqu().v().b().Area;
			c5x c5x = new ar7(c29.a, a_).ao() as c5x;
			if (c5x != null && c5x.t.b != null && c5x.t.b.y6().HasProperty(c29.f))
			{
				flag = c5x.t.b.y6().GetPrimitivePropertyValue<bool>(c29.f, null).Value;
			}
		}
		return flag == this.a;
	}

	// Token: 0x06004F78 RID: 20344 RVA: 0x0023CE80 File Offset: 0x0023B080
	public string b()
	{
		return "Стрелок избегает вступления в бой с врагами.";
	}

	// Token: 0x0400208E RID: 8334
	private bool a;
}
