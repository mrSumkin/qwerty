using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001075 RID: 4213
[eiz("G11")]
[Serializable]
public sealed class a9w : cze, ISerializable
{
	// Token: 0x060057CF RID: 22479 RVA: 0x00263A14 File Offset: 0x00261C14
	private a9w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("G11:QN");
		this.b = A_0.GetBoolean("G11:PE");
	}

	// Token: 0x060057D0 RID: 22480 RVA: 0x00263A40 File Offset: 0x00261C40
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("G11:QN", this.a);
		info.AddValue("G11:PE", this.b);
	}

	// Token: 0x060057D1 RID: 22481 RVA: 0x00263A6C File Offset: 0x00261C6C
	public string b()
	{
		return this.a;
	}

	// Token: 0x060057D2 RID: 22482 RVA: 0x00263A74 File Offset: 0x00261C74
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057D3 RID: 22483 RVA: 0x00263A80 File Offset: 0x00261C80
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060057D4 RID: 22484 RVA: 0x00263A88 File Offset: 0x00261C88
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060057D5 RID: 22485 RVA: 0x00263A94 File Offset: 0x00261C94
	public a9w()
	{
	}

	// Token: 0x060057D6 RID: 22486 RVA: 0x00263AA0 File Offset: 0x00261CA0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				ai8 ai = ck.a(this.a);
				if (ai != null && serviceOrThrow.aqu().v().Feats.a(ai) && serviceOrThrow.aqu().v().Feats.b(ai.GetType()))
				{
					serviceOrThrow.aqu().v().bl();
					if (this.b)
					{
						a7v.a(new aoi(new ap9(serviceOrThrow.aqu().v()), this.a));
					}
				}
			}
		}
	}

	// Token: 0x0400237E RID: 9086
	private new string a;

	// Token: 0x0400237F RID: 9087
	private bool b;
}
