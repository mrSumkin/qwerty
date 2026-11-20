using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001101 RID: 4353
[eiz("RLDJ")]
[Serializable]
public sealed class dmw : cze, ISerializable
{
	// Token: 0x06005C5A RID: 23642 RVA: 0x00277C64 File Offset: 0x00275E64
	private dmw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("RLDJ:N");
		this.a(A_0.GetValue("RLDJ:Z", typeof(a55)) as a55);
	}

	// Token: 0x06005C5B RID: 23643 RVA: 0x00277CAC File Offset: 0x00275EAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RLDJ:N", this.a);
		info.AddValue("RLDJ:Z", this.b);
	}

	// Token: 0x06005C5C RID: 23644 RVA: 0x00277CD8 File Offset: 0x00275ED8
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005C5D RID: 23645 RVA: 0x00277CE0 File Offset: 0x00275EE0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C5E RID: 23646 RVA: 0x00277CEC File Offset: 0x00275EEC
	public a55 a()
	{
		return this.b;
	}

	// Token: 0x06005C5F RID: 23647 RVA: 0x00277CF4 File Offset: 0x00275EF4
	public void a(a55 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005C60 RID: 23648 RVA: 0x00277D00 File Offset: 0x00275F00
	public dmw(c1a A_0, string A_1)
	{
		this.b = new a55(A_0);
		this.a = A_1;
	}

	// Token: 0x06005C61 RID: 23649 RVA: 0x00277D1C File Offset: 0x00275F1C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a().ao() != null && !string.IsNullOrEmpty(this.a))
		{
			this.a().ao().d(this.a);
		}
	}

	// Token: 0x040024D9 RID: 9433
	private new string a;

	// Token: 0x040024DA RID: 9434
	private a55 b;
}
