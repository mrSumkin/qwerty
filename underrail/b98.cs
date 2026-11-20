using System;
using System.Runtime.Serialization;

// Token: 0x02000F56 RID: 3926
[eiz("XPHWGCASC")]
[Serializable]
public sealed class b98 : dnh, ISerializable
{
	// Token: 0x06004F87 RID: 20359 RVA: 0x0023D0B8 File Offset: 0x0023B2B8
	private b98(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPHWGCASC:S");
	}

	// Token: 0x06004F88 RID: 20360 RVA: 0x0023D0D4 File Offset: 0x0023B2D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGCASC:S", this.a);
	}

	// Token: 0x06004F89 RID: 20361 RVA: 0x0023D0F0 File Offset: 0x0023B2F0
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F8A RID: 20362 RVA: 0x0023D0F8 File Offset: 0x0023B2F8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F8B RID: 20363 RVA: 0x0023D104 File Offset: 0x0023B304
	public b98()
	{
	}

	// Token: 0x06004F8C RID: 20364 RVA: 0x0023D110 File Offset: 0x0023B310
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			aud a_ = service.aqu().v().b().Area;
			c5x c5x = new ar7(c29.a, a_).ao() as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				flag = (!c5x.t.b.y6().HasProperty(ddq.ba) || !c5x.t.b.y6().GetPrimitivePropertyValue<bool>(ddq.ba, null).Value);
			}
		}
		return flag == this.a;
	}

	// Token: 0x06004F8D RID: 20365 RVA: 0x0023D1D4 File Offset: 0x0023B3D4
	public string a()
	{
		return "Стрелок авто-скрытность.";
	}

	// Token: 0x04002091 RID: 8337
	private bool a;
}
