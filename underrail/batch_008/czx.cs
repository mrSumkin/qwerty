using System;
using System.Runtime.Serialization;

// Token: 0x02000F59 RID: 3929
[eiz("XPHWGCAWSCC")]
[Serializable]
public sealed class czx : dnh, ISerializable
{
	// Token: 0x06004F9C RID: 20380 RVA: 0x0023D454 File Offset: 0x0023B654
	private czx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPHWGCAWSCC:I");
	}

	// Token: 0x06004F9D RID: 20381 RVA: 0x0023D470 File Offset: 0x0023B670
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWGCAWSCC:I", this.a);
	}

	// Token: 0x06004F9E RID: 20382 RVA: 0x0023D48C File Offset: 0x0023B68C
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004F9F RID: 20383 RVA: 0x0023D494 File Offset: 0x0023B694
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FA0 RID: 20384 RVA: 0x0023D4A0 File Offset: 0x0023B6A0
	public czx()
	{
	}

	// Token: 0x06004FA1 RID: 20385 RVA: 0x0023D4A8 File Offset: 0x0023B6A8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		return d7o.a() ^ this.a;
	}

	// Token: 0x06004FA2 RID: 20386 RVA: 0x0023D4B8 File Offset: 0x0023B6B8
	public string a()
	{
		return "Стрелок может помочь при проверке силы.";
	}

	// Token: 0x04002094 RID: 8340
	private bool a;
}
