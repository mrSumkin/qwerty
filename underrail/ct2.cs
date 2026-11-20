using System;
using System.Runtime.Serialization;

// Token: 0x02001A5F RID: 6751
[eiz("BBAM")]
[Serializable]
public sealed class ct2 : bns, ISerializable
{
	// Token: 0x06009288 RID: 37512 RVA: 0x0039FB4C File Offset: 0x0039DD4C
	private ct2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009289 RID: 37513 RVA: 0x0039FB64 File Offset: 0x0039DD64
	public ct2()
	{
	}

	// Token: 0x0600928A RID: 37514 RVA: 0x0039FB78 File Offset: 0x0039DD78
	public override string h0(cd1 A_0)
	{
		return string.Format("Обратный удар: наносит {0} от обычного урона в виде теплового урона всему, что находится на клетке за пользователем. Если клетка заблокирована препятствием, урон наносится пользователю.", this.a.ToString("P0"));
	}

	// Token: 0x0600928B RID: 37515 RVA: 0x0039FB98 File Offset: 0x0039DD98
	public override bns h1()
	{
		ct2 ct = new ct2();
		this.h2(ct);
		return ct;
	}

	// Token: 0x0600928C RID: 37516 RVA: 0x0039FBB4 File Offset: 0x0039DDB4
	protected override void h2(bns A_0)
	{
		base.h2(A_0);
		((ct2)A_0).a = this.a;
	}

	// Token: 0x0400385D RID: 14429
	public new float a = 0.25f;
}
