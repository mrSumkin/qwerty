using System;
using System.Runtime.Serialization;

// Token: 0x02000F57 RID: 3927
[eiz("XPHWGCESSC")]
[Serializable]
public sealed class bl8 : dnh, ISerializable
{
	// Token: 0x06004F8E RID: 20366 RVA: 0x0023D1DC File Offset: 0x0023B3DC
	private bl8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPHWGCESSC:S");
	}

	// Token: 0x06004F8F RID: 20367 RVA: 0x0023D1F8 File Offset: 0x0023B3F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGCESSC:S", this.a);
	}

	// Token: 0x06004F90 RID: 20368 RVA: 0x0023D214 File Offset: 0x0023B414
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F91 RID: 20369 RVA: 0x0023D21C File Offset: 0x0023B41C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F92 RID: 20370 RVA: 0x0023D228 File Offset: 0x0023B428
	public bl8()
	{
	}

	// Token: 0x06004F93 RID: 20371 RVA: 0x0023D230 File Offset: 0x0023B430
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			aud a_ = service.aqu().v().b().Area;
			c5x c5x = new ar7(c29.a, a_).ao() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.h.b != null && c5x.h.b.aa().Gear.h().Item != null)
			{
				flag = c5x.h.b.aa().Defense.i4();
			}
		}
		return flag == this.a;
	}

	// Token: 0x06004F94 RID: 20372 RVA: 0x0023D2EC File Offset: 0x0023B4EC
	public string a()
	{
		return "Энергетический щит стрелка.";
	}

	// Token: 0x04002092 RID: 8338
	private bool a;
}
