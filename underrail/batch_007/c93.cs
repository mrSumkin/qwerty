using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010FE RID: 4350
[eiz("G09")]
[Serializable]
public sealed class c93 : cze, ISerializable
{
	// Token: 0x06005C44 RID: 23620 RVA: 0x002779A8 File Offset: 0x00275BA8
	private c93(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("G09:QN");
		this.b = A_0.GetBoolean("G09:PE");
	}

	// Token: 0x06005C45 RID: 23621 RVA: 0x002779D4 File Offset: 0x00275BD4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("G09:QN", this.a);
		info.AddValue("G09:PE", this.b);
	}

	// Token: 0x06005C46 RID: 23622 RVA: 0x00277A00 File Offset: 0x00275C00
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005C47 RID: 23623 RVA: 0x00277A08 File Offset: 0x00275C08
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C48 RID: 23624 RVA: 0x00277A14 File Offset: 0x00275C14
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005C49 RID: 23625 RVA: 0x00277A1C File Offset: 0x00275C1C
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005C4A RID: 23626 RVA: 0x00277A28 File Offset: 0x00275C28
	public c93()
	{
	}

	// Token: 0x06005C4B RID: 23627 RVA: 0x00277A30 File Offset: 0x00275C30
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				ai8 ai = ck.a(this.a);
				if (ai != null && !serviceOrThrow.aqu().v().Feats.a(ai) && serviceOrThrow.aqu().v().Feats.d(ai.GetType()) && this.b)
				{
					a7v.a(new m(new ap9(serviceOrThrow.aqu().v()), this.a));
				}
			}
		}
	}

	// Token: 0x040024D5 RID: 9429
	private new string a;

	// Token: 0x040024D6 RID: 9430
	private bool b;
}
