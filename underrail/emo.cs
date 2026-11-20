using System;
using System.Runtime.Serialization;

// Token: 0x02000F55 RID: 3925
[eiz("XPHWGMPSC")]
[Serializable]
public sealed class emo : dnh, ISerializable
{
	// Token: 0x06004F80 RID: 20352 RVA: 0x0023CFA0 File Offset: 0x0023B1A0
	private emo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPHWGMPSC:M");
	}

	// Token: 0x06004F81 RID: 20353 RVA: 0x0023CFBC File Offset: 0x0023B1BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGMPSC:M", this.a);
	}

	// Token: 0x06004F82 RID: 20354 RVA: 0x0023CFD8 File Offset: 0x0023B1D8
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F83 RID: 20355 RVA: 0x0023CFE0 File Offset: 0x0023B1E0
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F84 RID: 20356 RVA: 0x0023CFEC File Offset: 0x0023B1EC
	public emo()
	{
	}

	// Token: 0x06004F85 RID: 20357 RVA: 0x0023CFF8 File Offset: 0x0023B1F8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			aud a_ = service.aqu().v().b().Area;
			c5x c5x = new ar7(c29.a, a_).ao() as c5x;
			if (c5x != null && c5x.t.b != null && c5x.t.b.y6().HasProperty(c29.e))
			{
				flag = c5x.t.b.y6().GetPrimitivePropertyValue<bool>(c29.e, null).Value;
			}
		}
		return flag == this.a;
	}

	// Token: 0x06004F86 RID: 20358 RVA: 0x0023D0B0 File Offset: 0x0023B2B0
	public string a()
	{
		return "Стрелок соответствует скрытности игрока.";
	}

	// Token: 0x04002090 RID: 8336
	private bool a;
}
